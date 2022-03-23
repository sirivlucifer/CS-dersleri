using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int islem = 0;
while(islem==0){
Console.WriteLine(  "Lütfen yapmak istediğiniz işlemi seçiniz :) ");
Console.WriteLine("****************************************************************");
Console.WriteLine("(1) Yeni Numara Kaydetmek");
Console.WriteLine("(2) Varolan Numarayı Silmek");
Console.WriteLine("(3) Varolan Numarayı Güncelleme");
Console.WriteLine("(4) Rehberi Listelemek");
Console.WriteLine("(5) Rehberde Arama Yapmak");
Console.WriteLine("(6) çıkmak için)");

List<Rehber> kisiler = new List<Rehber>();

kisiler.Add(new Rehber("Erdem","Tuncay",123456789));
kisiler.Add(new Rehber("Ali","Mazo",123456741));
kisiler.Add(new Rehber("Veli","Türk",741852963));
kisiler.Add(new Rehber("Apo","Sancak",963852741));
kisiler.Add(new Rehber("Sado","Bayrak",258369147));

islem = Int32.Parse(Console.ReadLine());

switch (islem) 
{
  case 1:
  Ekleme();
    break;
  case 2:
    Silme();
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Listeleme();
    break;
  case 5:
    Arama();
    break;
    default: Console.WriteLine("Hata böyle bir işlem bulunamadı"); break;
  case 6:
  break;
}

void Ekleme(){ 

Console.WriteLine("Lütfen isim giriniz              :");
string isim = Console.ReadLine();

Console.WriteLine("Lütfen soyisim giriniz           :");
string soyisim = Console.ReadLine();

Console.WriteLine("Lütfen telefon numarası giriniz  :");
long numara = Int32.Parse(Console.ReadLine());

kisiler.Add(new Rehber(isim, soyisim, numara));

Listeleme();

}
void Silme()
            {
            geri:
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string ad = Console.ReadLine();
                bool onay = false;

                for (int i = 0; i < kisiler.Count; i++)
                {
                    if (ad == kisiler[i].ad || ad == kisiler[i].soyad)
                    {
                        onay = true;
                        Console.WriteLine(" {0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", ad);
                        char tf = char.Parse(Console.ReadLine());
                        if (tf == 'y')
                        {
                            kisiler.RemoveAt(i);
                            Listeleme();
                        }

                    }
                }
                if (onay == false)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("  * Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("  * Yeniden denemek için      : (2)");
                    int karar = Int32.Parse(Console.ReadLine());
                    if (karar == 2)
                    {
                        goto geri;
                    }
                }

            }

void Listeleme()
            {
                for (int i = 0; i < kisiler.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". kişi :  " + kisiler[i].ad + " " + kisiler[i].soyad + " " + kisiler[i].number);
                }
            }

void Arama(){
  Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
  Console.WriteLine("********************");

  Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
  Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

  int karar = Int32.Parse(Console.ReadLine());

  if (karar == 1){
    string isimsoyisim = Console.ReadLine();
    for (int i = 0; i < kisiler.Count; i++)
      if(isimsoyisim == kisiler[i].ad && isimsoyisim==kisiler[i].soyad)  
         Console.WriteLine("İsim:{0} Soyisim:{1} Numara:{2}",kisiler[i].ad,kisiler[i].soyad,kisiler[i].number);

      }else if(karar==2){
        int arama = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < kisiler.Count; i++)
          if(arama==kisiler[i].number)
            Console.WriteLine("İsim:{0} Soyisim:{1} Numara:{2}",kisiler[i].ad,kisiler[i].soyad,kisiler[i].number);
          }
        }  


  }//while döngüsü




 public class Rehber
    {
        public string ad;
        public string soyad;
        public long number;

        public Rehber(string ad, string soyad, long number)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.number = number;
        }
    }