public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize MyProperty
    public ExampleClass()
    {
        MyProperty = 0; // Or any other default value
    }

    public void MyMethod()
    {
        //Safe way to access MyProperty
        int value = MyProperty * 2; 
    }

    public void MyMethodWithNullCheck()
    {
        int value = 0;
        if (MyProperty != null)
        {
            value = MyProperty * 2;
        }
        else
        {
            // Handle the null case appropriately, perhaps log an error or use an alternative value.
            Console.WriteLine("MyProperty is null");
        }
    }
}