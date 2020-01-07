using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatethenumberofchickens
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j <= 20; j++)
            {
                for (int i = 0; i <= 33; i++)
                {
                    int z = 100 - j - i;
                    if ((j * 5 + i * 3 + z / 3 == 100) && z % 3 == 0)
                    {
                        Console.WriteLine("公鸡:{0},母鸡:{1},小鸡:{2}", j, i, z);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
