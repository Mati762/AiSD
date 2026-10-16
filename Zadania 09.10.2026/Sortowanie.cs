using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_09._10._2026
{
    internal class Sortowanie
    {

        public static void Babelkowe(int[] tab)
        {
            int n = tab.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n-i-1; j++)
                {
                    if (tab[j] > tab[j+1])
                    {
                        int tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                    }
                }
            }
        }
        public static int[] Konwertuj(string liczby)
        {
            string[] czesciTekstowe = liczby.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var wynik = new int[czesciTekstowe.Length];

            for (int i = 0; i < czesciTekstowe.Length; i++)
            {
                wynik[i] = int.Parse(czesciTekstowe[i]);
            }

            return wynik;
        }
        public static void Wybieranie(int[] tab)
        {
            int n = tab.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (tab[j] < tab[minIndex])
                    {
                        minIndex = j; 
                    }
                }

                if (minIndex != i)
                {
                    int tmp = tab[i];
                    tab[i] = tab[minIndex];
                    tab[minIndex] = tmp;
                }
            }
        }
    }
}