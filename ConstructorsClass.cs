using System;
public class Demo
{
	public static int count;
	static Demo()
	{
		count = 10;
		Console.WriteLine("static constructor");
	}
}
public class Constructors
{
	public static void Main(string[] args)
	{
		//Demo ob1 = new Demo();
		Console.WriteLine(Demo.count);
		
		//Demo ob2 = new Demo();
	}
}