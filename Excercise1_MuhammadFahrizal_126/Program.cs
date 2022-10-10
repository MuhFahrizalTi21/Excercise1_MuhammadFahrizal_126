using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1_MuhammadFahrizal_126
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] farizal = new int[20];

        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan padqa array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            //Pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                farizal[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            // Menampilkan array yang tersusun 
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-------------------------------------");
            for (int MF = 0; MF < n; MF++)
            {
                Console.WriteLine(farizal[MF]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortArray1()
        {
            for (int i = 1; i < n; i++) // for n-1 passes
            {
                // pada pass i, bandingkan n-1 elemen pertama dengan elemen selanjutnya 
                for (int MF = 0; MF < n - 1; MF++)
                {
                    if (farizal[MF] > farizal[MF + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        //tuar elemen 
                        int temp;
                        temp = farizal[MF];
                        farizal[MF] = farizal[MF + 1];
                        farizal[MF + 1] = temp;
                    }
                }
            }
        }

        public void BubbleSortArray2()
        {
            for (int i = 1; i < n; i++) // for n-2 passes
            {
                // pada pass i, bandingkan n-2 elemen pertama dengan elemen selanjutnya 
                for (int MF = 0; MF < n - 2; MF++)
                {
                    if (farizal[MF] > farizal[MF + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        //tuar elemen 
                        int temp;
                        temp = farizal[MF];
                        farizal[MF] = farizal[MF + 1];
                        farizal[MF + 1] = temp;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();

            // Pemanggilan fungsi untuk mengurutkan array 
            myList.BubbleSortArray1();

            // Pemanggilan fungsi untuk mengurutkan array 
            myList.BubbleSortArray1();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();

            //exit
            Console.WriteLine("\nTekan Tombol Apa Saja Untuk Keluar");
            Console.Read();
        }

    }
}
