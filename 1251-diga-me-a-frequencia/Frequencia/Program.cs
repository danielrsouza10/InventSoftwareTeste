﻿using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

class URI
{

    static void Main(string[] args)
    { 
        string userInput = Console.ReadLine();

        //Cria una lista de dicionarios para armazenar os dicionarios criados
        List<Dictionary<int, int>> listaDeDicionarios = new List<Dictionary<int, int>>();

        while (!string.IsNullOrEmpty(userInput))
        {
            //Divide o inputado pelo usuario em um array de caracteres
            char[] caracteres = userInput.ToCharArray();

            //instancia um dicionario para armazenar os caracteres
            Dictionary<int, int> dicionario = new Dictionary<int, int>();

            foreach (char caracter in caracteres)
            {
                int ascii = Convert.ToChar(caracter);

                //o problema pede que só sejam incluidos os caracteres nesse intervalo da tabela ASCII
                if (ascii > 32 && ascii <= 128)
                {
                    //para cada caracter do array, verifica se ele esta presente no dicionario e adiciona ou aumenta a frequencia
                    if (!dicionario.ContainsKey(ascii))
                    {
                        dicionario.Add(ascii, 1);
                    }
                    else
                    {
                        dicionario[ascii]++;
                    }
                }
            }
            listaDeDicionarios.Add(dicionario);
            userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput)) {
                //variavel de controle para pular linha
                int i = listaDeDicionarios.Capacity - 2;
                //itera sobre a lista de dicionarios para printar cada dicionario
                foreach (var item in listaDeDicionarios)
                {
                    //Cria uma variavel para ordenar o Dicionario de acordo com os values presentes
                    var sortedDictionary = item.OrderBy(entry => entry.Value).ThenByDescending(entry => item.Keys.ToList().IndexOf(entry.Key));

                    //printa o dicionario no console
                    foreach (KeyValuePair<int, int> valor in sortedDictionary)
                    {
                        Console.WriteLine(valor.Key + " " + valor.Value);
                        
                    }

                    i--;
                    if (i > 0)
                    {
                        Console.WriteLine();
                    }
                    
                }
            };
        } 
    }
}