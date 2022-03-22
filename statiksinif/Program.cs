﻿
Console.WriteLine("Calışan sayısı:{0}",Calisan.CalisanSayisi);
Calisan calisan = new Calisan("ayşe","yılmaz","ık");
Console.WriteLine("Calışan sayısı:{0}",Calisan.CalisanSayisi);
Calisan calisann = new Calisan("ayşe","yılmaz","ık");
Console.WriteLine("Calışan sayısı:{0}",Calisan.CalisanSayisi);

Console.WriteLine("topla islme sonucu {0}",Islemler.Topla(100,200));
Console.WriteLine("cikar islme sonucu {0}",Islemler.Cikar(100,200));

class Calisan{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;

    private string Soyisim;

    private string Departman;

    static Calisan() { 
        calisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman){
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi ++;
    }

}

static class Islemler{
    public static long Topla(int sayi1, int sayi2){
        return sayi1 + sayi2;

    }
    public static long Cikar(int sayi1, int sayi2){
        return sayi1 - sayi2;

    }
}
