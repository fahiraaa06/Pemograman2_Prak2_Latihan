using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204044
{
    public class Jalan: Pasien
    {
        protected string biaya;

        public Jalan(string nama, string biaya)
        {
            this.NamaPasien = nama;
            this.Biaya = biaya;
            this.JenisPasien = "Jalan";
        }

        public string Biaya
        {
            get
            {
                return biaya;
            }

            set
            {
                biaya = value;
            }
        }
    }
}
