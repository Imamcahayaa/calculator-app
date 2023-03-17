class calculastor
{
	static void main(string[] args)
	{
		int a = 1;
		int b = 6;
		
		console.writeline("Hasiol penambahan: {0} + {1} = {2}" , a, b, penambahan(a, b));
		console.writeline("Hasiol pengurangan: {0} - {1} = {2}" , a, b, pengurangan(a, b));
		
		console.writeline("\nTekan sembarang key untuk keluar");
		console.Readkey();
	 
		
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
	