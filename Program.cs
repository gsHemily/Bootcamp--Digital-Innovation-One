using System;
using System.Collections.Generic;

namespace BankDio
{
    class Program
    {
        static List<ContaBancaria> listaContas = new List<ContaBancaria>();
        static void Main(string[] args)
        {
            string OpcaoUsuario = ObterOpcaoUsuario();

            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                                                              
                    default: throw new ArgumentOutOfRangeException();

                }

                OpcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine();
            Console.WriteLine("Obrigado por usar nossos serviços!");
        }
        private static void Transferir()
        {
            Console.Write("Digite o numero da conta origem: ");
            int indiceContaOrigem  = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser tranferido: ");
            double valorTranferencia = double.Parse(Console.ReadLine());

            listaContas[indiceContaOrigem].Transferir(valorTranferencia, listaContas[indiceContaDestino]);

        }
        private static  void Sacar()
        {
            Console.Write("Digite o numero da sua conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorSaque);
        }

        private static void Depositar ()
        {
            Console.Write("Digite o numero da sua conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorDeposito);

        }
        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta:");
            Console.Write("Digite 1 para conta Fisica ou 2 para conta juridica:");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Titular:");
            string entradaName = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial:");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o credito:");
            double entradaCredito = double.Parse(Console.ReadLine());

            ContaBancaria novaConta = new ContaBancaria(tipoConta: (TipoConta)entradaTipoConta,
                                                                              saldo: entradaSaldo,
                                                                              credito: entradaCredito,
                                                                              name: entradaName);

            listaContas.Add(novaConta);
        }
        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");
            if (listaContas.Count == 0) 
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
            for (int i = 0; 1 < listaContas.Count; i++)
            {
                ContaBancaria conta = listaContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }

        }        


    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("Informe a opção desejada?");
        Console.WriteLine("1- Listar contas");
        Console.WriteLine("2- Inserir nova conta:");
        Console.WriteLine("3- transferir:");
        Console.WriteLine("4- Sacar: ");
        Console.WriteLine("5- Deposito: ");
        Console.WriteLine("C - Limpar Tudo");
        Console.WriteLine("X - Sair");
            Console.WriteLine();

        string OpcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return OpcaoUsuario;
    }
}


    
}
