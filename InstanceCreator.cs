using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class InstanceCreator
    {
        public static void CreateInstanceDynamically()
        {
            Type personType = typeof(Person);
            Person personIntance = (Person)Activator.CreateInstance(personType);

            personIntance.Name = "Jhon Doe";
            Console.WriteLine($"Instance created {personIntance.Name}");

        }
    }
}
