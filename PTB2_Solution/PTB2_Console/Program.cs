using System;
using PTB2_Library;

namespace PTB2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Giải phương trình bậc 2 ===");
            Console.Write("Nhập a: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập b: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập c: "); double c = double.Parse(Console.ReadLine());

            QuadraticSolver solver = new QuadraticSolver(a, b, c);
            string result = solver.Solve();

            Console.WriteLine("👉 Kết quả: " + result);
            Console.ReadKey();
        }
    }
}
