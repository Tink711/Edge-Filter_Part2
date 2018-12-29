using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeAndFilterTest
{
    public class RetrieveImage
    {
        public static Bitmap RetrieveImageFromPath(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            return (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
        }
    }
}
