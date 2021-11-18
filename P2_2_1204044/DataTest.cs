using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204044
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Data Pasien Klinik Sehat Selalu\n" +
                 "1. Rawat Jalan\n" +
                 "2. Rawat Inap\n");

            Console.Write("Pasien Rawat: ");


            int Pilih = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            if (Pilih == 1)
            {
                Jalan pasien1 = new Jalan("Fahira", "75000");

                Console.WriteLine("Pasien bernama {0} dirawat {1} dengan tagihan pengobatan sebesar RP.{2}", pasien1.NamaPasien, pasien1.JenisPasien, pasien1.Biaya);
            }

            else if (Pilih == 2)
            {
                Inap pasien2 = new Inap("Aqilah","Inap", "Cempaka");
          
                Console.WriteLine("Pasien bernama {0} dirawat {1} dan ditempatkan dikamar {2} ", pasien2.NamaPasien, pasien2.JenisPasien, pasien2.kamar);
            }
        }
    }
}
