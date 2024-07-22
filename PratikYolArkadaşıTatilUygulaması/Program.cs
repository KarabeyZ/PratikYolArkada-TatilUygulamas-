while (true)
{
    int bodrumFiyat = 4000;
    int cesmeFiyat = 5000;
    int marmarisFiyat = 3000;
    int karaYolu = 1500;
    int havaYolu = 4000;
    
    string locationSelected;
    Console.WriteLine("Nereye Seyahat etmek istiyorsunuz? (Çeşme-Marmaris-Bodrum)");
    string location = Console.ReadLine().ToLower();
    int paketFiyat;
    if (location == "bodrum" || location == "çeşme" || location == "marmaris")
    {

        while (true)
        {
            
            

        if (location == "bodrum")
        {
            paketFiyat = bodrumFiyat;
            locationSelected = "Bodrum'u seçtiniz (Paket başlangıç fiyatı 4000 TL). Bodrum'un güzel plajlarında güneşlenip denizin keyfini çıkarabilirsiniz.";
            

        }
        else if (location == "çeşme")
        {
            paketFiyat = cesmeFiyat;
            locationSelected = "Çeşme'yi seçtiniz (Paket başlangıç fiyatı 5000 TL). Çeşme'nin güzel plajlarında güneşlenip denizin keyfini çıkarabilirsiniz.";

        }
        else
        {
            paketFiyat = marmarisFiyat;
            locationSelected = "Marmaris'i seçtiniz (Paket başlangıç fiyatı 3000 TL). Marmaris'in güzel plajlarında güneşlenip denizin keyfini çıkarabilirsiniz.";
        }
        Console.WriteLine(locationSelected);
            Console.WriteLine("Kaç kişi gitmek istersiniz?");
            int kisiSayisi = Convert.ToInt32(Console.ReadLine());

            if (kisiSayisi > 0)
            {
                Console.WriteLine("Ulaşım yönteminizi seçiniz: \n1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL) ");
                int ulasim = Convert.ToInt32(Console.ReadLine());
                if (ulasim == 1 || ulasim == 2)
                {
                    if (ulasim == 1)
                    {

                        Console.WriteLine($"Gitmek istediğiniz lokasyon {location}, kişi sayısı {kisiSayisi}, ulaşım türü {karaYolu},toplam fiyat {(kisiSayisi * karaYolu) + (kisiSayisi * paketFiyat)}");
                    }
                    else
                    {

                        Console.WriteLine($"Gitmek istediğiniz lokasyon {location}, kişi sayısı {kisiSayisi}, ulaşım türü {havaYolu},toplam fiyat {(kisiSayisi * havaYolu) + (kisiSayisi * paketFiyat)}");
                    }
                }
                else { Console.WriteLine("hatali giris yaptiniz lütfen 1 veya 2 yazınız."); }
                break;
            }
            else { Console.WriteLine("Yanlis giris yaptiniz"); }

        }


        
        // Yeni tatil planı sorusu
        Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet/Hayır)");
        string devamMi = Console.ReadLine().ToLower();

        if (devamMi != "evet")
        {
            Console.WriteLine("İyi günler!");
            break; // Dıştaki döngüyü kır, programı sonlandır
        }

    }
    else
    {
        Console.WriteLine("Yanlış bir lokasyon girdiniz lütfen tekrar deneyin.");
    }
    

}
