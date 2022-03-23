using System.Collections;

/* SORU 1
Console.WriteLine("20 adet satı giriniz");

var asal = new ArrayList(); // recommended 
var notasal = new ArrayList(); // recommended 
int sonuc = 0;
int asaltoplam =0;
int notasaltoplam =0;

for (int i = 0; i <20; i++){

    int deger= Convert.ToInt32(Console.ReadLine());

    if (deger < 0){
        Console.WriteLine("negatif girme");
    }else {
        sonuc = Asalmi(deger);
          if (sonuc == 0)
            {
                notasal.Add(deger);
                Console.WriteLine("{0} Asal Sayı Değildir.", deger);
                notasaltoplam = notasaltoplam+deger;
            }
            else
            {
                asal.Add(deger);
                Console.WriteLine("{0} Asal Sayıdır.", deger);
                asaltoplam = asaltoplam+deger;
            }

    }
        
    }
    asal.Sort();
    notasal.Sort();
 Console.WriteLine("*******************");
    Console.WriteLine("ASAL SAYILAR");
foreach (var item in asal)
    Console.Write(item + ", ");
 Console.WriteLine("*******************");
        Console.WriteLine("ASAL OLMAYAN SAYILAR");
foreach (var item in notasal)
    Console.Write(item + ", ");
 Console.WriteLine("*******************");
 Console.WriteLine("ASAL SAYILAR ortalaması ve kaç sayısı olduğu"); 
 Console.WriteLine("ortalama = {0} kaç sayı var:,{1}", asaltoplam/asal.Count,asal.Count);
 Console.WriteLine("*******************"); 
  Console.WriteLine("ASAL OLMAYAN SAYILAR ortalaması ve kaç sayısı olduğu"); 
Console.WriteLine("ortalama = {0} kaç sayı var:{1}", notasaltoplam/notasal.Count,notasal.Count);
 Console.WriteLine("*******************");

static int Asalmi(int sayi){
    int i = 0;
    for(i=2;i<=sayi-1;i++){
        if(sayi % i==0){
            return 0 ;
        }

    }
    if(i==sayi){
        return 1 ;
    }
    return 0;
}


//SROU 2


            Console.WriteLine("Dizinin eleman sayısını girin.");
            int arrLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrLength];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                                              
            }
  Array.Sort(numbers);
            int min = 0;
            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                min += numbers[i];
                Console.WriteLine("Minumum sayılar {0}",numbers[i]);
            }
            

            for (int i = numbers.Length-3; i < numbers.Length; i++)
            {
                max += numbers[i];
                Console.WriteLine("Maks sayılar {0}",numbers[i]);
            }
            
            Console.WriteLine("Minimum 3 sayının ortalaması: " + min / 3);
            Console.WriteLine("Maximum 3 sayının ortalaması: " + max/3);
            Console.WriteLine("Ortalama toplamları: " + (min/3 + max/3));
             for (int i = numbers.Length-3; i < numbers.Length; i++)
            {
              
                Console.WriteLine("Maks sayılar {0}",numbers[i]);
            }
            for (int i = 0; i < 3; i++)
            {
               
                Console.WriteLine("Minumum sayılar {0}",numbers[i]);
            }
*/

//Soru 3

  List<string> words = new List<string>();
            string[] wowels = { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
            List<string> word = new List<string>();

            words.Add(Console.ReadLine());

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < wowels.Length; j++)
                {
                    if (words[i].Contains(wowels[j]))
                    {
                        word.Add(wowels[j]);
                    }
                }
                
            }

            Console.WriteLine("Ünlü harfler: ");
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
            

        