using System;

namespace Desafio_Dados;

public class Program
{
    static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int[] listaAleatoria = new int[30000];
        int[] listaAuxiliar = new int[6];
        int repetido = 0;
        float valorFace;
        float resultado;

        for (int i = 0; i < listaAleatoria.Length; i++)
        {
            var valorFaceDado = aleatorio.Next(1, 7);
            listaAleatoria[i] = valorFaceDado;
        }

        for (int j = 0; j < listaAleatoria.Length; j++)
        {
            repetido = listaAleatoria[j] - 1;
            listaAuxiliar[repetido] += 1;
        }

        for (int k = 0; k < listaAuxiliar.Length; k++)
        {
            valorFace = listaAuxiliar[k];
            resultado = valorFace / listaAleatoria.Length * 100;
            Console.WriteLine("Face {0}: {1} ", k + 1, resultado + "%");
        }
    }
}
