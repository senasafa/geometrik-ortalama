
    
        
   using System;

// Bu program girilen iki sayının geometrik ortalamasını hesaplar
class Program
{
    static void Main()
    {
        int sayi1, sayi2;
        Console.WriteLine("sayi1 giriniz:");
        sayi1 = int.Parse(Console.ReadLine());

        Console.WriteLine("sayi2 giriniz:");
        sayi2 = int.Parse(Console.ReadLine());

        double sonuc = Math.Sqrt(sayi1 * sayi2);
        Console.WriteLine("Geometrik ortalama: " + sonuc);
    }
}

  
   