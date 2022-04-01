int islem = 0;
while(islem==6){
Console.WriteLine(  "Lütfen yapmak istediğiniz işlemi seçiniz :) ");
Console.WriteLine("****************************************************************");
Console.WriteLine("(1) Board Listelemek");
Console.WriteLine("(2) Board'a Kart Eklemek");
Console.WriteLine("(3) Board'dan Kart Silmek");
Console.WriteLine("(4) Kart Taşımak");
Console.WriteLine("(6) çıkmak için)");

List<Board> list = new List<Board>();
List<Board> TODO = new List<Board>();
List<Board> INPROGRESS = new List<Board>();
List<Board> DONE = new List<Board>();

list.Add(new Board("BASLIK","ICERIK","ATANAN KISI", "BUYUKLUK"));

islem = Int32.Parse(Console.ReadLine());

switch (islem) 
{
  case 1:
  //Ekleme();
    break;
  case 2:
   // Silme();
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
  //  Listeleme();
    break;
  case 5:
   // Arama();
    break;
    default: Console.WriteLine("Hata böyle bir işlem bulunamadı"); break;
  case 6:
  break;
}


}













public class Board{
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public Buyukluk Boyut { get; set; }

    public enum Buyukluk
        {
            XS,
            S,
            M,
            L,
            XL
        }
    public Board(string baslik, string icerik, string atananKisi,Buyukluk boyut){
    this.Baslik = baslik;
    this.Icerik = icerik;
    this.AtananKisi = atananKisi;
    this.Boyut = boyut;
        }

     void Listele(){ 
        for (int i=0;i < Board.Count ;i++){
            Console.WriteLine("");
        }
        foreach(var Board in TODO){

        }


    }

    public void KartEkle() { 

    }

}

