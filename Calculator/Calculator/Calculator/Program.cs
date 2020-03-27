using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //static void sum(String Teskstsum)

            //{
            //    Console.Write(Teskstsum);
            //}

            static double IndtastDouble(String TekstTal)

            {

                bool ok;

                double resultat;

                do

                {

                    Console.Write(TekstTal);

                    String convert = Console.ReadLine();

                    ok = double.TryParse(convert, out resultat);

                } while (!ok);

                return resultat;

            }

            //static String IndtastTal(String Tekst)

            //{
            //    Console.Write(Tekst);
            //    String tal = Console.ReadLine();
            //    return tal;
            //}

            static void Main(string[] args)

            {

                String metode;

                do

                {

                    Console.Write(" Type which method you want to use (+ - * / ) (Type x for Exit): ");

                    metode = Console.ReadLine();

                    if (metode != "x")

                    {

                        double tal1 = 0;

                        //String tal1 = "";
                        //Console.Write(" Type number 1: ");
                        //tal1 = Console.ReadLine();

                        double tal2 = 0;

                        //String tal2 = "";
                        //Console.Write(" Type number 2: ");
                        //tal2 = Console.ReadLine();

                        tal1 = IndtastDouble(" IndtastTal 1: ");

                        tal2 = IndtastDouble(" IndtastTal 2: ");

                        //IndtastTal

                        if (metode == "+") //switch (metode)

                        //}

                        //case "+":

                        {

                            double sum = tal1 + tal2; /*Convert.ToDouble(tal1)*/ /*Convert.ToDouble(tal2)*/

                            Console.Write(" The sum is: " + sum);

                            //break:

                        }

                        else if (metode == "-") //case "-":

                        {

                            double diff = tal1 - tal2; /*Convert.ToDouble(tal1)*/ /*Convert.ToDouble(tal2)*/

                            Console.Write(" The sum is: " + diff);

                            //break:

                        }

                        else if (metode == "*") //case "*":

                        {

                            double times = tal1 * tal2; /*Convert.ToDouble(tal1)*/ /*Convert.ToDouble(tal2)*/

                            Console.Write(" The sum is: " + times);

                            //break:

                        }

                        else if (metode == "/") //case "/":

                        {

                            double divide = tal1 / tal2; /*Convert.ToDouble(tal1)*/ /*Convert.ToDouble(tal2)*/

                            Console.Write(" The sum is: " + divide);

                            //break:

                        }

                    }

                } while (metode != "x");

            }

        }

    }
}
