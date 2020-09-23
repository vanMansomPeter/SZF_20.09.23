using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZF_20._09._23
{
    class Program
    {
        static void Main()
        {
            // bool x = true;
            //bool y = false;
            //== egyenlő -> akkor igaz ha egyformák az op.
            //!= nem egyenlő -> kizáró vagy
            //|| vagy -> akkor igaz ha az egyik igaz legalább
            //&& és -> ha mindkettő igaz akkor igaz
            // int[] t = new int[10];
            // if((t.Length==10)==(DateTime.Now.DayOfWeek==DayOfWeek.Wednesday))
            // {
            //     Console.WriteLine("belefér by Pisti");
            //        }
            // else
            // {
            //    Console.WriteLine("Faszság");
            // }
            //Console.ReadKey();

            int x = 10;
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("ez egy");
                        Console.WriteLine("és még további kód");
                    }
                    break;
                    case 2:
                    
                        Console.WriteLine("Ez kettő, egy sorban is lehet, akkor nem kell a {''}");
                    break;
                case 5:
                    Console.WriteLine("ez 5, nem kell, hogy sorba legyen");
                    break;
                case 3:
                    Console.WriteLine("három"); break;
                case 10: Console.WriteLine("tíz"); break;
                default:
                    Console.WriteLine("ez akkor fut le, ha egyik case sem tud teljesülni");
                    break;
            
            }
            Console.ReadKey();
            
        }
    }
}
