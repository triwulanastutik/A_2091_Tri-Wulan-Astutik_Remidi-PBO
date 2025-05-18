using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustkaan_Mini
{
    public class NonFiksi : Book
    {
        public NonFiksi(string judul, string penulis, int tahun)
            : base(judul, penulis, tahun) { }

        public override void TampilkanBuku()
        {
            Console.WriteLine($"[Non-Fiksi] {Judul} oleh {Penulis}, {Tahun}");
        }
    }
}
