using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public class Person
    {
        private int age;
        public string? Name { get; set; }
        public int Age { get; set; }

        public void SayHello() => Console.WriteLine("Hello!");
        private void WhisperSecret() => Console.WriteLine("I have a secret...");
    }
    class ReflectionDemo
    {
        public static void InspectType()
        {
            Type personType = typeof(Person);
            Console.WriteLine($"Type: {personType.Name}");

            Console.WriteLine($"\nProperties:");
            foreach (PropertyInfo prop in personType.GetProperties())
            {
                Console.WriteLine($"- {prop.Name} ({prop.PropertyType.Name})");
            }

            Console.WriteLine($"\nMethods:");
            foreach (MethodInfo method in personType.GetMethods())
            {
                if (method.DeclaringType == personType)
                {
                    Console.WriteLine($"- {method.Name}");

                }
            }

            Console.WriteLine($"\nFields:");
            foreach (FieldInfo field in personType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"- {field.Name} ({field.FieldType.Name})");
            }

        }
    }
}
