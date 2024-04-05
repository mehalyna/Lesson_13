using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public class Calculator
    {
        public int Add(int a, int b)
        { 
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }


    class MethodInvokerWithParameters
    {
        public static void MethodInvoker()
        { 
            Calculator calculator = new Calculator();
            Type calculatorType = typeof(Calculator);

            MethodInfo addMethod = calculatorType.GetMethod("Add");
            object[] addParams = { 10, 20 };
            int addResult = (int)addMethod.Invoke(calculator, addParams);
            Console.WriteLine($"The sum: {addResult}");

            MethodInfo multMethod = calculatorType.GetMethod("Multiply");
            object[] multiplyParams = { 5, 10 };
            int multResult = (int)multMethod.Invoke(calculator, multiplyParams);
            Console.WriteLine($"The product: {multResult}");

        }
    }
}
