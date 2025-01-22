public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        //Check if value is within the range of int
        if (value > int.MaxValue || value < int.MinValue)
        {
            throw new ArgumentOutOfRangeException("value", "Value is out of range for int.");
        }
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        try
        {
            //Exception will be thrown when the class is created with a large value
            ExampleClass obj = new ExampleClass(int.MaxValue);
            Console.WriteLine(obj.MyProperty);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}