using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciProject {
	class Program {

		long FibonacciWhile() {
			long nbr = 1;
			long fib = 0;
			while (nbr < 1000000000000000000 && fib < 1000000000000000000) {
				fib += nbr;
				nbr += fib;
				Console.WriteLine($"{fib}");
				Console.WriteLine($"{nbr}");
			}
			return nbr;
		}

		void FibonacciFor() {
			for (long nbr = 1, fib = 0; nbr < 1000000000000000000 && fib < 1000000000000000000;) {
				fib += nbr;
				nbr += fib;
				Console.WriteLine($"{fib}");
				Console.WriteLine($"{nbr}");
			}
		}
		void Print(string message) {
			Console.WriteLine(message);
		}
		void Run() {
			Print("The following is the Fibonacci series executed using a while statement");
			FibonacciWhile();
			Print("The following is the Fibonacci series executed using a for statement");
			FibonacciFor();
		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
		
	