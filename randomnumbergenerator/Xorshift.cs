using System;
using System.Collections.Generic;
using System.Text;

namespace randomnumbergenerator
{
    class Xorshift
    {
        private const long m = 4294967296; // aka 2^32
        private const long a = 1664525;
        private const long c = 1013904223;
        private long _last;

        public Xorshift()
        {
            _last = DateTime.Now.Ticks % m;
        }

        public Xorshift(long seed)
        {
            _last = seed;
        }

        public long Next()
        {
            _last ^= _last << 13;
            _last ^= _last >> 17;
            _last ^= _last << 5;
            long res= (long)(_last % long.MaxValue);
            if (res < 0)
                res *= -1;
            return res;
        }

        public long Next(long minvalue, long maxvalue)
        {
            return minvalue + Next() % (maxvalue - minvalue);
        }
    }
}
