using System;
class Program {
    static void Main (string[] args){
        int[] Vetor = new int [7]; // Declaração do Vetor

        //Entrada de elementos do Vetor
        for (int i = 0; i < 7; i++){
            Console.Write($"Digite o {i + 1}° elemento do Vetor: ");
            Vetor[i] = int.Parse(Console.ReadLine());
        }

        // Variaveis para a Soma e para a Quantidade
        int Soma;
        int Qtde;

        Soma = SomaPares(Vetor);
        Qtde = ContaImpares(Vetor);

        // Agora é só mostrar os resultados...
        
        Console.WriteLine("");

        Console.WriteLine($"A Soma dos Números Pares são: {Soma}");
        Console.WriteLine($"A Quantidade de Números Ímpares é: {Qtde}");

        Console.ReadKey();
    }

    // Funções

    static int SomaPares(int[] V){
        int S = 0; // Variavel para Somar os Pares

        for (int i = 0; i < 7; i++){  //Para cada elemento do Vetor...
             if (V[i] % 2 == 0)     //Ele é par?
             S += V[i];             // então acumula...    
        }
        return S;            // Retorna a Soma...
    }

    static int ContaImpares(int[] V){
        int Q = 0;    // Variaveis para Contar os Impares
        
        for (int i = 0; i < V.Length; i++){    // Para cada elemento do Vetor...
        if(V[i] % 2 != 0) // ele é impar?
        Q++;   // Entao conta

        }
        return Q;  // Retorna a quantidade

    }
}