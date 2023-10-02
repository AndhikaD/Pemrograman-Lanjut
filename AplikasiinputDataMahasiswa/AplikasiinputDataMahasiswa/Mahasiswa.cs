using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiinputDataMahasiswa
{
    class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Kelas { get; set; }
        public int Nilai { get; set; }

        public string nilaiHuruf
        {
            get
            {
                if (Nilai > 80)
                {
                    return "A";
                }
                else if (Nilai > 61)
                {
                    return "B";
                }
                else if (Nilai > 41)
                {
                    return "C";
                }
                else if (Nilai > 21)
                {
                    return "D";
                }
                else
                {
                    return "E";
                }
            }
        }

  
    }
}
