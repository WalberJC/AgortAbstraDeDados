using System;

// CÓDIGO - VETORES

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

    }} */

// ==========================================================================================

// CODIGO - MATRIZES

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
}} */

// ===========================================================================================

// CHAMA FUNÇÃO SOMA 

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

}}*/

// ============================================================================================

// MAIOR VETOR - MENOR VETOR - MEDIA

/* class Program
    {
        static void Main()
        {
            int[] Vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i + 1} do Vetor: ");
                Vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            
            Console.WriteLine($"O Maior Valor do Vetor é {AchaMaior(Vetor)}");
            Console.WriteLine($"O Menor Valor do Vetor é {AchaMenor(Vetor)}");
            Console.WriteLine($"Existem {ContaPares(Vetor)} elementos Pares no Vetor");
            Console.WriteLine($"Existem {ContaÍmpares(Vetor)} elementos Ímpares no Vetor");
            Console.WriteLine($"A Média Aritmética dos elementos do vetor é {AchaMédia(Vetor):F2}");
            Console.ReadKey();
        }
        static int AchaMaior(int[] V)
        {
            int Maior = V[0];
            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] > Maior)
                    Maior = V[i];
            }
            return Maior;
        }
        static int AchaMenor(int[] V)
        {
            int Menor = V[0];
            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] < Menor)
                    Menor = V[i];
            }
            return Menor;
        }
        static int ContaPares(int[] V)
        {
            int Pares = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 == 0)
                    Pares++;
            }
            return Pares;
        }
        static int ContaÍmpares(int[] V)
        {
            int Ímpares = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 != 0)
                    Ímpares++;
            }
            return Ímpares;
        }
        static double AchaMédia(int[] V)
        {
            int Soma=0;
            double Média;
            for (int i = 0; i < V.Length; i++)
            {
                Soma += V[i];
            }
            return (double)Soma / V.Length;
        }} */

        //================================================================================

// PROFESSOR - NOTA ALUMO

/* class Program {
static void Main (string[] args){
 int i, j, Soma = 0;
 double Media;
    
string[] Aluno = new string[5];
int [,] Matriz = new int [5, 3];    

for(i = 0; i < 5; i++){ 

  Console.Write($"Digite o {i + 1}º nome: ");
  Aluno[i] = Console.ReadLine();

   for(j = 0; j < 3; j++){     

     Console.Write($"Aluno {Aluno[i]} e sua nota da {j + 1}º prova: ");
     Matriz[i, j] = int.Parse(Console.ReadLine());   

    }       
    } 
    
    for(i = 0; i < 5; i++){
        Soma = 0;
        for (j = 0; j < 3; j++ ){
            Soma += Matriz[i, j];
        }
        Console.WriteLine($"A soma das provas aluno {Aluno[i]} é {Soma}");
    }

    
    for(i = 0; i < 3; i++){
        Soma = 0;
        for(j = 0; j < 5; j++){
        Soma += Matriz [j, i];
        }
        Media = Soma / 5;
        Console.WriteLine($"A média da {i + 1}º prova é: {Media}");
    }

}} */

//==================================================================================

// PROFESSOR - MATRICULA - DISCIPLINA - 

/* namespace WorkBJA{
    struct Professor
    {
        public string Matricula;
        public string Nome;
        public Disciplina DadosDisciplina;
    }

    struct Disciplina
    {
        public string NomeDisciplina;
        public int CargaHoraria;
    }

    class Program
    {
        static void Main (string[] args)
        {
            Professor[] xProf = new Professor[3];

            for(int i = 0; i < 3; i++)
            {
                Console.Write("\nMatricula do Professor: ");
                xProf[i].Matricula = Console.ReadLine();

                Console.Write("Nome............: ");
                xProf[i].Nome = Console.ReadLine();

                Console.Write("Disciplina......: ");
                xProf[i].DadosDisciplina.NomeDisciplina = Console.ReadLine();

                Console.Write("Carga Horária....: ");
                xProf[i].DadosDisciplina.CargaHoraria = int.Parse(Console.ReadLine());
            }

            ListarTudo(xProf);

            string Nome;
            bool Achou;

           Console.Write("\n Digite o Nome de um professor: ");

           Nome = Console.ReadLine();
           Achou = ListaProf(xProf, Nome);

           if(!Achou);
           {
            Console.Write("Professor nao existe no cadastro: ");
           }

           Console.ReadKey();

        }

        static void ListarTudo(Professor[] P)
        {
            Console.Clear();

            foreach(Professor x in P)
            {
                Console.WriteLine($"\n{x.Nome} - ({x.Matricula})");
                Console.WriteLine($"Disciplina: {x.DadosDisciplina.NomeDisciplina}");
                Console.WriteLine($"CH: {x.DadosDisciplina.CargaHoraria} Horas");
            }

            Console.ReadKey();

        }

        static bool ListaProf(Professor[] P, string Nome)
        {
            Console.Clear();

            bool Achou=false;

            foreach (Professor x in P)
            {
                if (x.Nome == Nome)
                {
                    Console.WriteLine($"\n{x.Nome} - ({x.Matricula})");
                    Console.WriteLine($"Disciplina: {x.DadosDisciplina.NomeDisciplina}");
                    Console.WriteLine($"CH:{x.DadosDisciplina.CargaHoraria} Horas");

                    Achou = true;
                }
            }

            return Achou;
        }

    }} */

    // +===============================================================================

