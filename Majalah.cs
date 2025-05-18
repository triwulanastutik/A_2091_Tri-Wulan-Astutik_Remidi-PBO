using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustkaan_Mini
{
    public class Majalah : Book
    {
        public Majalah(string judul, string penulis, int tahun)
            : base(judul, penulis, tahun) { }

        public override void TampilkanBuku()
        {
            Console.WriteLine($"[Majalah] {Judul} edisi {Tahun}, oleh {Penulis}");
        }
    }

}
