using System;
public delegate void MyDelegate(int a, int b);
class A
{
    public event MyDelegate MyEvent;
    public void Addition(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Result: {0}+{1}={2}", a, b, result);
        if (MyEvent == null)
        {
            Console.WriteLine("No event handlers attached.");
        }
        else
        {
            MyEvent(a, b);
        }
    }
}
class B
{
    public void Multiply(int a, int b)
    {
        int result = a * b;
        Console.WriteLine("Result: {0}*{1}={2}", a, b, result);
    }
}
class Program
{
    static void Main()
    {
        A a = new A(); B b = new B();
        a.MyEvent += b.Multiply;
        a.Addition(5, 3);
        a.MyEvent -= b.Multiply;
        a.Addition(5, 5);
        Console.ReadLine();
    }
}