// VEICULO - MARCA - PLACA - TABELA FIP

/* namespace WorkBJA
{
    class Veiculo   // Classe de Tipo
    {
        public string Nome;
        public string Marca;
        public string AnoFab;
        public string Placa;
        public double PrecoFIP;
    }         

    class Program
    {
        static void Main (string[] args)
        {
            // Vetor para "armazernar" Veiculos....
            Veiculo[] CadVeiculo = new Veiculo[3];
            {
                for (int i = 0; i < 3; i++)
                {
                    Veiculo x = new Veiculo();

                    Console.Write($"Nome do Veiculo {i + 1}....: ");
                    x.Nome = Console.ReadLine();

                    Console.Write("Marca.......: ");
                    x.Marca = Console.ReadLine();

                    Console.Write("Ano de Fabricação.....: ");
                    x.AnoFab = Console.ReadLine();

                    Console.Write("Placa......: ");
                    x.Placa = Console.ReadLine();

                    Console.Write("Preço FIP (R$).....: ");
                    x.PrecoFIP = double.Parse(Console.ReadLine());

                    // Vamos colocar o objeto x no Vetor, posição i...
                    CadVeiculo[i] = x;   // Cadastrou
                }

                Console.Clear();

                // Mostrando todos os Veiculos cadastrados...

                foreach (Veiculo V in CadVeiculo)
                {
                    Console.WriteLine($"\n {V.Nome} - Ano: {V.AnoFab}");
                    Console.WriteLine($"Marca: {V.Marca}");
                    Console.WriteLine($"Placa: {V.Placa}");
                    Console.WriteLine($"Preço - Tabela FIP - R$ {V.PrecoFIP:F2}");
                }

                Console.ReadKey();

            }
        }
    }} */

    // ========================================================================================

    // CALCULO DO 2 GRAU (reavaliar erro que não aparece o valor da segunda raiz)

/*namespace WorkBJA
{
  class Eq2Grau         // Classe para  trabalhar com uma equeção do 2o Grau 
  {
     private double _a;

     public double a
     {
        get { return _a; }
        set { _a = value; }
     }

     private double _b;

     public double b
     {
        get { return _b; }
        set { _b = value; }
     }

     private double _c;

     public double c
     {
        get { return _c; }
        set { _c = value; }
     }

     private double _Delta;
     public double Delta
     
     {
        get { return _Delta; }
        //set { _Delta = value; }
     }

     private double _Raiz1;

     public double Raiz1
     {
        get { return _Raiz1; }
        //set { _Raiz1 = value}
     }

     private double _Raiz2;
     public double Raiz2
     {
        get { return Raiz2; }
        //set { Raiz2 = value; }
     }

     public void CalcDelta()
     {
        _Delta = Math.Pow (b, 2) - 4 * a * c;
     }

     public void CalcRaizes()
     {
        _Raiz1 = (-b + Math.Sqrt(Delta)) / (2 * a);
        _Raiz2 = (-b - Math.Sqrt(Delta)) / (2 * a);
     }
  }       

  class Program
  {
    static void Main (string[] args)
    {
        Eq2Grau Equacao = new Eq2Grau();

        Console.Write("a = ");
        Equacao.a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        Equacao.b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        Equacao.c = double.Parse(Console.ReadLine());

        Equacao.CalcDelta();   // Calcula o Delta

        Console.Write($"\nDelta = {Equacao.Delta:F2}\n");

        if (Equacao.Delta >= 0)
        {
            Equacao.CalcRaizes();   //Calcula as Raizes...

            Console.WriteLine($"Raiz 1 = {Equacao.Raiz1:F2}");
            Console.WriteLine($"Raiz 2 = {Equacao.Raiz2:F2}");
        }
        else
        {
            Console.WriteLine("A Equação não possui Raizes Reis!");
        }
    }
  }}*/

  //=======================================================================================