namespace _20._10._20._07_宣告class
{
    internal class Program
	{
		static void Main(string[] args)
		{
			var cht = new EStore();
			int fee = cht.CalcInclusivePrice(150); // 150元的東西, 預設稅金0.05, 總共為157.5, 印出157
            Console.WriteLine(fee);
			int fee2 = cht.CalcInclusivePrice(123,0.08); // 123元的東西, 稅金0.08, 總共為132.84, 印出132
            Console.WriteLine(fee2);


			//展示IsPrime
			var math = new MathFunction();
            int num1 = int.Parse(Console.ReadLine());
            if (math.IsPrime(num1)) { Console.WriteLine(num1 + "是質數"); }
            else Console.WriteLine(num1+"不是質數");

			//展示PrintPrime
			int num2 = int.Parse(Console.ReadLine());
			math.PrintPrime(num2);

			//展示RoundToInt
			double temp = double.Parse(Console.ReadLine());
            Console.WriteLine(math.RoundToInt(temp));
        }
	}

	public class EStore
	{
        public int CalcInclusivePrice(int price, double taxRate = 0.05) // 無條件捨去至個位數(元)，明定自「各級公庫代理銀行代辦機構及代收稅款機構稅款解繳作業辦法」第5條
        {
			double temp = price * (1 + taxRate);
			int result = (int)Math.Floor(temp);
			return result;
        }
	}

	public class MathFunction
    {
		public bool IsPrime(int number)
		{
            if (number < 2) return false;
            else if (number == 2) return true;
            else if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i = i + 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public void PrintPrime(int number) //印出所有小於number的質數
        {
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("共有" + count + "個質數");
        }

        public int RoundToInt(double value) //四捨五入至個位數
		{
			int result = (int)System.Math.Round(value,MidpointRounding.AwayFromZero);
			return result;
		}
	}

}
