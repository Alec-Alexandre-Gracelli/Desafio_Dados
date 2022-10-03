using System;

namespace Desafio_Dados;

public class Program
{
    static void Main(string[] args)
    {
        ComPeso();
    }

    static void SemPeso()
    {
        Console.WriteLine("Digite o tamanho da lista: ");
        var tamanho = int.Parse(Console.ReadLine());
        Random aleatorio = new Random();
        int[] listaAleatoria = new int[tamanho];
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

    static void ComPeso()
    {
        Console.WriteLine("Digite o tamanho da lista: ");
        var tamanho = int.Parse(Console.ReadLine());
        Random aleatorio = new Random();
        decimal valorFace1 = 0;
        decimal valorFace2 = 0;
        decimal valorFace3 = 0;
        decimal valorFace4 = 0;
        decimal valorFace5 = 0;
        decimal valorFace6 = 0;
        decimal resultado1;
        decimal resultado2;
        decimal resultado3;
        decimal resultado4;
        decimal resultado5;
        decimal resultado6;

        for (int i = 1; i < tamanho; i++)
        {
            var valorFaceDado = aleatorio.Next(1, 100);
            if (valorFaceDado >= 1 && valorFaceDado < 13)
            {
                valorFace1++;
            }
            else if(valorFaceDado >= 13 && valorFaceDado < 26)
            {
                valorFace2++;
            }
            else if(valorFaceDado >= 26 && valorFaceDado < 39)
            {
                valorFace3++;
            }
            else if(valorFaceDado >= 39 && valorFaceDado < 52)
            {
                valorFace4++;
            }
            else if(valorFaceDado >= 52 && valorFaceDado < 65)
            {
                valorFace5++;
            }
            else
            {
                valorFace6++;
            }

        }

        resultado1 = (valorFace1 / tamanho) * 100;
        resultado2 = (valorFace2 / tamanho) * 100;
        resultado3 = (valorFace3 / tamanho) * 100;
        resultado4 = (valorFace4 / tamanho) * 100;
        resultado5 = (valorFace5 / tamanho) * 100;
        resultado6 = (valorFace6 / tamanho) * 100;

        Console.WriteLine($"Porcentagem das faces de cada dado: \n" +
            $"Valor da Face 1 = {resultado1.ToString("F")} % \n" +
            $"Valor da Face 2 = {resultado2.ToString("F")} % \n" +
            $"Valor da Face 3 = {resultado3.ToString("F")} % \n" +
            $"Valor da Face 4 = {resultado4.ToString("F")} % \n" +
            $"Valor da Face 5 = {resultado5.ToString("F")} % \n" +
            $"Valor da Face 6 = {resultado6.ToString("F")} % \n");


    }
}

