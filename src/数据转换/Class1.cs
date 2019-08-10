using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据转换
{
    public class Class1
    {

        public  static double MetreToCentimetre(double a)
        {
            return (a *100);
        }
        public  static double CentimetreToMetre(double a)
        {
            return (a /100);
        }

        public static double InchToMetre(double a)
        {
            return (a * 0.0254);
        }
        public  static double FtToMetre(double a)
        {
            return (a * 0.3048);
        }
        public static   double MetreToInch(double a)
        {
            return (a / 0.0254);
        }
        public  static   double MetreToFt(double a)
        {
            return (a / 0.3048);
        }

        public static double In(double a, string b)
        {
            if (b == "m") { a = Class1.MetreToCentimetre(a); }
            if (b == "英寸") { a = Class1.InchToMetre(a);
                a = Class1.MetreToCentimetre(a);
            }
            if (b == "英尺") { a = Class1.FtToMetre(a);
                a = Class1.MetreToCentimetre(a);  }
            return a;
        }
      


    }
}
