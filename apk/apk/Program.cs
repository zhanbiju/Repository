using System;

namespace apk
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {
                int z;
                for (int x = 0; x < 20; x++)
                {
                    for (int y = 0; y < 33; y++)
                    {
                        z = 100 - x - y;
                        if (5 * x + 3 * y + z / 3 == 100 && x+y+z==100)
                        {
                            Console.WriteLine("{0} {1} {2}", x, y, z);
                            Console.ReadLine();
                        }
                    }
                        
                }
            }
        }
    }
}
