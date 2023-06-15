using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade05_Maquina_Cafe
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            
            double valor, valor_cafe;
            int opcao;
            string cafe;

            Console.WriteLine("============================\nBem Vindo ao Conradobucks!\n============================\nPara continuar, insira um valor: R$ ");
            valor = double.Parse(Console.ReadLine());
            if (valor <= 0 )
            {

                Console.WriteLine("Valor insuficiente.");
                Console.ReadLine();
                Console.Clear();
                Main(args);
                return;

            }
            Console.WriteLine("\n============Bebidas disponíveis: ");
            Console.WriteLine("1- Café Expresso - R$ 3,00");
            Console.WriteLine("2- Capuccino - R$ 4,50");
            Console.WriteLine("3- Mocaccino - R$ 6,00");
            Console.WriteLine("4- Água caliente - R$ 1,00");
            Console.WriteLine("\n Para prosseguir, digite o número referente a sua escolha: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao < 1 || opcao > 4)
            {

                Console.WriteLine("Opção inválida.");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }

            // Switch: apropriado para multiplas condições

            switch (opcao)
            {


                    case 1:
                    valor_cafe = 3.0;
                    cafe = "Café Expresso";
                    break;

                    case 2:
                    valor_cafe = 4.50;
                    cafe = "Capuccino";
                    break;

                    case 3:
                    valor_cafe = 6.00;
                    cafe = "Mocaccino";
                    break;

                    case 4:
                    valor_cafe = 1.00;
                    cafe = "Água caliente";
                    break;

                    default: Console.WriteLine("Escolha, escolha seu cafézinho.");
                    return;

            }

            if (valor < valor_cafe)
            {
                Console.WriteLine("Valor insuficiente.");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;
            }

            double valor_troco = valor - valor_cafe;

            Console.WriteLine($"Compra de {cafe} feita com sucesso!!!");
            Console.WriteLine("======================================");
            Console.WriteLine($"Valor pago: R$ {valor}");
            Console.WriteLine("======================================");
            Console.WriteLine($"Seu troco: R${valor_troco}");
            Console.WriteLine("======================================");
            Console.WriteLine("Obrigado e volte sempre!");
            Console.ReadKey();
            return;            

        }
    }
}
