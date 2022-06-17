using System;

namespace condicional_ternaria {
    class Program {
        static void Main(string[] args) {
            double preco = 34.5;
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine($"Preco = {preco}");
            Console.WriteLine($"Desconto = {desconto}");
            Console.WriteLine($"Total = {preco - desconto}");
        }
    }
}
