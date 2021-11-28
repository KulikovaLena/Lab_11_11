using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation root = new Equation { };
            root.Root();
            Console.ReadKey();
        }
    }
    struct Equation
    {
        public void Root()
        {
            try
            {
                Console.WriteLine("Reshenie lineinogo uravneniy 0=kx+b");
                Console.WriteLine("Vvedite znachenie b");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Vvedite znachenie k");
                double k = Convert.ToDouble(Console.ReadLine());
                if (k == 0)
                {
                    Console.WriteLine("VVedeno necorrectnoe znachenie");
                }
                else
                {
                    Console.WriteLine("x={0:0.00}", -b / k);
                }
            }
            catch
            {
                Console.WriteLine("VVedeno necorrectnoe znachenie");
            }

        }
    }
}
