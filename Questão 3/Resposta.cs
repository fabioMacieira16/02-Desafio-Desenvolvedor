using System;

class Program {
    static void Main(string[] args) {
        int num;
        
        // Solicita ao usuário o número a ser verificado
        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        
        bool pertence = pertenceFibonacci(num);
        
        if (pertence) {
            Console.WriteLine("{0} pertence à sequência de Fibonacci", num);
        } else {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci", num);
        }
    }
    
    // Função que verifica se um número pertence à sequência de Fibonacci
    static bool pertenceFibonacci(int num) {
        int a = 0, b = 1, c = 1;
        
        // Verifica se o número é 0 ou 1, que são casos especiais
        if (num == 0 || num == 1) {
            return true;
        }
        
        // Calcula a sequência de Fibonacci até que o próximo número seja maior que num
        while (c < num) {
            c = a + b;
            a = b;
            b = c;
        }
        
        // Verifica se o último número calculado é igual a num
        if (c == num) {
            return true;
        } else {
            return false;
        }
    }
}