using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MyCustomAttribute : Attribute
    {
        public string Description { get; set; }
        public MyCustomAttribute(string description)
        {
            Description = description;
        }
    }

    public class MyClass
    {
        [MyCustomAttribute("This is a description of the DoSomething method.")]
        public void DoSomething() { } 
    }
    
    class AttributeReader
    {
        public static void ReadCustomAttributes()
        {
            MethodInfo method = typeof(MyClass).GetMethod("DoSomething");
            MyCustomAttribute attribute = (MyCustomAttribute)method.GetCustomAttribute(typeof(MyCustomAttribute));

            Console.WriteLine($"Method description: {attribute.Description}");
        }
    }
}
