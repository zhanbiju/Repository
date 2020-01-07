using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artificialintelligence;

namespace Artificialintelligence
{
    class Program
    {
        static void Main(string[] args)
        {

            var keyString = "人工智能";
            TestStreamReaderEnumerable(keyString);
            Console.Read();
        }
        public static void TestStreamReaderEnumerable(string keyString)
        {

            IEnumerable<String> stringsFound;

            try
            {



                stringsFound =
                      from line in new StreamReaderEnumerable(@"/Artificialintelligence/Artificialintelligence/Text/TempFile.txt")
                      where line.Contains(keyString)
                      select line;
                int sun = 0;
                foreach (var i in stringsFound)
                {

                    sun++;


                    if (i.Contains(keyString))
                    {


                        int lent = i.IndexOf("人工智能");
                        int le = i.IndexOf("。");
                        int lent1 = lent + 13;
                        if (le > lent)
                        {
                            if (le - lent >= 13)
                            {
                                ;
                                string tex = i.Substring(lent, lent1);
                                Console.WriteLine("第:{0}行,第:{1}个字母", sun, lent);
                                Console.WriteLine(tex + "....");
                                Console.WriteLine("");
                            }
                            else
                            {
                                string tex = i.Substring(lent, le);
                                Console.WriteLine(tex + "。");
                            }
                        }

                    }
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(@"这个例子需要一个名为 C:\temp\tempFile.txt 的文件。");
                return;
            }


            Console.WriteLine();
        }
    }
}
