namespace Lesson_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inspecting Type Information");
            ReflectionDemo.InspectType();
            Console.WriteLine("\n----------------------------------\n");

            Console.WriteLine("Creating Instance Dynamically");
            InstanceCreator.CreateInstanceDynamically();
            Console.WriteLine("\n----------------------------------\n");

            Console.WriteLine("Invoking Methods Dynamically");
            MethodInvoker.InvokMethodsDynamically();
            Console.WriteLine("\n----------------------------------\n");

            Console.WriteLine("Access Field and Properties Dynamically");
            FieldAndPropertyAccessor.AccessFieldsAndPropertiesDynamically();
            Console.WriteLine("\n----------------------------------\n");

            Console.WriteLine("Working with attributes");
            AttributeReader.ReadCustomAttributes();
            Console.WriteLine("\n----------------------------------\n");

            Console.WriteLine("Invoking methods with parameters");
            MethodInvokerWithParameters.MethodInvoker();
            Console.WriteLine("\n----------------------------------\n");

            Console.ReadKey();
        }
    }
}