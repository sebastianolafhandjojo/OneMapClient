using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneMapClient;
using System.Diagnostics;

namespace OneMapClientConsole
{
    class Program
    {
        CoordinateConverter  omc;
        static void Main(string[] args)
        {

            Test1();
            Test2();
            Test3();
            Test4();
            Test5();

            Test6();
            Test7();
            Test8();
            Test9();
            Console.ReadKey();
        }

        static void Test1()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr4326To3414Async(103.8421581, 1.319728905).Result;
            Debug.WriteLine(result.ToString());            
        }

        static void Test2()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr4326To3414Async(103.833333, 1.366666).Result;
            Debug.WriteLine(result.ToString());
        }

        static void Test3()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr4326To3414Async(103.856950349764668, 1.3699278977737488).Result;
            Debug.WriteLine(result.ToString());
        }

        static void Test4()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr4326To3414Async(103.72794378041792, 1.3446255443241177).Result;
            Debug.WriteLine(result.ToString());
        }

        static void Test5()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr4326To3414Async(103.83080332777138, 1.4520670518379692).Result;
            Debug.WriteLine(result.ToString());
        }

//------------------------------------------------------------------------------------------------------
        static void Test6()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr3414To4326Async(28001.642, 38744.572).Result;
            Debug.WriteLine(result.ToString());
        }

        static void Test7()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr3414To4326Async(30629.967, 39105.269).Result;
            Debug.WriteLine(result.ToString());
        }

        static void Test8()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr3414To4326Async(16272.970, 36307.704).Result;
            Debug.WriteLine(result.ToString());
        }

        static void Test9()
        {
            CoordinateConverter cc = new CoordinateConverter();
            var result = cc.Fr3414To4326Async(27720.130, 48187.789).Result;
            Debug.WriteLine(result.ToString());
        }
    }
}


