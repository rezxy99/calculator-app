Class Calculator
{
	static void main(string[] rgs)
		{
			int a = 10;
			int b =6;
			
			Console.WriteLine("Hasil penambahan : {0} + {1} = {2}", a, b, penambahan (a, b));
			Console.WriteLine("Hasil pengurangan : {0} - {1} = {2}", a, b, penambahan (a, b));
			
			Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
			Console.ReadKey();
		}
		
		static int penambahan(int a, int b)
		{
			return a + b;
		}
			static int pengurangan(int a, int b)
		{
			return a - b;
		}
}