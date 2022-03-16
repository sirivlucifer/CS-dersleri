 Console.WriteLine(DateTime.Now); //Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);// Bu haftanın hangi günü olduğunu verir.
            Console.WriteLine(DateTime.Now.DayOfYear);// Bu gün yılın kaçıncı günü olduğunu verir.

            Console.WriteLine(DateTime.Now.ToLongDateString());//

            Console.WriteLine(DateTime.Now.ToShortDateString());//

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2)); //Bu güne 2 gün ekle.
            Console.WriteLine(DateTime.Now.AddHours(3)); 
            Console.WriteLine(DateTime.Now.AddSeconds(30)); 
            Console.WriteLine(DateTime.Now.AddMonths(5)); 
            Console.WriteLine(DateTime.Now.AddYears(5)); 
            Console.WriteLine(DateTime.Now.AddMilliseconds(100)); 

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //
            Console.WriteLine(DateTime.Now.ToString("ddd")); //
            Console.WriteLine(DateTime.Now.ToString("dddd")); //C


            Console.WriteLine(DateTime.Now.ToString("MM")); //
            Console.WriteLine(DateTime.Now.ToString("MMM")); //

            Console.WriteLine(DateTime.Now.ToString("yy")); //
            
            Console.WriteLine(DateTime.Now.ToString("yyy")); 
            
            
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));
            

            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));


            Console.WriteLine(Math.Ceiling(22.3));//


            Console.WriteLine(Math.Round(22.3));//
            Console.WriteLine(Math.Round(22.7));//
            Console.WriteLine(Math.Floor(22.7));//

            Console.WriteLine(Math.Max(2,3));
            Console.WriteLine(Math.Min(2,3));

            Console.WriteLine(Math.Pow(3,4));//üs alma
            Console.WriteLine(Math.Sqrt(9));//Kök hesaplar.

            Console.WriteLine(Math.Log(9));//9'un e tabanında logaritmasını verir.
            Console.WriteLine(Math.Log10(10)); 