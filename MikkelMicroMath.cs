﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelMicroMath
{
    public class MikkelMicroMath
    {
        /// <summary>
        ///  Lægger to tal sammen
        /// </summary>
        /// <param name="a">første tal</param>
        /// <param name="b">andet tal</param>
        /// <returns>retunere et hel tal der er sum af a og b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        // approved server side

        /// <summary>
        /// Lægger 3 tal sammen
        /// </summary>
        /// <param name="a">første tal</param>
        /// <param name="b">andet tal</param>
        /// <param name="c">tredje tal</param>
        /// <returns>returnere sum af a, b og c</returns>
        public int Add3Numbers(int a, int b, int c)
        {
            return a + b + c; // adds 3 numbers 
        }
        // approved server side

        public int Subtract(int a, int b) // Med lille startbogstav
        {
            return a - b;
        }

        public int Multiply(int a, int b) // D:
        {
            return a * b;
        }

        public int Potens(int a, int b)
        {
            int result = 0;
            for (int i = 0; i<b ; i++)
            { result = a* a; }
            return result;
        }
    }
}
