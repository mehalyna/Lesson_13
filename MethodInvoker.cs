using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class MethodInvoker
    {
        public static void InvokMethodsDynamically()
        { 
            Type personType = typeof(Person);
            Person personInstance = new Person();

            MethodInfo sayHelloMethod = personType.GetMethod("SayHello");
            sayHelloMethod.Invoke(personInstance, null);

            MethodInfo whisperSecretMethod = personType.GetMethod("WhisperSecret", BindingFlags.NonPublic | BindingFlags.Instance);
            whisperSecretMethod.Invoke(personInstance, null);
        }
    }
}
