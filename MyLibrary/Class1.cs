using System.Diagnostics;

namespace MyLibrary
{
    public class Class1
    {
        public int Factorial(int n)
        {
            Debug.WriteLine($"Вызван Factorial с n = {n}");
            Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));


            if (n < 0) throw new ArgumentException("n должен быть >= 0");

            int result = 1;
            for (int i = 2; i <= n; i++) result *= i;

            Debug.WriteLine($"Результат: {result}");
            File.AppendAllText("debug.log", $"Результат: {result}\n");

            return result;
        }
    }
}
