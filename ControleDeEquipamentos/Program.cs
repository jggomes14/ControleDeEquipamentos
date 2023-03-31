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
            ArrayList tituloDoChamado = new ArrayList();
            ArrayList descricaoDoChamado = new ArrayList();
            ArrayList dataDeAbertura = new ArrayList();
            ArrayList numeroDaChamada = new ArrayList();
            ArrayList EquipamentoDaChamada = new ArrayList();
            int count = 5;
            int escolha = 0;
            while (count != 0)
            {
                Console.WriteLine("Estoque de Equipamentos:");
                Console.WriteLine("---- Menu -----");
                Console.WriteLine("[1] Cadastro de Equipamentos");
                Console.WriteLine("[2] Controle de Chamadas");
                Console.WriteLine("[0] Sair");
                count = Convert.ToInt32(Console.ReadLine());

                if (count == 1)
                {
                    Console.Clear();

                    int nrDeEquipamentosCadastrados;
                    escolha = 20;

                    while (escolha != 0)
                    {
                        Console.WriteLine("Cadastro de Equipamentos:");
                        Console.WriteLine("---- Menu -----");
                        Console.WriteLine("[1] Cadastrar Item");
                        Console.WriteLine("[2] Editar Item");
                        Console.WriteLine("[3] Lista de Itens Cadastrados");
                        Console.WriteLine("[4] Remoção de Itens Cadastrados");
                        Console.WriteLine("[0] Voltar ao Menu Principal");
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
                        if (escolha == 4)
                        {
                            int remover;

                            Console.WriteLine("Insira aqui a id do Item que você quer remover");
                            remover = Convert.ToInt32(Console.ReadLine());
                            nomeDoEquipamento.RemoveAt(remover - 1);
                            precoDeAquisicao.RemoveAt(remover - 1);
                            nomeDoFabricante.RemoveAt(remover - 1);
                            dataDeFabricacao.RemoveAt(remover - 1);
                            nrDeSerie.RemoveAt(remover - 1);
                            Console.Clear();
                            Console.WriteLine("Item removido!");
                            Console.Clear();
                            Console.ReadKey();


                        }
                            if (escolha == 0)
                        {
                            Console.WriteLine("Você retornou ao Menu Principal.");
                            Console.ReadKey();
                            Console.Clear();
                        }


                    }
                }
                if (count == 2)
                {
                    Console.Clear();

                    int nrDeChamadasCadastrados;
                    escolha = 20;

                    while (escolha != 0)
                    {
                        Console.WriteLine("Cadastro de Equipamentos:");
                        Console.WriteLine("---- Menu -----");
                        Console.WriteLine("[1] Registro de Chamados");
                        Console.WriteLine("[2] Editar Chamado");
                        Console.WriteLine("[3] Lista de Chamados");
                        Console.WriteLine("[0] Voltar ao Menu Principal");
                        escolha = Convert.ToInt32(Console.ReadLine());
                        if (escolha == 1)
                        {
                            Console.WriteLine("Quantas Chamadas deseja cadastrar?");
                            nrDeChamadasCadastrados = Convert.ToInt32(Console.ReadLine());

                            while (dataDeAbertura.Count < nrDeChamadasCadastrados)
                            {
                                Console.WriteLine("Para qual equipamento você deseja registrar um chamado? (Informe o ID)");
                                int id = Convert.ToInt32(Console.ReadLine());
                                EquipamentoDaChamada.Add(nomeDoEquipamento[id - 1]);



                                Console.WriteLine("Qual o titulo do Chamado?");
                                string titulo = Console.ReadLine();
                                tituloDoChamado.Add(titulo);
                                

                                Console.WriteLine("Insira a descrição do Chamado:");
                                string chamado = Console.ReadLine();
                                descricaoDoChamado.Add(chamado);

                                Console.WriteLine("Qual o número do Chamado?");
                                string chamada = Console.ReadLine();
                                numeroDaChamada.Add(chamada);

                                Console.WriteLine("Qual a Data de Abertura desse Chamado?");
                                string abertura = Console.ReadLine();
                                dataDeAbertura.Add(abertura);


                                Console.ReadKey();
                                Console.Clear();
                            }


                        }
                        if (escolha == 2)
                        {
                            Console.WriteLine("Qual chamado você deseja editar (Informe o ID)");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Para qual equipamento você deseja registrar um chamado? (Informe o ID)");
                            int id = Convert.ToInt32(Console.ReadLine());
                            EquipamentoDaChamada[id2 - 1] = nomeDoEquipamento[id - 1];

                            Console.WriteLine("Qual o titulo do Chamado?");
                            string titulo = Console.ReadLine();
                            tituloDoChamado[id2 - 1] = titulo;
                            

                            Console.WriteLine("Insira a descrição do Chamado:");
                            string chamado = Console.ReadLine();
                            descricaoDoChamado[id2 - 1] = chamado;

                            Console.WriteLine("Qual o número do Chamado?");
                            string chamada = Console.ReadLine();
                            numeroDaChamada[id2 - 1] = chamada;

                            Console.WriteLine("Qual a Data de Abertura desse Chamado?");
                            string abertura = Console.ReadLine();
                            dataDeAbertura[id2 - 1] = abertura;

                            Console.Clear();

                        }
                        if (escolha == 3)
                        {
                            for (int i = 0; i < nomeDoFabricante.Count; i++)
                            {
                                Console.WriteLine("------------------------------------------------------------------------");
                                Console.WriteLine(" | " + numeroDaChamada[i] + " | " + tituloDoChamado[i] + " | " + descricaoDoChamado[i] + " | " + dataDeAbertura[i] + " | " + EquipamentoDaChamada[i] + " | ");
                                Console.WriteLine("------------------------------------------------------------------------");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (escolha == 4)
                        {
                            int remover;

                            Console.WriteLine("Insira aqui qual Chamado você quer remover");
                            remover = Convert.ToInt32(Console.ReadLine());
                            numeroDaChamada.RemoveAt(remover - 1);
                            tituloDoChamado.RemoveAt(remover - 1);
                            descricaoDoChamado.RemoveAt(remover - 1);
                            dataDeAbertura.RemoveAt(remover - 1);
                            EquipamentoDaChamada.RemoveAt(remover - 1);
                            Console.Clear();
                            Console.WriteLine("Chamado removido!");
                            Console.Clear();
                            Console.ReadKey();



                        }
                        if (escolha == 0)
                        {
                            Console.WriteLine("Você retornou ao Menu Principal.");
                            Console.ReadKey();
                            Console.Clear();
                        }




                    }
                }
                if (count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Obrigado por Utilizar nosso Estoque de Equipamentos!");
                    
                }
            }
        }
    }
}