using System;
using System.Collections.Generic;
using System.Linq;

namespace NameOfKings
{
    public class Kings
    {
        static void Main(string[] args)
        {
            KingSort kingSort = new KingSort();
            //You are given a String[] kings
            string[] kings = new String[17];

            kings[0] = "Louis IX";//9
            kings[1] = "Louis VIII";//8
            kings[2] = "Philippe II";
            kings[3] = "Richard III";
            kings[4] = "Richard I";
            kings[5] = "Richard II";
            kings[6] = "John X";//10
            kings[7] = "John I";//1
            kings[8] = "John L";//50
            kings[9] = "John V";//5
            kings[10] = "Philippe VI";
            kings[11] = "Jean II";
            kings[12] = "Charles V";
            kings[13] = "Charles VI";
            kings[14] = "Charles VII";
            kings[15] = "Louis XI";//11
            kings[16] = "Philip II";

            var ordainedKings = kingSort.getSortedList(kings);

            foreach (var value in ordainedKings)
            {
                Console.WriteLine(value);
            }            
        }
    }
}
