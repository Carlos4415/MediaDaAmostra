﻿double[] dados = { 0.1, 1.1, 2.1, 3.1 };
double media = 0;

double MediaDaAmostra(double[] amostra)
{
    double media = 0;
    double acumulador = 0;

    if (amostra == null || amostra.Length == 0)
    {
        Console.WriteLine("Amostra de dados nula ou vazia.");
        return 0;
    }
    else
    {
        for (int i = 0; i < amostra.Length; i++)
        {
            acumulador = acumulador + amostra[i];
        }

        media = acumulador / amostra.Length;
    }

    return media;
}

media = MediaDaAmostra(dados);

Console.WriteLine("Média da amostra: " + media);
