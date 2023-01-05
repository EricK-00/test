namespace TestCSharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//	2023.01.05. get user input
			int input;
			int.TryParse(Console.ReadLine(), out input);
			Ruler ruler = new Ruler(input);
			ruler.PrintInch();
		}
	}

	class Ruler
	{
		private const float ONE_INCH = 2.54f;
		public int Centimeter { get; set; } = 0;
		public float Inch
		{
			get { return Centimeter * ONE_INCH; }
			private set { Centimeter = (int)(value / ONE_INCH); }
		}

		public Ruler(int centimeter) { Centimeter = centimeter; }

		public void PrintInch()
		{
			Console.WriteLine($"{Centimeter}cm는 {Inch}inch 입니다.");
		}
	}
}