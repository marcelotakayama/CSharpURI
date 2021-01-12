using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1002 {
    class Program {
        static void Main(string[] args) {
            double pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}
