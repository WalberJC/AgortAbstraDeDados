using System;

// CÓDIGO DO VIDEO 1

/*class Program {
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
} */



/* class Program {
static void Main (string[] args){
    // Exemplo de Matriz

    //      5  8  3  2  9
    //      9  0  1  4  2
    //      7  8  1  2  0
    //      6  2  6  9  1
    //      3  9  7  2  2

    // Diagonal Principal da Matriz: 5 0 1 9 2

    int [,] Matriz = new int [5, 5];          // Declaração da Matriz
    int [] VetorResultante = new int [5];     // Declaração do Vetor Resultante

    for(int i = 0; i < 5; i++){        //Para cada linha da Matriz
    for(int j = 0; j < 5; j++){        //Para cada coluna da Matriz
         Console.Write($"Elemento ({i + 1}, {j + 1}): ");

         Matriz[i, j] = int.Parse(Console.ReadLine());   //Lê o valor do elemento
    }       
    }     

    // Chama a Função
    // Envia a Matriz e recebe como resultado um vetor

    VetorResultante = ExtraiDiagPrinc(Matriz);

    // Agora é so mostrar...
 
    Console.Write("\n\n Diagonal Principal: ");

    for(int i = 0; i < 5; i++){   //Para cada coluna da Matriz
        Console.Write($"{VetorResultante[i], 7}");
    }        

    Console.WriteLine("\n");

    Console.ReadKey();

    static int[] ExtraiDiagPrinc (int[,] M){
           int[] Result = new int[5];

           for (int i = 0; i < 5; i++){            // Para cada linha da Matriz
            for (int j = 0; j < 5; j++){           // Para cada coluna da Matriz
                if (i ==j)                        //Estamos da diagonal principal? 
                    Result[i] = M[i, j];          //Alimentamos o Vetor
            }
           }
          
        //Retornamos

         return Result;
    }
}
} */

/*class Program {

static void procSoma(int a, int b){
    int S;
    S = a + b;
    Console.WriteLine($"A soma entre {a} e {b} = {S}");
}

static int funcSoma(int a, int b){
    int S;
    S = a + b;
    return S;
}

public static void Main (string[] args){
    int v1 = 12, v2 = 6;

    procSoma(v1, v2);

    Console.WriteLine($"{v1} + {v2} = {funcSoma(v1, v2)}");

}
}*/

class Program {  
  public static void Main (string[] args) {
    //  DECLARACAO DE VARIAVEIS
    int fruta = 0;
    
    // ENTRADA DE DADOS
    Console.Write("Digite a opção da sua fruta favorita ");
    Console.Write("1 - Abacaxi ");
    Console.Write("2 - Banana ");
    Console.Write("3 - Laranja ");
    Console.Write("4 - Maça ");
    Console.Write("5 - Uva ");
    fruta = int.Parse(Console.ReadLine());
    
    // IMPRIMINDO O RESULTADO
    Console.WriteLine("A fruta favorita digitada foi {0}", fruta);    
  }
}