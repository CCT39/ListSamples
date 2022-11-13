using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample001
{
    internal class MyRectangle
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area
        {
            get { return Width * Height; }
            // 面積這個值是由Width和Height直接決定的，不可被亂設定，因此有set並不合理
        }
    }
}
