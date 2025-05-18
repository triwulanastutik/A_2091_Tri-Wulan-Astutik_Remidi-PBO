using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustkaan_Mini
{
    public class Library
    {
        private List<Book> buku = new List<Book>();
        private List<Book> peminjamanbuku = new List<Book>();

        public void AddBook(Book book)
        {
            buku.Add(book);
            Console.WriteLine("Buku berhasil ditambahkan.");
        }

        public void EditBook(string judul, string newJudul, string newPenulis, int newTahun)
        {
            Book book = buku.FirstOrDefault(b => b.Judul == judul);
            if (book != null)
            {
                book.Judul = newJudul;
                book.Penulis = newPenulis;
                book.Tahun = newTahun;
                Console.WriteLine("Data buku diperbarui.");
            }
            else
            {
                Console.WriteLine("Buku tidak ditemukan.");
            }
        }

        public void TampilkanInfoBuku()
        {
            if (buku.Count == 0)
            {
                Console.WriteLine("Belum ada buku.");
                return;
            }

            foreach (var book in buku)
            {
                book.TampilkanBuku();
            }
        }

        public void PeminjamanBuku(string judul)
        {
            if (peminjamanbuku.Count >= 3)
            {
                Console.WriteLine("Maksimal peminjaman 3 buku.");
                return;
            }

            Book book = buku.FirstOrDefault(b => b.Judul == judul && !b.StatusPinjam);
            if (book != null)
            {
                book.StatusPinjam = true;
                peminjamanbuku.Add(book);
                Console.WriteLine("Buku berhasil dipinjam.");
            }
            else
            {
                Console.WriteLine("Buku tidak tersedia.");
            }
        }

        public void PengembalianBuku(string judul)
        {
            Book book = peminjamanbuku.FirstOrDefault(b => b.Judul == judul);
            if (book != null)
            {
                book.StatusPinjam = false;
                peminjamanbuku.Remove(book);
                Console.WriteLine("Buku berhasil dikembalikan.");
            }
            else
            {
                Console.WriteLine("Buku tidak ditemukan dalam daftar pinjaman.");
            }
        }

        public void ListBukuDiPinjam()
        {
            if (peminjamanbuku.Count == 0)
            {
                Console.WriteLine("Tidak ada buku yang sedang dipinjam.");
                return;
            }

            foreach (var book in peminjamanbuku)
            {
                book.TampilkanBuku();
            }
        }
    }

}
