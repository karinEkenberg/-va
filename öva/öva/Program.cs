
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //övning 3.1
            /*  Console.WriteLine("skriv in ett valfritt tal:");
              string nrEtt = Console.ReadLine();
              int nr1 = Convert.ToInt32(nrEtt);
              Console.WriteLine("skriv ett till valfritt tal:");
              string nrTvå = Console.ReadLine();
              int nr2 = Convert.ToInt32(nrTvå);
              int sum = nr1 + nr2;
              Console.WriteLine("dina tal blir: ");
              Console.Write(nr1 + nr2);
              Console.ReadLine();
            */

            //övning 3.4
            /* Console.WriteLine("Skriv in ett random namn:");
             string läsText = Console.ReadLine();
             Console.WriteLine("Skriv ett till random namn;");
             string läsDenHärTextenMed = Console.ReadLine();
             Console.Write("En gång för länge sedan gick " + läsText + " för att hämta sin bästa vän, " + läsDenHärTextenMed);
             Console.ReadLine();
            */


            // övning 3.2
            /* Console.WriteLine("Skriv ett heltal:");
             string nrEtt = Console.ReadLine();
             int nr1 = Convert.ToInt32(nrEtt);
             Console.WriteLine("Skriv ett till heltal:");
             string nrTvå = Console.ReadLine();
             int nr2 = Convert.ToInt32(nrTvå);
             Console.WriteLine("Skriv in ett tredje heltal:");
             string nrTre = Console.ReadLine();
             int nr3 = Convert.ToInt32(nrTre);
             int sum = nr1 + nr2 + nr3;
             Console.Write("Summan av dina angivna heltal är: ");
             Console.WriteLine(nr1 + nr2 + nr3);
             Console.WriteLine("Medelvärdet för dina angivna heltal är: ");
             Console.Write(sum / 3);
             Console.ReadLine();
             */


            // övning 4.1

            /*  Console.WriteLine("Är det fint väder? Svara j för ja och n för nej");
              string väder = Console.ReadLine();
             if (väder == "j" || väder == "J")
             {
                 Console.WriteLine("Vi går på picknick!");
             }
             else if (väder == "n" || väder == "N")
             {
                 Console.WriteLine("Vi stannar inne och läser en bok!");

             }
             else 
             {
                 Console.WriteLine("Jag förstår inte...");
             }
            */

            //övning 5.1
            /*   int i = 0;
               do
               {
                   Console.WriteLine(i);
                   i++;
               }
               while (i < 21);

               */

            //övning 5.2
            /*  Console.WriteLine("skriv ett tal mellan 1-100:");
              string str = Console.ReadLine();
              int temp = Convert.ToInt32(str);
              while (temp < 100)
              {
                  temp++;
                  Console.WriteLine(temp);
              }
            */

            //övning 5.4

            /*
                        string str;

                        do
                        {
                            Console.WriteLine("Är vi framme snart? ");
                            str = Console.ReadLine();
                        } while (str == "n");
            */


            //bob övning numbers

            /*    int[] numbers = new int[5];
                numbers[0] = 4;
                numbers[1] = 8;
                numbers[2] = 15;
                numbers[3] = 16;
                numbers[4] = 23;

                Console.Write(numbers.Length);
                Console.ReadLine();
                   */

            //  int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            // string[] names = new string[] { "jan", "elvira", "karin", "björn", "selma" };

            /*  for (int i = 0; i < names.Length; i++)
              {
                  Console.WriteLine(names[i]);
              }
              Console.ReadLine(); */

            /*  foreach (string name in names)
              {
                  Console.WriteLine(name);
              }
              Console.ReadLine(); */

            /*string zig = "You can get what you want out of life " + 
                "you can help others bla bla";

            char [] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine(); */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        } 
    }
}
