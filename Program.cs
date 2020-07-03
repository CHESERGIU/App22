using System;

namespace App22
{
    class Program
    {
        static void Main(string[] args)
        {
            //int size = 20;
            //string sizeRange = size > 25 ? "large" : "small";
            ////Console.WriteLine(sizeRange);

            //int temperature = 35;
            //string weather = "fine";

            //if (temperature <= 10)
            //    weather = "cold";

            //if (temperature < -10)
            //    weather = "very cold";

            //if (temperature > 25)
            //    weather = "hot";

            //if (temperature > 32)
            //    weather = "very hot";
            ////Console.WriteLine(weather);

            //int code = 4;
            //string color = "";

            //switch (code)
            //{
            //    case 1:
            //        color = "green";
            //        break;
            //    case 2:
            //        color = "yellow";
            //        break;
            //    case 3:
            //        color = "orange";
            //        break;
            //    case 4:
            //        color = "red";
            //        break;
            //    default:
            //        color = "black";
            //        break;
            //}
            ////Console.WriteLine(color);

            //string today = "Thursday";
            //string weekPeriod = today == "Saturday" || today == "Sunday" ? "weekend" : "workday";
            ////Console.WriteLine(weekPeriod);

            //int number = 11;
            //string code = "N";

            //if (number % 2 == 0)
            //    code += "p";

            //if (number > 0)
            //    code += "+";
            //else if (number < 0)
            //    code += "-";
            //Console.WriteLine(code);
            double n = double.Parse(Console.ReadLine());
            int total = 0;
            while (n > 0)
            {
                total += 10;
                n -= 1;
            }
            Console.WriteLine(total);

        }
    }
}
