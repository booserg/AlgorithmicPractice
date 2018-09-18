using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.Challenges.DecodingMaster2
{
    public class Solution
    {
		public int solution(int[] A, int[] B)
		{
			Dictionary<int, Shops> shops = new Dictionary<int, Shops>();
			Wallet wallet = new Wallet() { Gold = A.Length / 2, Silver = A.Length / 2 };

			for(int i = 0; i < A.Length; i++)
			{
				if (shops.ContainsKey(A[i]))
					shops[A[i]].ShopA++;
				else
					shops[A[i]] = new Shops() { ShopA = 1, ShopB = 0 };

				if (shops.ContainsKey(B[i]))
					shops[B[i]].ShopB++;
				else
					shops[B[i]] = new Shops() { ShopA = 0, ShopB = 1 };
			}

			foreach(var kvp in shops)
			{
				if (kvp.Value.ShopA == 0 && kvp.Value.ShopB > 0 && !wallet.bought.Contains(kvp.Key) && wallet.Silver > 0)
				{
					wallet.bought.Add(kvp.Key);
					wallet.Silver--;
					kvp.Value.ShopB--;
				}

				if (kvp.Value.ShopB == 0 && kvp.Value.ShopA > 0 && !wallet.bought.Contains(kvp.Key) && wallet.Gold > 0)
				{
					wallet.bought.Add(kvp.Key);
					wallet.Gold--;
					kvp.Value.ShopA--;
				}
			}




			return 0;
		}

		class Shops
		{
			public int ShopA { get; set; }

			public int ShopB { get; set; }

		}

		class Wallet
		{
			public List<int> bought = new List<int>();
 
			public int Gold { get; set; }

			public int Silver { get; set; }
		}
	}
}
