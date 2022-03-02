/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2020-2021 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:1
** ÖĞRENCİ ADI............:Ayşe Tuba Kahraman   
** ÖĞRENCİ NUMARASI.......:b191200025
** DERSİN ALINDIĞI GRUP...:1.Öğretim A
****************************************************************************/

using System;

namespace Ödev1
{
    class b191200025
    {
        static void Main(string[] args)
        {
            while (true)//İşlemleri kullanıcı çıkış yapana kadar gösterir
            {
                Console.WriteLine("...İŞLEMLER... ");
                Console.WriteLine(" Aşağıdan bir işlem seçiniz");
                Console.WriteLine(" 1.Matris İşlemleri");
                Console.WriteLine(" 2.String İşlemleri");
                Console.WriteLine(" 3.Çıkış");
                Console.Write("Seçiminiz:");

                string sayi;
                sayi = Console.ReadLine();
                if (sayi == "1")//Matris
                {
                    Console.Clear();
                    KareMatris();
                }
                else if (sayi == "2")//String
                {
                    Console.Clear();
                    Stringişlem();
                }
                else if (sayi == "3")//Çıkış
                {
                    Console.WriteLine("Çıkış yaptınız");
                    Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                    Console.ReadLine();
                    System.Environment.Exit(-1);
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız");
                    Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        private static void KareMatris()
        {
            Console.WriteLine("...MATRİS İŞLEMLERİ...");
            Console.Write("Matrisin satır sayısını girebilir misiniz?(1 ila 10 arasında):");
            string diziboyutustr;
            diziboyutustr = Console.ReadLine();
            int diziboyutu = Convert.ToInt32(diziboyutustr);
            int[,] dizi = new int[diziboyutu, diziboyutu];
            //İki boyutlu dizideki elemanları kullanıcının girmesini ister
            for (int i = 0; i < diziboyutu; i++)//Matriste satırları gezmemizi sağlar
            {
                for (int j = 0; j < diziboyutu; j++)//Matriste sütunları gezmemizi sağlar
                {
                    int dizii = i + 1;
                    int dizij = j + 1;
                    Console.Write("[" + dizii + "," + dizij + "]=");//[0,0]=
                    string sayi = Console.ReadLine();
                    dizi[i, j] = Convert.ToInt32(sayi);
                }
            }
            //Dizideki sayıları matris şeklinde yazdırır
            for (int i = 0; i < diziboyutu; i++)//Matriste satırları gezmemizi sağlar
            {
                for (int j = 0; j < diziboyutu; j++)//Matriste sütunları gezmemizi sağlar
                {
                    Console.Write(dizi[i, j] + " ");//[0,0]=
                }
                Console.WriteLine();
            }

            Console.WriteLine("1.Satırdaki en büyük sayı");
            Console.WriteLine("2.Satırdaki sayıların toplamı");
            Console.Write("Seçiminiz:");
            string sayıgir;
            sayıgir = Console.ReadLine();
            if (sayıgir == "1")
            {
                Console.WriteLine("Sonuç:");
                int enbuyuksayı = 0;
                int[] enbuyuksayıdizisi = new int[diziboyutu];
                //Matriste satırdaki en büyük sayıyı bulur bunudiğer satırlar içinde yapar
                for (int i = 0; i < diziboyutu; i++)//Matriste satırları gezmemizi sağlar
                {
                    enbuyuksayı = 0;
                    for (int j = 0; j < diziboyutu; j++)//Matriste sütunları gezmemizi sağlar
                    {
                        if (dizi[i, j] > enbuyuksayı)
                            enbuyuksayı = dizi[i, j];
                    }
                    enbuyuksayıdizisi[i] = enbuyuksayı;
                }
                for (int i = 0; i < diziboyutu; i++)
                {
                    Console.Write(enbuyuksayıdizisi[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                Console.ReadLine();
                Console.Clear();
            }
            else if (sayıgir == "2")
            {
                Console.WriteLine("Sonuç:");
                int satırtoplam;
                int[] satırtoplamdizisi = new int[diziboyutu];
                //Matrisdeki satırları ayrı ayrı toplar ve toplamları ekrana yazar
                for (int i = 0; i < diziboyutu; i++)//Matriste satırları gezmemizi sağlar
                {
                    satırtoplam = 0;
                    for (int j = 0; j < diziboyutu; j++)//Matriste sütunları gezmemizi sağlar
                    {
                        satırtoplam += dizi[i, j];
                    }
                    satırtoplamdizisi[i] = satırtoplam;
                }
                for (int i = 0; i < diziboyutu; i++)
                {
                    Console.Write(satırtoplamdizisi[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız");
                Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                Console.ReadLine();
                Console.Clear();
                return;
            }
        }
        private static void Stringişlem()
        {
            Console.WriteLine("...STRING İŞLEMLERİ...");
            Console.WriteLine("İşlem yapacağınız Stringi giriniz.");
            string girilenstring;
            girilenstring = Console.ReadLine();
            Console.WriteLine("İstenilen harf:");
            char istenenharf;
            istenenharf = Console.ReadLine()[0];
            int bulunanharf = 0;
            //Kullanıcının girdiği yazıda yine kullanıcının girdiği harfin
            //kaç kere geçtiğini bulur
            for (int i = 0; i < girilenstring.Length; i++)
            {
                if (girilenstring[i] == istenenharf)//harf yazıdaki bir harfe eşitse adeti bir arttırır
                {
                    bulunanharf++;
                }
            }
            if (bulunanharf == 2)//2 kere bulundu
            {
                Console.WriteLine("1-Ara Metini Tersten Yaz");
                Console.WriteLine("2-Ara Metini Tekrarlı Yaz");
                Console.Write("Seçiminiz:");
                string secim;
                secim = Console.ReadLine();
                bool bulundu = false;
                if (secim == "1")
                {
                    Console.WriteLine("1. İşlemin cevabı:");
                    //Kullanıcının girdiği yazıda harf iki defa varsa aradaki yazıyı tersten yazıyor
                    for (int i = girilenstring.Length - 1; i >= 0; i--)
                    {
                        if (girilenstring[i] == istenenharf)
                        {
                            if (bulundu == true)
                                break;
                            bulundu = true;
                            continue;
                        }
                        if (bulundu)//Aradaki yazıyı harf harf ekrana yazar
                            Console.Write(girilenstring[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (secim == "2")
                {
                    Console.WriteLine("2. İşlemin cevabı:");
                    string aradakiyazi = "";
                    //Kullanıcının girdiği yazıda iki harf arasında bulunan yazıyı bulur ve bunu bir değişkene atar
                    for (int i = 0; i < girilenstring.Length; i++)
                    {
                        if (girilenstring[i] == istenenharf)
                        {
                            if (bulundu == true)
                                break;
                            bulundu = true;
                            continue;
                        }
                        if (bulundu)//aradaki harfleri değişkene sırayla ekler
                            aradakiyazi += girilenstring[i];
                    }
                    //Bulunan yazıyı ekrana 5 defa yazar
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(aradakiyazi);
                    }
                    Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Hatalı işlem yaptınız");
                    Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Cümle içerisinde aranan harf bulunamamıştır.");
                Console.WriteLine("Lütfen devam etmek için bir tuşa basınız");
                Console.ReadLine();
                Console.Clear();
                return;
            }
        }
    }
}

