using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter
{
    public class AdapterDemo
    {
        private Shape[] shapes;

        public void Main()
        {
            shapes = new Shape[]{new RectanlgeAdapter(new Rectangle()),
                                new LineAdapter(new Line())};
            int x1 = 10, y1 = 20;
            int x2 = 30, y2 = 60;
            foreach (Shape shape in shapes)
            {
                shape.Draw(x1, y1, x2, y2);
            }
        }
    }
}
