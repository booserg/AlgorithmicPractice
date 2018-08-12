using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Hackerrank.Search
{
    public class IceCreamParlor2
    {
        public static int[] findPair(int[] menu, int money)
        {
            Dictionary<int, List<int>> menuMap = new Dictionary<int, List<int>>();

            for(int i = 0; i < menu.Length; i++)
            {
                if (!menuMap.ContainsKey(menu[i]))
                {
                    menuMap.Add(menu[i], new List<int>());
                    menuMap[menu[i]].Add(i);
                }
                else
                {
                    menuMap[menu[i]].Add(i);
                }
            }

            int searchedIndex = -1;
            for(int i = 0; i < menu.Length; i++)
            {
                var price = menu[i];
                if(menuMap.ContainsKey(money - price))
                {
                    var availibleIndexes = menuMap[money - price];

                    for(int j = 0; j < availibleIndexes.Count(); j++)
                    {
                        if(availibleIndexes[j] != i)
                        {
                            searchedIndex = availibleIndexes[j];

                            return new int[] { i + 1, searchedIndex + 1 };
                        }
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        public static void whatFlavors(int[] cost, int money)
        {
            var result = findPair(cost, money);
            Console.WriteLine("{0} {1}", result[0], result[1]);
        }
    }
}
