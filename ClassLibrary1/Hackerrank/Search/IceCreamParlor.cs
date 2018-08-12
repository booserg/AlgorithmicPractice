using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Hackerrank.Search
{
    public class IceCreamParlor
    {
        public class IceCream
        {
            public int Price { get; set; }
            public int SourceIndex { get; set; }
        }

        public static IceCream binarySearch(List<IceCream> menu, int price)
        {
            int midIndex = menu.Count() / 2;
            if (menu.Count() == 0 || (menu.Count() == 1 && menu[0].Price != price))
                return null;

            List<IceCream> subMenu;

            if (menu[midIndex].Price == price)
            {
                return menu[midIndex];
            }
            else if (price > menu[midIndex].Price)
            {
                subMenu = menu.Skip(midIndex + 1).ToList();
                return binarySearch(subMenu, price);
            }
            else if (price < menu[midIndex].Price)
            {
                subMenu = menu.Take(midIndex).ToList();
                return binarySearch(subMenu, price);
            }
            else
                return null;
        }

        public static int[] findPair(int[] menu, int money)
        {
            var icecreamMenu = new List<IceCream>();
            for(int i = 0; i < menu.Length; i++)
                icecreamMenu.Add(new IceCream() { Price = menu[i], SourceIndex = i });

            var sortedIcecreamMenu = icecreamMenu.OrderBy(p => p.Price).ToList();

            for(int i = 0; i < sortedIcecreamMenu.Count(); i++)
            {
                var checkingIceCream = sortedIcecreamMenu[i];

                var subMenu = sortedIcecreamMenu.Skip(i + 1).ToList();

                var pairIceCream = binarySearch(subMenu, money - checkingIceCream.Price);

                if(pairIceCream != null)
                {
                    return new List<int>() { checkingIceCream.SourceIndex + 1, pairIceCream.SourceIndex + 1 }.OrderBy(index => index).ToArray();
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
