using System;
public class Demo
{
	public static int count;
	static Demo()
	{
		count = 10;
		Console.WriteLine("static constructor");
	}
	public Demo(int x)
	{
		count = 11;
		Console.WriteLine("constructor");
	}
}
public class Constructors
{
	public static void Main(string[] args)
	{
		
		Console.WriteLine(Demo.count);
		Demo ob1 = new Demo(1);
	//	Demo ob2 = new Demo(2);
	}
}