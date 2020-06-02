using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace NameOfKings
{
    public class KingSort
    {
        public String[] getSortedList(String[] kings)
        {
            //novo array de reis instanciando classe de Kings
            var arrayKings = new Kings[kings.Length];
            //para ordenar os reis
            var ordainedKings = new string[kings.Length];

            //lop
            for (int i = 0; i < kings.Length; i++)
            {
                var king = kings[i].Split(" ");
                arrayKings[i] = new Kings();

                arrayKings[i].NameOfKing = king[0];
                arrayKings[i].RomanNumeral = king[1];
                arrayKings[i].Number = convertToInt(arrayKings[i].RomanNumeral);
            }

            var list1 = arrayKings.OrderBy(x => x.NameOfKing).ThenBy(x => x.Number);

            List<Kings> lista = new List<Kings>(list1);

            //mostrar na tela
            foreach (var value in lista)
            {
                Console.WriteLine(value.NameOfKing + " " + value.RomanNumeral);
            }

            return ordainedKings;

        }
        private int convertToInt(string romanNumeral)
        {
            int aux;

            if (romanNumeral.Length == 1)
            {
                aux = dictionaryRomain(romanNumeral.ToUpper());
            }
            else
            {
                int arraySize = romanNumeral.Length;
                var number = new int[arraySize];

                for (int i = 0; i < romanNumeral.Length; i++)
                {
                    number[i] = dictionaryRomain(romanNumeral[i].ToString());
                }

                //aqui ver
                int total = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    if (number.Length % 2 == 0)
                    {
                    
                            if (number[i] >= number[i + 1])
                            {
                                total += number[i] + number[i + 1];
                            }
                            else if (number[i] < number[i + 1])
                            {
                                total += number[i + 1] - number[i];
                            }

                            i++;
                        }
                    else
                    {
                        try
                        {
                            if (number[i] >= number[i + 1])
                            {
                                total += number[i];
                            }
                            else if (number[i] < number[i + 1])
                            {
                                total += number[i + 1] - number[i];
                            }
                        }
                        catch (Exception e)
                        {
                             total += number[i];
                        }
                    }
                }
                aux = total;
            }

            return aux;
        }

        //adicionando o dicionario
        private int dictionaryRomain(string romain)
        {
            Dictionary<String, int> list = new Dictionary<string, int>();
            list.Add("I", 1);
            list.Add("V", 5);
            list.Add("X", 10);
            list.Add("L", 50);
            list.Add("C", 100);
            list.Add("D", 500);
            list.Add("M", 1000);

            return list[romain];
        }


        //classe com infos do rei, ordenação e numeral
        public class Kings
        {
            public string NameOfKing { get; set; }
            //numero romano para poder converter
            public string RomanNumeral { get; set; }

            //numero decimal para poder ordenar corretamente
            public int Number { get; set; }
        }
    }
}









    /*
    public class KingSort : IComparer<King>
    {
        public void Full(King[] x)
        {
            for(int i = 0; i < x.Length ; i++)
            {
                x[i].Number = ConvertToInt(x[i].RomanNumeral);
            }
        }

        public int Compare([AllowNull] King x, [AllowNull] King y)
        {
            if (x == null) return 1;
            else if (y == null) return -1;
            else if (x.RomanNumeral.Equals(y.RomanNumeral)) return 0;
            else if (x.Number > y.Number) return -1;
            return 1;
        }

        private int ConvertToInt(string num)
        {
            //se a string for nulla ele retorna 0
            if (num == null) return 0;
            //aux é 0
            int aux = 0;

            //loop
            for (int i = 0; i < Romains.Length; i++)
            {
                while (num.StartsWith(Romains[i]))
                {
                    aux += Numbers[i];
                    num = num.Substring(1);

                }
            }
            return aux;
        }



        private int[] Numbers
        {
            get
            {
                return new int[] { 1, 5, 10, 50, 100 };
            }
        }
        private string[] Romains
        {
            get
            {
                return new string[] { "I", "V", "X", "L", "C" };
            }
        }
    }


}*/
