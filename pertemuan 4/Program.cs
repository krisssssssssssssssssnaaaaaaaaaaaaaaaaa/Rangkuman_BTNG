using System;
using System.Security.AccessControl;

namespace pertemuan4{
    class Program{
        static void Main(string[] args){
            Car Kijang = new Car();
            Kijang.detailMobil();
            Kijang.setMobil("Kijang",100);
            Kijang.detailMobil();

            Makanan martabak = new Makanan();
            Console.WriteLine(martabak.namaMakanan);
            Console.WriteLine(martabak.rasa);

            Makanan kolak = new Makanan();
            kolak.MakananBaru("Manis",15000,"Kolak");

            // tipe data 

            // int , float, double <- angka | cth : int angka1 = 5 | flaot angka2 = 0.5f | double angka3 = 3.14
            //  string, char <- kalimat/kata \t = baris \r = kolom | cth : string buah = "apel", "\rsemangka", "\rjeruk"

            // manipulasi string

            // string kalimat1 = Halo saya;
            // string kalimat2 = Mr Jack;
            // Console.WriteLine("Perkenalan : " + kalimat1.ToLower() + kalimat2.ToUpper()); | + = menggabungkan kata, ToLower() = membuat kata menjadi huruf kecil, ToUpper() = membuat kata menjadi huruf besar 


            // Interpolasi string

            // string namainter = "Joko";
            // var date  = DateTime.Now;
            // Console.WriteLine($"Halo, {namainter}! hari ini adalah {date.DayOfWeek}, pukul {date:HH:MM} WIB. ");

            // Boolean

            // Boolean benar = true;
            // Boolean salah = false;
            
            // if(benar == true){
            //     Console.WriteLine("Ini adalah pernyataan benar");
            // }
            // else{
            //     Console.WriteLine("Ini adalah pernyataan salah");
            // }

            // Konversi Tipe Data

            //  Kecil ke besar / implisit (otomatis) | char -> int -> long -> float -> double
            //  Besar ke kecil / eksplisit (manual) | double -> float -> long -> int -> char

            //  float first = 3.14f;
            //  int second = (int)first;
            //  Console.WriteLine(second);

            //  int angkaSatu = 10;
            //  float angkaDua = 20.7f;
            //  Console.WriteLine($"{angkaSatu.ToString()}{angkaDua.ToString()}"); | Mengubah bilangan menjadi string menggunakan ToString()

            //  string pertama = 5;
            //  string kedua = 10;
            //  int sum = int.Parse(pertama) + int.Parse(kedua); | mengubah string menjadi int
            //  Console.WriteLine(sum);

            //  Operator Aritmatika
            //  var a1 = 2 + 5;
            //  var a2 = 2 - 5;
            //  var a3 = 2 * 5;
            //  var a4 = 2 / 5;
            //  var a5 = 2 % 5;

            // Console.WriteLine(a1);
            // Console.WriteLine(a2);
            // Console.WriteLine(a3);
            // Console.WriteLine(a4);
            // Console.WriteLine(a5);

            //  Operator Penugasan
            //  a += 10
            //  a -= 10
            //  a *= 10
            //  a /= 10
            //  a %= 10

            //  Increment Decrement
            //  ++a | nilai setelah operasi
            //  int a = 2;
            //  Console.WriteLine(a); // 2
            //  Console.WriteLine(++a); // 3
            //  Console.Writeline(a); // 3

            //  a++ | nilai sebelum operasi
            //  Console.WriteLine(a++); // 2
            //  Console.WriteLine(a); // 3

            //  --a | nilai setelah operasi
            //  a-- | niali sebelum operasi

            // Operator Perbandingan
            //  ==
            // >=
            // <=
            // >
            // <

            // Operator Logika | Nilai sesuai tabel kebenaran
            //  &&
            //  ||
            //  !

            //  Array | menyimpan tipedata yang sama dimulai dari indeks ke 0
            
            //  string[] divisi = {"web", "mobile", "game", "mulmed", "jaringan"};
            //  Console.WriteLine(divisi[0]);
            //  Console.WriteLine(divisi[1]);
            //  Console.WriteLine(divisi[2]);
            //  Console.WriteLine(divisi[3]);
            //  Console.WriteLine(divisi[4]);

            //  string[] div = new string[5];
            //  div[0] = "web";
            //  div[0] = "mobile";
            //  div[0] = "game";
            //  div[0] = "mulmed";
            //  div[0] = "jaringan";

            //  Console.WriteLine(div);

            //  Array 2d
            
            //  int[,] arr2d = {{1,2,3},{4,5,6}};
            //  Console.WriteLine(arr2d[0,1]); // output 2
            //  Console.WriteLine(arr2d[1,2]); // output 6

            //  Array 3d

            //  int[,,] arr3d = {{{1,2,3},{4,5,6}},{{7,8,9},{10,11,12}}};
            //  Console.WriteLine(arr3d[0,0,0]); // output 1
            //  Console.WriteLine(arr3d[1,1,0]); // output 10

            //  List | method : add(),AddRange(),Remove(),RemoveAt(),IndexOf(),Containts(),Count()

            //  var names = new List<string> {"Game","Mobile","Web"};
            //  for (int i = 0; i<names.Count; i++){
            //     Console.Write(names[i]+" ");
            // }

            //  Condition

            // int i = 5;
            // if(1>i)
            // {
            //     Console.WriteLine("Benar!");
            // }
            // else{
            //     Console.WriteLine("salah");
            // }

            // int nilai = 75;
            // if(nilai >= 90){
            //     Console.WriteLine("Nilai anda adalah A");
            // }
            // else if(nilai >= 80){
            //     Console.WriteLine("Nilai anda adalah B");
            // }
            // else if(nilai >= 70){
            //     Console.WriteLine("Nilai anda adalah C");
            // }
            // else{
            //     Console.WriteLine("Nilai anda adalah D");
            // }

            // int nilai = 50;
            // switch(nilai){
            // case > 90:
            //     Console.WriteLine("A");
            //     break;
            // case > 80:
            //     Console.WriteLine("B");
            //     break;
            // default :
            //     Console.WriteLine("D");
            //     break;           
            // }

            //  Ternary Operator

            //  int angka = 10;
            //  string hasil = (angka % 2 == 0) ? "Genap" : "Ganjil";
            //  Console.WriteLine(hasil);

            //  Looping | for, while, do while, foreach

            // for(int i = 0 ; i <5 ; i++){
            //     Console.WriteLine("Kode berjalan ke " + i);        
            // }

            // int i = 0;
            // while(i<5){
            //     Console.WriteLine("Perulangan ke "+ i);
            //     i++;
            // }

            //  int i = 0;
            // do{
            //     Console.WriteLine("Perulangan ke "+ i);
            //     i++;
            // } while(i<5);

            //  int i = 0;
            //  int[] angka = new int[5]{1,2,3,4,5};
            //  foreach(int a in angka);
            //  {
            //     Console.WriteLine("Ini adalah isi array urut dari indeks ke " + i++ + " yaitu " + a);
            // }







           


        }
    }

     class Car{
       private string namaMobil = "volkswagen";
       private int speed = 150;

       public void setMobil(string namaMobilBaru, int speedBaru){
        this.namaMobil = namaMobilBaru;
        this.speed =  speedBaru;
       }
       public void detailMobil(){
            Console.WriteLine("Nama Mobil : " + namaMobil);
            Console.WriteLine("Kecepatan Mobil : " + speed);
        }
        private void privateMethod(){
            privateMethod();
        }

        public void publicMethod(){
            privateMethod();
        }
    }
    class Makanan{
        public string rasa = "manis";
        public int harga = 4000;
        public string namaMakanan = "martabak";

        private void setMakanan(string rasaBaru, int hargaBaru, string namaMakananBaru){
            this.rasa = rasaBaru;
            this.harga = hargaBaru;
            this.namaMakanan = namaMakananBaru;
        }

        public void MakananBaru(string rasaBaru, int hargaBaru, string namaMakananBaru){
            setMakanan(rasaBaru, hargaBaru, namaMakananBaru);
            Console.WriteLine("Nama : " + namaMakananBaru);
            Console.WriteLine("Harga : " + hargaBaru);
            Console.WriteLine("Rasa : " + rasaBaru);
        }
        
    }
}