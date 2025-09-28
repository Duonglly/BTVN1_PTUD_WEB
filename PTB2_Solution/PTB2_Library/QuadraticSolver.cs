using System;

namespace PTB2_Library
{
    public class QuadraticSolver
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public QuadraticSolver(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }

        public string Solve()
        {
            if (A == 0) return "Không phải phương trình bậc 2";

            double delta = B * B - 4 * A * C;

            if (delta < 0) return "Phương trình vô nghiệm";
            if (delta == 0)
            {
                double x = -B / (2 * A);
                return $"Phương trình có nghiệm kép: x = {x}";
            }
            else
            {
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                return $"Phương trình có 2 nghiệm: x1 = {x1}, x2 = {x2}";
            }
        }
    }
}
