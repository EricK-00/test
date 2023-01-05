namespace TestCSharo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Ruler ruler = new Ruler(10);
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