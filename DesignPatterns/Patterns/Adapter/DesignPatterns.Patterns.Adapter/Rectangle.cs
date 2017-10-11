using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter
{
    public class Rectangle
    {
        public void Draw(int x, int y, int width, int height)
        {
            Debug.WriteLine("Rectangle with coordinate left-down point (" + x + ";" + y + "), width: " + width + ", height: " + height);
        }
    }
}
