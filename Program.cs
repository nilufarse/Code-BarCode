using System;

namespace HomeworkN3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int baslangic = 20;
            //int son = 100;
            //int sum = 0;

            //for(int i= baslangic; i < son; i++)
            //{

            //    sum = sum + i;
            //}
            //Console.WriteLine("sum" + sum);


            //int baslangic = 5;
            //int son = 15;
            //float sum = 0;
            //float tekrar = 0;
            //for( int i= baslangic; i < son; i++) 
            //{
            //    sum = sum + i;
            //    Console.WriteLine(sum);
            //    tekrar = tekrar + 1;
            //    Console.WriteLine(tekrar);
            //}
            //float avg = sum / tekrar;
            //Console.WriteLine("5-den 15-a qeder edelerin ortalamasini yazin: "+ avg);


            //int age = 18;
            //int point = 50;
            //bool iscon = true;


            //do
            //{
            //    Console.WriteLine("Salam telebe.");
            //    Console.Write("Yasinizi qeyd edin: ");
            //    int agesorgu = int.Parse(Console.ReadLine());

            //    if (agesorgu>age)
            //    {
            //        Console.Write("balinizi qeyd edin:");
            //        int pointsorgu = int.Parse(Console.ReadLine());
            //        if (pointsorgu>point)
            //        {
            //            Console.WriteLine("siz kursdan ugurla kecdiniz");
            //        }
            //        else{
            //            Console.WriteLine("sizin baliniz yeterli deyil");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("sizin yasiniz catmir.");
            //    }

            //    Console.WriteLine("davam etmek isteyirsizmi? he/yox");
            //    string sual = Console.ReadLine();

            //    if (sual == "he")
            //    {
            //        iscon = true;
            //    }
            //    if (sual == "yox")
            //    {
            //        Console.WriteLine("tesekkur");
            //        iscon = false;
            //    }


            //} while (iscon);


            //int baslangic = 1;
            //int son = 20;
            //int sum = 0;

            //for (int i = baslangic; i < son; i++)
            //{
            //    if (i%2!=0)
            //    {
            //        sum = sum + i;
            //    }

            //}
            //Console.WriteLine("sum" +sum);

            bool iscon = true;
            do
            {

                Console.Write("baslangic eded :");
                int baslangic = int.Parse(Console.ReadLine());
                Console.Write("son eded :");
                int son = int.Parse(Console.ReadLine());
                int cutsum = 0;
                int sum = 0;


                for (int i = baslangic; i < son; i++)
                {
                    sum = sum + i;
                    if (i%2==0)
                    {
                        cutsum = cutsum + i;
                    }
                }

                Console.WriteLine("daxil etdiyiniz iki eded araligindaki cemi:" + sum);
                Console.WriteLine("daxil etdiyiniz iki eded araligindaki cutlerin cemi:" + cutsum);

                Console.WriteLine("davam etmek isteyirsiz?");
                string sual = Console.ReadLine();
                if (sual=="he")
                {
                    iscon = true;

                }
                if (sual == "yox")
                {
                    iscon = false;

                }
            } while (iscon);


        }

    }
}
