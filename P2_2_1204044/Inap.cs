using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204044
{
    public class Inap: Pasien
    {
        protected string Kamar;

        public Inap(string nama, string jenis, string kamar)
            : base(jenis, nama)
        {
            this.Kamar = kamar;
        }

        public string kamar
        {
            get
            {
                return Kamar;
            }

            set
            {
                Kamar = value;
            }
        }
    }
}
