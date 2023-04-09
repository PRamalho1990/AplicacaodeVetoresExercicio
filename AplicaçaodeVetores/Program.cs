using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaçaodeVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa para calcular a média de tres alturas: 1.72  1.56  e 1.80
            //Quantidade de informaçoes as serem inseridas: 3
            

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double sum = 0.00;

            for ( int i= 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT:" + avg.ToString("f2"), CultureInfo.InvariantCulture);

            Console.ReadKey();


            
        }
    }
}
