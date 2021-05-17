using System;

namespace MemoryStructAlloc.Structures
{
    struct Point : IComparable
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            string s = string.Format($"(X-{0}, Y-{1})", X, Y);
            return s;
        }

        public int CompareTo(object obj)
        {
            return -1;
        }

        public int CompareTo(Point t)
        {
            return -1;
        }

    }
}
