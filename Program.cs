
using System;

class Program
{
    static void Main(string[] args)
    {
        char[] chaves = { 'A', 'B' };
        int tamanho = 10;
        int[] sequencia = new int[tamanho];
        int posicao = 0;
        
        // Gera todas as sequências possíveis de 0 a 1 para cada posição das chaves
        GerarSequencias(chaves, sequencia, posicao, tamanho);
        
        Console.ReadKey();
    }
    
    static void GerarSequencias(char[] chaves, int[] sequencia, int posicao, int tamanho)
    {
        if (posicao == tamanho)
        {
            // Verifica se a sequência atual é a correta
            if (SequenciaCorreta(sequencia))
            {
                ImprimirSequencia(sequencia);
            }
            return;
        }
        
        // Gera todas as combinações de 0 a 1 para a posição atual
        for (int i = 0; i < chaves.Length; i++)
        {
            sequencia[posicao] = i;
            GerarSequencias(chaves, sequencia, posicao + 1, tamanho);
        }
    }
    
    static bool SequenciaCorreta(int[] sequencia)
    {
        int[] sequenciaCorreta = { 0, 1, 0, 0, 1, 1, 0, 1, 0, 1 };
        
        // Verifica se a sequência atual é igual à sequência correta
        for (int i = 0; i < sequencia.Length; i++)
        {
            if (sequencia[i] != sequenciaCorreta[i])
            {
                return false;
            }
        }
        
        return true;
    }
    
    static void ImprimirSequencia(int[] sequencia)
    {
        Console.Write("Sequência correta encontrada: ");
        for (int i = 0; i < sequencia.Length; i++)
        {
            Console.Write((sequencia[i] == 0) ? "A" : "B");
        }
        Console.WriteLine();
        Console.WriteLine("Posição: " + (sequencia.Length + 1));
        Console.WriteLine();
    }
}
