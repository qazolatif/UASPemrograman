using System;
using System.Collections.Generic;
using System.Text;

namespace UASPemrograman.Mahasiswa1
{
    public class StatusAktif : Mahasiswa
    {
        public override string Status()
        {
            return "Aktif";
        }
    }
}