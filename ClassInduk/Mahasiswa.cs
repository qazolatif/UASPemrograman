using System;
using System.Collections.Generic;
using System.Text;

namespace UASPemrograman.Mahasiswa1
{
    public abstract class Mahasiswa
    {
        private string nim;
        private string nama;
        private string kelas;
        private string prodi;

        public string NIM
        {
            get
            {
                return nim;
            }
            set
            {
                nim = value;
            }
        }

        public string Nama
        {
            get
            {
                return nama;
            }
            set
            {
                nama = value;
            }
        }

        public string Kelas
        {
            get
            {
                return kelas;
            }
            set
            {
                kelas = value;
            }
        }

        public string Prodi
        {
            get
            {
                return prodi;
            }
            set
            {
                prodi = value;
            }
        }

        public virtual string Status()
        {
        	return "Status";
        }
    }
}
