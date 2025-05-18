using System;
using Perpustkaan_Mini;

class Program
{
    static void Main()
    {
        Library library = new Library();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Sistem Perpustakaan Mini ---");
            Console.WriteLine("1. Tambah Buku");
            Console.WriteLine("2. Ubah Data Buku");
            Console.WriteLine("3. Lihat Semua Buku");
            Console.WriteLine("4. Pinjam Buku");
            Console.WriteLine("5. Kembalikan Buku");
            Console.WriteLine("6. Lihat Buku yang Dipinjam");
            Console.WriteLine("0. Keluar");
            Console.Write("Pilihan: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Jenis (1: Fiksi, 2: Non-Fiksi, 3: Majalah): ");
                    string type = Console.ReadLine();
                    Console.Write("Judul: ");
                    string judul = Console.ReadLine();
                    Console.Write("Penulis: ");
                    string penulis = Console.ReadLine();
                    Console.Write("Tahun: ");
                    int tahun = int.Parse(Console.ReadLine());

                    Book book = type switch
                    {
                        "1" => new Fiksi(judul,penulis,tahun),
                        "2" => new NonFiksi(judul,penulis,tahun),
                        "3" => new Majalah(judul,penulis,tahun),
                        _ => null
                    };

                    if (book != null)
                        library.AddBook(book);
                    else
                        Console.WriteLine("Jenis tidak valid.");
                    break;

                case "2":
                    Console.Write("Judul buku yang ingin diubah: ");
                    string judulLama = Console.ReadLine();
                    Console.Write("Judul baru: ");
                    string newJudul = Console.ReadLine();
                    Console.Write("Penulis baru: ");
                    string newPenulis = Console.ReadLine();
                    Console.Write("Tahun baru: ");
                    int newTahun = int.Parse(Console.ReadLine());

                    library.EditBook(judulLama, newJudul, newPenulis, newTahun);
                    break;

                case "3":
                    library.TampilkanInfoBuku();
                    break;

                case "4":
                    Console.Write("Judul buku yang ingin dipinjam: ");
                    string judulpinjam = Console.ReadLine();
                    library.PeminjamanBuku(judulpinjam);
                    break;

                case "5":
                    Console.Write("Judul buku yang ingin dikembalikan: ");
                    string judulkembali = Console.ReadLine();
                    library.PengembalianBuku(judulkembali);
                    break;

                case "6":
                    library.ListBukuDiPinjam();
                    break;

                case "0":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
