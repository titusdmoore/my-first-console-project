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
            //Console.WriteLine("100 % 7 = " + answer);
            answer = Arithmetic.Modulus(44398, 45);
            Console.WriteLine(answer);

            bool TorF = Arithmetic.isEvenDiv(655, 5);
            Console.WriteLine($"655 is evenly divivible by 112: {TorF}");
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
            int ans = a % b;
            //Example of Interpolation
            Console.WriteLine($"{a} mod {b} = {ans}");
            return ans;
        }
        public static bool isEvenDiv ( int a, int b) {
            return Modulus(a, b) == 0;
        }
    }
}
