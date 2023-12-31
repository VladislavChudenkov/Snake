﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Position
    {
        public int Left { get; set; }
        public int Top { get; set; }

        public Position(int left, int top)
        {
            Left = left;
            Top = top;
        }

        public static Position operator +(Position a, Position b)
        {
            return new Position(a.Left + b.Left, a.Top + b.Top);
        }
    }
}
