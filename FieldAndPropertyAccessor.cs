using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class FieldAndPropertyAccessor
    {
        public static void AccessFieldsAndPropertiesDynamically()
        {
            Type personType = typeof(Person);
            Person personInstance = new Person();

            PropertyInfo nameProperty = personType.GetProperty("Name");
            nameProperty.SetValue(personInstance, "Jane Doe");
            Console.WriteLine($"Name: {nameProperty.GetValue(personInstance)}");

            FieldInfo ageField = personType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
            ageField.SetValue(personInstance, 30);
            Console.WriteLine($"Age: {ageField.GetValue(personInstance)}");
        }
    }
}
