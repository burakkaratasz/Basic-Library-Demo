namespace BasicLibraryProject;
class Program
{
    static void Main(string[] args)
    {
        int toplamfiyat = 0;
        string secim2;

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine();
        Console.WriteLine("**  Turkçe Kitaplar Kategorisi     **  Yabancı Kitaplar Kategorisi         **");
        Console.WriteLine();
        Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri         **  7- Tuna Kılavuzu: Jules Verne       **");
        Console.WriteLine();
        Console.WriteLine("**  2-Yaban: Yakup Kadri           **  8-Bir Kuzey Macerası: Jack London   **");
        Console.WriteLine();
        Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip  **  9-Altıncı Koğuş: Anton Çehov        **");
        Console.WriteLine();
        Console.WriteLine("**  4-Tehlikeli Oyunlar: Oğuz Atay **  10-Kumarbaz: Dostoyevski            **");
        Console.WriteLine();
        Console.WriteLine("**  5-Geçtiğim Günler: H.Yücel     **  11-İki Şehrin Hikayesi: C.Dickens   **");
        Console.WriteLine();
        Console.WriteLine("**  6-Kuyucaklı Yusuf: S.Ali       **  12-Vişne Bahçesi: Anton Çehov       **");
        Console.WriteLine();
        Console.WriteLine("*****************************************************************************");


        Console.WriteLine("***** İşlemler Menüsü *****");
        Console.WriteLine();
        Console.WriteLine("1-Fiyat Sorgulama");
        Console.WriteLine("2-Yeni Okur Kaydı");
        Console.WriteLine("3-Günün Kitabı");
        Console.WriteLine("4-Kitap Arşivi");
        Console.WriteLine("5-Yeni Kitap Satın Al");
        Console.WriteLine("6-Oyun");
        Console.WriteLine();
        Console.Write("Yapmak İstediğiniz İşlemi Giriniz: ");
        string secim;
        secim = Console.ReadLine();

        switch (secim)
        {
            case "1":
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını girin: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1":
                        Console.Write("Çalıkışı: 12 TL");
                        break;

                    case "2":
                        Console.Write("Yaban: 14 TL");
                        break;

                    case "3":
                        Console.Write("Sinekli Bakkal: 16 TL");
                        break;

                    case "4":
                        Console.Write("Tehlikeli Oyunlar: 11 TL");
                        break;

                    case "5":
                        Console.Write("Geçtiğim Günlerden: 8 TL");
                        break;

                    case "6":
                        Console.Write("Kuyucaklı Yusuf: 13 TL");
                        break;

                    case "7":
                        Console.Write("Tuna Kılavuzu: 31 TL");
                        break;

                    case "8":
                        Console.Write("Bir Kuzey Macerası: 54 TL");
                        break;

                    case "9":
                        Console.Write("Altıncı Koğuş: 44 TL");
                        break;

                    case "10":
                        Console.Write("Kumarbaz: 33 TL");
                        break;

                    case "11":
                        Console.Write("İki Şehrin Hikayesi: 69 TL");
                        break;

                    case "12":
                        Console.Write("Vişne Bahçesi: 66 TL");
                        break;
                }
                break;

            case "2":
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                universite = Console.ReadLine();

                string dosya = @"/Users/burak/Documents/course/TurkcellCsharp201/kullanicilar.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz: " + universite);
                sw.Close();
                break;

            case "3":
                
                break;

            case "4":
                Console.WriteLine();
                Console.WriteLine("**************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"/Users/burak/Documents/course/TurkcellCsharp201/kitaplar.txt", FileMode.Open, FileAccess.Read );
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                //kitap arşivi buraya gelecek

                break;

            case "5":
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız Kitabın Numarası: ");
                    secim2 = Console.ReadLine();
                    switch (secim2)
                    {
                        case "1":
                            toplamfiyat = toplamfiyat + 12;
                            break;
                        case "2":
                            toplamfiyat = toplamfiyat + 14;
                            break;
                        case "3":
                            toplamfiyat = toplamfiyat + 16;
                            break;
                        case "4":
                            toplamfiyat = toplamfiyat + 11;
                            break;
                        case "5":
                            toplamfiyat = toplamfiyat + 8;
                            break;
                        case "6":
                            toplamfiyat = toplamfiyat + 13;
                            break;
                        case "7":
                            toplamfiyat = toplamfiyat + 31;
                            break;
                        case "8":
                            toplamfiyat = toplamfiyat + 54;
                            break;
                        case "9":
                            toplamfiyat = toplamfiyat + 44;
                            break;
                        case "10":
                            toplamfiyat = toplamfiyat + 33;
                            break;
                        case "11":
                            toplamfiyat = toplamfiyat + 69;
                            break;
                        case "12":
                            toplamfiyat = toplamfiyat + 66;
                            break;


                    }
                    Console.WriteLine("Toplam Tutar: " + toplamfiyat);
                }
                break;

            case "6":
                Console.WriteLine();
                Console.WriteLine("Oyun"); 
                break;

        }

    }
}

