using System;

namespace kalkulator
{
    class kalkulator
    {
        static void Main(string[] args)

        {
            Console.Title = "aplikasi kalkulator";
            Console.WriteLine("pilih menu kalkulator: ");
            Console.WriteLine("\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");
            Console.WriteLine("Masukan pilihan: ");
            int Pilihan = Convert.ToInt32(Console.ReadLine());

            if (Pilihan == 1)
            {
                Console.WriteLine("Masukan angka pertama: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukan angka kedua: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil penambahan anda: " + (a + b));
            }
            else if (Pilihan == 2)
            {
                Console.WriteLine("Masukan angka pertama: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukan angka kedua: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil pengurangan anda: " + (a - b));
            }
            else if (Pilihan == 3)
            {
                Console.WriteLine("Masukan angka pertama: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukan angka kedua: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil perkalian anda: " + (a * b));
            }
            else if (Pilihan == 4)
            {
                Console.WriteLine("Masukan angka pertama: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Masukan angka kedua: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil pembagian anda: " + (a / b));
            }
            else
            {
                Console.WriteLine("Maaf, menu tidak tersedia");
            }
            Console.WriteLine("Tekan enter untuk keluar");

            Console.ReadKey();



        }
    }
}