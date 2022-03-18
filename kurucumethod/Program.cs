Calisan calisan3 = new Calisan("ERDEM","TUNCAY",123123123,"DEV");

calisan3.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    // Kurucu Fonksiyon oluşturarak class çağırılırken değer alması sağlanabilir
    // daha okunaklı kod yazmaya olanak sağlar.

    public Calisan(string ad, string soyad , int no , string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}",Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}",No);
        Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
    }
}