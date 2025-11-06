using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsCalculatorGui
{
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }

        public Fraction(int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }

        public Fraction(string fraction)
        {
            string[] parts = fraction.Split('/');
            Top = int.Parse(parts[0]);
            Bottom = int.Parse(parts[1]);
        }
        
        public static Fraction operator +(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom + rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);

        public static Fraction operator -(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom - rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);

        public static Fraction operator *(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Top, lhs.Bottom * rhs.Bottom);

        public static Fraction operator /(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom, lhs.Bottom * rhs.Top);

        public override string ToString() => $"[{Top}, {Bottom}]";
    }

}
