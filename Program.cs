using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;

            Calculator calculator = new Calculator();

            hasil = calculator.penjumlahan(10, 2);
            CetakHasil("Hasil Penjumlahan : " + hasil);

            hasil = calculator.penjumlahan(10, 2, 3);
            CetakHasil("Hasil Penjumlahan overload: " + hasil);

            hasil = calculator.pengurangan(7, 2);
            CetakHasil("Hasil pengurangan: " + hasil);

            hasil = calculator.perkalian(5, 2);
            CetakHasil("Hasil perkalian " + hasil);



            Console.ReadKey();
        }
            static void CetakHasil(string hasil)
            {
                Console.WriteLine(hasil);
            }
            

        }
    }

