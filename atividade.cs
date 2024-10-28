using System;

namespace Aula_4
{
    class Atividade
    {
        static void Main (string[] args)
        {

            System.Console.WriteLine("Digite o valor a investir");
            double valor = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite o tipo investimento (poupanca, renda fixa ou acoes)");
            string invest = System.Console.ReadLine();

            System.Console.WriteLine("Por quantos anos deseja investir?");
            int anos = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"{valor}, {invest}, {anos}");
            double rentabilidade = valor;
            double possivelPerda = valor;
            string perda = "";

            switch (invest)
            {
                case "poupanca":
                for(int i = 0; i < anos; i++)
                {
                rentabilidade = rentabilidade + (rentabilidade * 0.03);
                }
                break;
                case "renda fixa":
                for(int i = 0; i < anos; i++)
                {
                rentabilidade = rentabilidade + (rentabilidade * 0.05);
                }
                break;
                case "acoes":
                for(int i = 0; i < anos; i++)
                {
                rentabilidade = rentabilidade + (rentabilidade * 0.10);
                possivelPerda = possivelPerda - (possivelPerda * 0.05);
                }
                break;
            }
        
            
            if(invest == "acoes"){
                System.Console.WriteLine($"Com um rendimento de 10% ao ano, investindo em ações seu patrimonio chearia até: {rentabilidade}");
                System.Console.WriteLine($"Seu patrimonio pode sofrer uma perda de 5% ao ano, podendo chegar até: {possivelPerda}");
            }
            else if(invest == "poupaca") {
                System.Console.WriteLine($"Com um rendimento de 03% ao ano, investindo na poupança seu patrimonio chearia até: {rentabilidade}");
            }
            else if(invest == "renda fixa") {
                System.Console.WriteLine($"Com um rendimento de 05% ao ano, investindo na renda fixa seu patrimonio chearia até: {rentabilidade}");
            }
            
              
        } 
    }
}