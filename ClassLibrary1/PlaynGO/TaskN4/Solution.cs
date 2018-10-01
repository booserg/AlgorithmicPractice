namespace AlgorithmicPractice.PlaynGO.TaskN4
{
	//Format the number 1234567.89 to 1,234,567.89.
	public class Solution
	{
		public string solution(decimal number)
		{
			return string.Format("{0:n}", number);

			//var intNumber = ((int)number);
			//var decimalNumber = number - intNumber;

			//var intNumberStr = intNumber.ToString();
			//var decimalNumberStr = decimalNumber.ToString().Remove(0, 2);

			//int cnt = 0;
			//string intNumberStrRes = "";
			//for (int i = intNumberStr.Length; i > 0; i--)
			//{
			//	intNumberStrRes = intNumberStr[i - 1] + intNumberStrRes;
			//	cnt++;
			//	if (cnt == 3)
			//	{
			//		cnt = 0;
			//		intNumberStrRes = "," + intNumberStrRes;
			//	}
			//}

			//return intNumberStrRes + "." + decimalNumberStr;
		}
	}
}
