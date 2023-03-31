using System.Collections;

namespace ControleDeEquipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList nomeDoEquipamento = new ArrayList();
            ArrayList precoDeAquisicao = new ArrayList();
            ArrayList nrDeSerie = new ArrayList();
            ArrayList dataDeFabricacao = new ArrayList();
            ArrayList nomeDoFabricante = new ArrayList();
            int escolha;
            int nrDeEquipamentosCadastrados;
            escolha = 20;

            while (escolha != 0)
            {
                Console.WriteLine("Cadastro de Equipamentos:");
                Console.WriteLine("---- Menu -----");
                Console.WriteLine("[1] Cadastrar Item");
                Console.WriteLine("[2] Editar Item");
                Console.WriteLine("[3] Lista de Itens Cadastrados");
                Console.WriteLine("[0] Sair");
                escolha = Convert.ToInt32(Console.ReadLine());



                if (escolha == 1)
                {
                    Console.WriteLine("Quuantos Equipamentos deseja cadastrar?");
                    nrDeEquipamentosCadastrados = Convert.ToInt32(Console.ReadLine());

                    while (nomeDoFabricante.Count < nrDeEquipamentosCadastrados)
                    {

                        Console.WriteLine("Qual o nome do Equipamento?");

                        string equipamento = Console.ReadLine();

                        if (equipamento.Length >= 6)
                        {
                            nomeDoEquipamento.Add(equipamento);
                        }

                        Console.WriteLine("Qual o Preço de Aquisição do Equipamento?");
                        string preco = Console.ReadLine();
                        precoDeAquisicao.Add(preco);

                        Console.WriteLine("Qual o número de série?");
                        string serie = Console.ReadLine();
                        nrDeSerie.Add(serie);

                        Console.WriteLine("Qual a Data de Fabricação");
                        string fabricacao = Console.ReadLine();
                        dataDeFabricacao.Add(fabricacao);

                        Console.WriteLine("Qual o Nome do Fabricante?");
                        string fabricante = Console.ReadLine();
                        nomeDoFabricante.Add(fabricante);
                        Console.ReadKey();
                        Console.Clear();
                    }


                }
                if (escolha == 2)
                {
                    Console.WriteLine("Qual equipamento você deseja editar (Informe o ID)");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Qual o nome do Equipamento?");

                    string equipamento = Console.ReadLine();

                    if (equipamento.Length >= 6)
                    {
                        nomeDoEquipamento[id - 1] = equipamento;
                    }

                    Console.WriteLine("Qual o Preço de Aquisição do Equipamento?");
                    string preco = Console.ReadLine();
                    precoDeAquisicao[id - 1] = preco;

                    Console.WriteLine("Qual o número de série?");
                    string serie = Console.ReadLine();
                    nrDeSerie[id - 1] = serie;

                    Console.WriteLine("Qual a Data de Fabricação");
                    string fabricacao = Console.ReadLine();
                    dataDeFabricacao[id - 1] = fabricacao;

                    Console.WriteLine("Qual o Nome do Fabricante?");
                    string fabricante = Console.ReadLine();
                    nomeDoFabricante[id - 1] = fabricante;

                    Console.Clear();

                }
                if (escolha == 3)
                {
                    for (int i = 0; i < nomeDoFabricante.Count; i++)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine(" | " + nrDeSerie[i] + " | " + nomeDoEquipamento[i] + " | " + precoDeAquisicao[i] + " | " + dataDeFabricacao[i] + " | " + nomeDoFabricante[i] + " | ");
                        Console.WriteLine("------------------------------------------------------------------------");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                if (escolha == 0)
                {
                    Console.WriteLine("Obrigado por utilizar o Cadastro de Equipamentos");
                    Console.ReadKey();
                }


            }
        }
    }
}