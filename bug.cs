public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        //Exception will be thrown when the class is created with a large value
        ExampleClass obj = new ExampleClass(int.MaxValue);
        Console.WriteLine(obj.MyProperty); 
    }
}