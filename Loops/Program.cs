// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region For Loop
// SORU: 1'den 10'a kadar (10 dahil) olan tam sayıları ekrana yazdıran program:
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i.ToString());
//}

//for (int i = 1; i <= 10; i += 2)
//{
//    Console.WriteLine(i.ToString());
//}

//for (int i = 10; i >= 1; i --)
//{
//    Console.WriteLine(i.ToString());
//}

// 1 - 50 arasındaki çift sayıların toplamını ekrana yazan program;
//int toplam = 0;
//for (int i = 0; i < 50; i+= 2)
//{
//    toplam += i;
//}
//Console.WriteLine(toplam);

//int toplam = 0;
//for (int i = 0; i < 50; i+=2)
//{
//    if(i % 2 == 0)
//    {
//        toplam += i;
//    }
//}
//Console.WriteLine(toplam);

// SORU: Kullanıcıdan alınan 10 adet tam sayıdan en büyük ve en küçük değeri ekrana yazdıran program:
//int sayi, enKucuk, enBuyuk;
//enKucuk = enBuyuk = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
//    sayi = int.Parse(Console.ReadLine());

//    if (i == 0)
//        sayi = enBuyuk = enKucuk;
//    if(sayi < enKucuk)
//        enKucuk = sayi;
//    if(sayi > enBuyuk) 
//        enBuyuk = sayi;
//}
//Console.WriteLine($"En büyük sayı {enBuyuk}");
//Console.WriteLine($"En küçük sayı {enKucuk}");


#endregion

#region While Loop
// SORU: 1 - 100 arasındaki sayıları ekrana yazdıran program:
//int sayi = 1;
//while (sayi <= 100)
//{
//    Console.WriteLine(sayi);
//    sayi++;
//}

// SORU: Kullanıcıdan alınan metni yine kullanıcının girdiği sayı kadar ekrana yaz:
//Console.WriteLine("Tekrar etmesini istediğiniz bir metin giriniz: ");
//string metin = Console.ReadLine();

//Console.WriteLine("Bu metni kaç defa ekrana yazdırmak istediğinizi giriniz: ");
//bool sonuc = int.TryParse(Console.ReadLine(), out int tekrarSayisi);
//if(sonuc)
//{
//    int sayac = 1;
//	while (sayac <= tekrarSayisi)
//	{
//        Console.WriteLine(metin);
//        sayac++;
//    }
//} else
//{
//    Console.WriteLine("Tekrar sayısı hatalı girildi.");
//}
#endregion

#region Do While Loop
// SORU: Kullanıcıdan alınan sayının faktöriyel hesabını yapıp ekrana yazdıran program:
decimal faktoriyel = 1, sayi;
Console.WriteLine("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");

bool sonuc = decimal.TryParse(Console.ReadLine(), out sayi);

if (sonuc)
{
    if (sayi == 0) Console.WriteLine("0!= 1");

    else if(sayi > 0)
    {
        do
        {
            faktoriyel *= sayi;
            sayi--;
        } while (sayi > 0);
        Console.WriteLine($"Girdiğiniz sayının faktöriyeli {faktoriyel}");
    }
    else Console.WriteLine("Negatif sayıların faktöriyeli hesaplanamaz.");
}
else
{
    Console.WriteLine("Sayısal olmayan bir değer girdiniz.");
}
#endregion