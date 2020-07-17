using System;
using System.Collections.Generic;
using System.Text;

namespace UASPemrograman.Mahasiswa1
{
    public abstract class Mahasiswa
    {
        public string NIM { get; set; }
        public string Nama { get; set; }
        public string Kelas { get; set; }
        public string Prodi { get; set; }

        public virtual string Status()
        {
        	return "Status";
        }
    }
}

