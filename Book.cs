using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Perpustkaan_Mini;

namespace Perpustkaan_Mini
{ 
    public abstract class Book:BookInterface
    {
        private string judul;
        private string penulis;
        private int tahun;
        
        public string Judul { 
            get => judul;
            set => judul = value;
        }
        public string Penulis
        {
            get => penulis;
            set => penulis = value;
        }
        
        public int Tahun
        {
            get => tahun;
            set => tahun = value;
        }

        public bool StatusPinjam { get; set; } = false;

        public Book(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;

        }

        public abstract void TampilkanBuku(); 
  
    }
}


