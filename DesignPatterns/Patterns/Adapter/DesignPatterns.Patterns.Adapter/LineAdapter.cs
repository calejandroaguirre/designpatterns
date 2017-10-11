﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter
{
    public class LineAdapter : Shape
    {
        private Line adaptee;

        public LineAdapter(Line line)
        {
            adaptee = line;
        }

       

        public override void Draw(int x1, int y1, int x2, int y2)
        {
            adaptee.Draw(x1, y1, x2, y2);
        }
    }
}
