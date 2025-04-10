using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkelMicroMath
{
    public static class Hungry
    {
        public static Cake cake = new Cake();

        public static void Eat()
        {
            for (int i = 0; i < cake.slices; i++)
            {
                Console.WriteLine("eating cake slice");
            }
        }
    }

    public class Cake
    {
        public int slices = 4;
    }
}
