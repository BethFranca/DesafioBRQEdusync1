﻿using System;

namespace desafioBrq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarações de variáveis
            string nome = ""; // variável do tipo "string" aceita uma sequência de caracteres, exemplo texto.
            string sexo = ""; // 
            int idade = 0; // variavel do tipo "int" guarda valores inteiros.
            double altura = 0;// variável do tipo "double" representa números de ponto flutuante.  
            double peso = 0; 
            string confirmarDado = "";
            
            // nas próximas linhas no bloco da linha 18 á linha 30 utilizei a estrutura de repetição para garantir a que o código dentro do loop seja executado pelo menos uma vez e ou quantas vezes forem necessárias.
            do 
            {
                Console.Write("Digite o seu nome e sobrenome: "); // solicitando ao usuário para digitar nome e sobrenome.
                nome = Console.ReadLine();

                Console.Write("Informe qual é o seu sexo (F/M): ");
                sexo = Console.ReadLine();

                while (sexo.ToLower() != "f" && sexo.ToLower() != "m") // 
                {
                    Console.Write("Informação inválida, digite F ou M: ");
                    sexo = Console.ReadLine();
                }

                

                Console.Write("Digite a sua idade: ");// solicitação ao usuário que digite a sua idade.
                idade = int.Parse(Console.ReadLine());

                while (idade < 1 || idade > 150)
                {
                    Console.Write("Idade incorreta, digite entre 1 a 150 anos: ");// Caso o usuário digite uma idade inesistente ou incorreta, na tela será impresso a segunte mensagem que consta entre parênteses e entre aspas duplas.
                    int.TryParse(Console.ReadLine(), out idade);
                }
                

                Console.Write("Digite a sua altura: ");// solicitação ao usuário que informe a sua altura. O cursor aparece em frente a orientação data pelo código ao usuário.
                double.TryParse(Console.ReadLine(), out altura);

                while (altura < 0.5 || altura > 3.0)// Estrutura de repetição usando While, e utilizando operador lógico da disjunção para efetuar a comparação "OU" entre as condições.
                {
                    Console.Write("Altura incorreta, digite altura entre 0,5 a 3,0 metros: ");
                    double.TryParse(Console.ReadLine(), out altura);
                }

                

                Console.Write("Digite o seu peso: ");
                double.TryParse(Console.ReadLine(), out peso);

                while (peso < 1 || peso > 800)
                {
                    Console.Write("Peso incorreta, digite peso entre 1 a 800 kg: ");
                    double.TryParse(Console.ReadLine(), out peso);

                }

                Console.Write("Deseja confirmar seus dados (S/N)?: ");
                confirmarDado = Console.ReadLine();

                while (confirmarDado.ToLower() != "s" && confirmarDado.ToLower() != "n")
                {
                    Console.Write("Informação errada, digite S ou digite N: ");
                    confirmarDado = Console.ReadLine();
                }
                    
                Console.Clear();// limpa a tela 

            } while (confirmarDado == "n");




            double imc = peso / (altura * altura); // Calculo IMC baseado no peso e na altura  do paciente.      

            string categoria = "";// Identifica a categoria do paciente de acordo com a sua idade. Utilizando estrutura condicional if/else.
            if (idade < 12)
            {
                categoria = "Infantil";
            }
            else if (idade >= 12 && idade <= 20)// utilizando operador lógico &&.   
            {
                categoria = "Juvenil";
            }
            else if (idade > 20 && idade <= 65)
            {
                categoria = "Adulto";

            }
            else
            {
                categoria = "Idoso";
            }

            string risco = ""; // Identifica o risco e a recomendação de acordo com o resultado do calculo IMC do usuário;
            string recomendacoes = ""; 
            //Estrutura condicional if/else é um recurso que indica quais instruções o sistema deve processar.
            if (imc < 20)
            {
                recomendacoes = "Inclua carboidratos simples em sua dieta, além de proteínas indispensáveis para ganho de massa magra. \n Procure um profissional.";
                risco = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
            }
            else if (imc >= 20 && imc < 25)
            {
                recomendacoes = "Mantenha uma dieta saudável e faça seus exames periódicos.";
                risco = "Seu peso está ideal para suas referências.";
            }
            else if (imc >= 25 && imc < 30)
            {
                recomendacoes = "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. \n A ajuda de um profissional pode ser interessante";
                risco = "Aumento de peso apresenta risco moderado para outras doença crônicas e cardiovasculares.";
            }
            else if (imc >= 30 && imc < 35)
            {
                recomendacoes = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino).";
                risco = "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.";
            }
            else 
            {
                recomendacoes = "Procure com urgência o acompanhamento de um nutricionista \n para realizar reeducação alimentar, um psicólogo e um médico especialista(endócrino).";
                risco = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
            }
            // Exibição do relatório do diagnóstico prévio do paciente.
            Console.WriteLine("\n\tDIAGNÓSTICO PRÉVIO");
            Console.WriteLine($"\nNome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura:0.00}");
            Console.WriteLine($"Peso: {peso:0.00}");                  
            Console.WriteLine($"\nCategoria: {categoria}");
            Console.WriteLine("\n\nIMC Desejável: entre 20 e 24");
            Console.WriteLine($"\n\nResultado IMC: {imc:0.00}");
            Console.WriteLine($"\n\nRiscos: {risco}");
            Console.WriteLine($"\n\nRecomendação inicial: {recomendacoes}");



        }
    }
}
