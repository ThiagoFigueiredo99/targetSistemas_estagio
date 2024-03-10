using System;

class Program
{
    static void Main(string[] args)
    {
        // 1) Ao final do processamento, qual será o valor da variável SOMA?

        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("1) Resultado da soma é: {0}", SOMA);


        // 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
        // (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
        // ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

        Console.Write("2) Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (IsFibonacci(numero)){
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }else{
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }

        // 3) Descubra a lógica e complete o próximo elemento:
            // a) A lógica é adicionar 2 a cada número anterior.
            // 1, 3, 5, 7, 9.

            //  b) A lógica é multiplicar cada número anterior por 2.
            // 2, 4, 8, 16, 32, 64, 128.

            // c) A lógica é o quadrado dos números naturais começando de 0.
            // 0, 1, 4, 9, 16, 25, 36, 49

            // d) A lógica parece ser o quadrado dos números pares começando de 2.
            // 4, 16, 36, 64, 100

            // e) A lógica é a sequência de Fibonacci.
            // 1, 1, 2, 3, 5, 8, 13

            // f) A lógica é adicionar 8 ao primeiro número, depois 2 ao segundo, depois 4 ao terceiro, depois 1 ao quarto, e assim por diante.
            // 2, 10, 12, 16, 17, 18, 19, 20

        // 4) descobrir qual interruptor controla qual lâmpada
            // Ligue o primeiro interruptor e aguarde alguns minutos.
            // Desligue o primeiro interruptor e ligue o segundo interruptor.
            // Depois entre na sala.

            // Agora, quando entrar na sala, você verá:

                // A lâmpada que estiver acesa foi controlada pelo segundo interruptor que você ligou (e deixou ligado).

                // Verifique a lampada que esta apagada e quente foi controlada pelo primeiro interruptor (que você ligou primeiro e desligou em seguida).

                // Agora a lâmpada que estiver apagada e fria foi controlada pelo último interruptor (terceiro interruptor) que você permanceu desligado.


            // Dessa forma, você pode determinar qual interruptor controla cada lâmpada.
 

        Console.Write("5) Digite uma string: ");
        string entrada = Console.ReadLine();

        string invertida = InverterString(entrada);

        Console.WriteLine("String invertida: {0}", invertida);
    }


static bool IsFibonacci(int n){
        int a = 0, b = 1;
        while (b < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == n;
    }

static string InverterString(string str){
        return new string(str.Reverse().ToArray());
    }
}