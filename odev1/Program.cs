//1.örnek
       /*     Console.Write("Pozitif bir sayi giriniz ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet sayi giriniz",n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz;", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Çift "+sayi);
                }
            }
 
//2. örnek
 Console.WriteLine("Kaç tane sayı ile işlem yapmak istiyorsun N");
 int n= Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Modu hangi sayı ile alayım M");
 int m= Convert.ToInt32(Console.ReadLine());

 for (int i = 0; i <n; i++){
     Console.WriteLine("{0} sayıyı giriniz",i+1);
     int sayi= Convert.ToInt32(Console.ReadLine());

     if(sayi%m==0 ){
         Console.WriteLine("Değer = {0}",sayi);
     }
    
      }
      
    

//3.örnek
List<string> kelimeler = new List<string>();
Console.WriteLine("Pozitif bir sayı girin");
int n= Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < n; i++){
    Console.WriteLine("{0} harfi giriniz",i+1);
    string kelime = Console.ReadLine();
    kelimeler.Add(kelime);

}
int son = kelimeler.Count - 1;
Console.WriteLine("---sondan başa doğru kelimeler---");
for (int i = son; i >= 0; --i){

    Console.WriteLine(kelimeler[i]);
}
  */

  Console.Write("Bir cümle gir :");
string cumle = Convert.ToString(Console.ReadLine()); // cümle aldım
string[] kelimeler = cumle.Split(" "); // cümleyi kelimelere ayırdım.
char[] harf = cumle.ToCharArray(); // cümleyi harflerine ayırdım

Console.WriteLine("Verilen Cümlede {0} Kelime Vardır.", kelimeler.Length);
Console.WriteLine("Verilen Cümlede {0} harf Vardır.", harf.Length);