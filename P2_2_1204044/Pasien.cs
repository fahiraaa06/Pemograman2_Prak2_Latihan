using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204044
{
     public class Pasien
    {
        private string jenisPasien;
        private string namaPasien;

        public Pasien()
        {

        }

        public Pasien(string jenis, string nama)
        {
            this.jenisPasien = jenis;
            this.namaPasien = nama;
        }

        public string JenisPasien
        {
            get
            {
                return jenisPasien;
            }
            set
            {
                jenisPasien = value;
            }
        }

        public string NamaPasien
        {
            get
            {
                return namaPasien;
            }
            set
            {
                namaPasien = value;
            }
        }
    }
}
