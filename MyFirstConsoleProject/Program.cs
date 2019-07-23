using System;

namespace MyFirstConsoleProject {
    class Program {
        static void Main(string[] args) { 
            Console.WriteLine("Hello World!");
            int answer = Arithmetic.Add(3, 7);
            Console.WriteLine("3 + 7 = " + answer);
            answer = Arithmetic.Subtract(10, 6);
            Console.WriteLine("10 - 6 = " + answer);
            answer = Arithmetic.Mult(5, 7);
            Console.WriteLine("5 * 7 = " + answer);
            answer = Arithmetic.Div(7, 2);
            Console.WriteLine("7 / 2 = " + answer);
            answer = Arithmetic.Modulus(100, 7);
            Console.WriteLine("100 % 7 = " + answer);
        }
    }
    class Arithmetic {
        public static int Add ( int a, int b) {
            return a + b;
        }
        public static int Subtract ( int a, int b) {
            return a - b;
        }
        public static int Mult ( int a, int b) {
            return a * b;
        }
        public static int Div ( int a, int b ) {
            if (b != 0) {
                return a / b;
            }else {
                return b;
            }
        }
        public static int Modulus ( int a, int b) {
            return a % b;
        }
    }
}
