﻿using System.Collections;
using System.Collections.Generic;

 ArrayList liste = new ArrayList();
            liste.Add("ERdem");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //İçerisindeki verilere erişelim

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);   
            }

            //AddRange : birden fazla eleman ekleme
            Console.WriteLine("*** Add Range ***");
            
            string[] renkler = {"kırmızı","beyaz","mavi","turuncu"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};

            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //sort//
            Console.WriteLine("*** Sort ***");
            //liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search : Önce sort daha sonra binary search işlemi çalıştırılmalı
            Console.WriteLine("*** Binary Search ***");
            //Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("*** Reverse ***");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("*** Clear ***");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);