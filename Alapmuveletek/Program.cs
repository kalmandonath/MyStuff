using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float ossz, kul, szor, hany;

            Console.Write("Kérem az első számot: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            b = int.Parse(Console.ReadLine());
            ossz = a + b;
            kul = Math.Abs(a - b);
            szor = a * b;

            if (a > b)
            {
                hany = a / b;
            }
            else
            {
                hany = b / a;
                
            }


            Console.WriteLine();
            Console.WriteLine("Összeguk: " + ossz);
            Console.WriteLine("Kulonbseguk: " + kul);
            Console.WriteLine("Hanyadosuk: " + hany);
            Console.WriteLine("Szorzatuk: " + szor);






            Console.ReadKey();

        }
    }

