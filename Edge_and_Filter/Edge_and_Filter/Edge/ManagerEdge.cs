﻿using Edge_and_Filter.Edge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Edge_and_Filter
{
    public class ManagerEdge : InterfaceEdge
    {
        //Apply the filters(calculation of the colors)
        public Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix, double factor = 1, int bias = 0)
        {
            try
            {
                BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly,
                                                 PixelFormat.Format32bppArgb);

                byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
                byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

                Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
                sourceBitmap.UnlockBits(sourceData);

                double blue = 0.0;
                double green = 0.0;
                double red = 0.0;

                int filterWidth = filterMatrix.GetLength(1);
                int filterHeight = filterMatrix.GetLength(0);

                int filterOffset = (filterWidth - 1) / 2;
                int calcOffset = 0;

                int byteOffset = 0;

                for (int offsetY = filterOffset; offsetY <
                    sourceBitmap.Height - filterOffset; offsetY++)
                {

                    for (int offsetX = filterOffset; offsetX <
                        sourceBitmap.Width - filterOffset; offsetX++)
                    {
                        blue = 0;
                        green = 0;
                        red = 0;

                        byteOffset = offsetY *
                                     sourceData.Stride +
                                     offsetX * 4;

                        for (int filterY = -filterOffset;
                            filterY <= filterOffset; filterY++)
                        {
                            for (int filterX = -filterOffset;
                                filterX <= filterOffset; filterX++)
                            {

                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * sourceData.Stride);

                                blue += (double)(pixelBuffer[calcOffset]) *
                                        filterMatrix[filterY + filterOffset,
                                                            filterX + filterOffset];

                                green += (double)(pixelBuffer[calcOffset + 1]) *
                                         filterMatrix[filterY + filterOffset,
                                                            filterX + filterOffset];

                                red += (double)(pixelBuffer[calcOffset + 2]) *
                                       filterMatrix[filterY + filterOffset,
                                                          filterX + filterOffset];
                            }
                        }

                        blue = factor * blue + bias;
                        green = factor * green + bias;
                        red = factor * red + bias;

                        if (blue > 255)
                        { blue = 255; }
                        else if (blue < 0)
                        { blue = 0; }

                        if (green > 255)
                        { green = 255; }
                        else if (green < 0)
                        { green = 0; }

                        if (red > 255)
                        { red = 255; }
                        else if (red < 0)
                        { red = 0; }

                        resultBuffer[byteOffset] = (byte)(blue);
                        resultBuffer[byteOffset + 1] = (byte)(green);
                        resultBuffer[byteOffset + 2] = (byte)(red);
                        resultBuffer[byteOffset + 3] = 255;
                    }
                }


                Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

                BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                         resultBitmap.Width, resultBitmap.Height),
                                                          ImageLockMode.WriteOnly,
                                                     PixelFormat.Format32bppArgb);

                Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
                resultBitmap.UnlockBits(resultData);

                return resultBitmap;
            }
            catch(Exception e)
            {
                return null;
            }
            
        }
        //Retrieve the matrix of Lalpacian3x3 and run the method ConvolutionFilter to apply this filter
        public Bitmap Lalpacian3x3(Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = ConvolutionFilter(sourceBitmap,
                                    Matrix.Laplacian3x3, 1.0, 0);

            return resultBitmap;
        }
        //Retrieve the matrix of Lalpacian5x5 and run the method ConvolutionFilter to apply this filter
        public Bitmap Lalpacian5x5(Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = ConvolutionFilter(sourceBitmap,
                                    Matrix.Laplacian5x5, 1.0, 0);

            return resultBitmap;
        }
    }
}
