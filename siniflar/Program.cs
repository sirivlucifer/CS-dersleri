Calisan calisan1 = new Calisan();
calisan1.Ad = "ERdem";
calisan1.Soyad = "Tuncay";
calisan1.No = 1234567890;
calisan1.Departman ="Developer";

calisan1.CalisanBilgileri();

Console.WriteLine("\n");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Ali";
calisan2.Soyad = "VELİ";
calisan2.No = 234567890;
calisan2.Departman = "IK";

calisan2.CalisanBilgileri();


class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;


    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}",Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}",No);
        Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
    }
}
