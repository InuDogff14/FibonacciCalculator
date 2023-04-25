// 必要な名前空間をインポートします
using System;

// プログラムが属する名前空間を定義します
namespace FibonacciCalculator
{
    // メインクラスを定義します
    class Program
    {
        // メインメソッドを定義します
        static void Main(string[] args)
        {
            // ユーザーに入力を求めます
            Console.Write("Fibonacci数列の要素数を入力してください: ");
            int n = int.Parse(Console.ReadLine());

            // Fibonacci数列を計算し、結果を表示します
            Console.WriteLine($"Fibonacci数列の最初の{n}個の要素:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}: {Fibonacci(i)}");
            }

            // プログラムがすぐに終了しないように、ユーザーの入力を待ちます
            Console.ReadLine();
        }

        // Fibonacci数列のn番目の要素を計算するメソッドを定義します
        static long Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
