using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianLiczby
{
  
        public class Zadanie
        {
        string wyniki = @"wyniki4.txt";
        public Zadanie()
        {
            File.WriteAllText(wyniki, "");
        }

        public void Zadanie1()
            {
        
            string file = @"liczby.txt";
            
                string[] lines = File.ReadAllLines(@"liczby.txt");
                int count = 0;

                foreach (string line in lines)
                {
                    int num = int.Parse(line);
                    if (DoPotegiTrzeciej(num))
                        count++;
                }

                Console.WriteLine("Zadanie 1: Ilość potęg liczby 3: " + count);

            File.WriteAllText(wyniki, "");

            File.AppendAllText(wyniki, "Zadanie 1" + "\n");
            File.AppendAllText(wyniki, count.ToString() + "\n");



            //zapis zadania 1



        }








            public void Zadanie2()
            {
                string[] lines = File.ReadAllLines(@"liczby.txt");
                List<int> wynik = new List<int>();


                List<string> answers = new();

                foreach (string line in lines)
                {
                    int num = int.Parse(line);
                    int sum = ObliczSilnie(num);

                    if (sum == num)
                        wynik.Add(num);
                }

                Console.WriteLine("Zadanie 2: Liczby równe sumie silni swoich cyfr:");
                foreach (int num in wynik)
                {
                    Console.WriteLine(num);
                    answers.Add(num.ToString()); 
                }



            File.AppendAllText(wyniki, "Zadanie 2" + "\n");

                    foreach (string num in answers)
                {
                    File.AppendAllText(wyniki, num.ToString() + "\n");
                }
            }

            private bool DoPotegiTrzeciej(int num)
            {
                while (num > 1)
                {
                    if (num % 3 != 0)
                        return false;
                    num /= 3;
                }

                return true;
            }

            private int ObliczSilnie(int num)
            {
                int sum = 0;
                string cyfry = num.ToString();

                foreach (char cyfra in cyfry)
                {
                    int n = int.Parse(cyfra.ToString());
                    sum += silnia(n);
                }

                return sum;
            }

            private int silnia(int n)
            {
                if (n == 0)
                    return 1;

                int wynik = 1;
                for (int i = 1; i <= n; i++)
                {
                    wynik *= i;
                }

                return wynik;
            }

        }
    }
