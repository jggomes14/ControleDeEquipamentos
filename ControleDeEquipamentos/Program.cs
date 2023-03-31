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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("┌───────────────────────────────┐");
                Console.WriteLine("│      Estoque de Equipamentos  │");
                Console.WriteLine("├─────────────────────┬─────────┤");
                Console.WriteLine("│       Opções        │ Teclas  │");
                Console.WriteLine("├─────────────────────┼─────────┤");
                Console.WriteLine("│ 1. Cadastro de      │    1    │");
                Console.WriteLine("│    Equipamentos     │         │");
                Console.WriteLine("├─────────────────────┼─────────┤");
                Console.WriteLine("│ 2. Controle de      │    2    │");
                Console.WriteLine("│    Chamadas         │         │");
                Console.WriteLine("├─────────────────────┼─────────┤");
                Console.WriteLine("│ 0. Sair             │    0    │");
                Console.WriteLine("└─────────────────────┴─────────┘");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                count = Convert.ToInt32(Console.ReadLine());

                if (count == 1)
                {
                    Console.Clear();

                    int nrDeEquipamentosCadastrados;
                    escolha = 20;

                    while (escolha != 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("┌───────────────────────────────┐");
                        Console.WriteLine("│      Cadastro de Equipamentos |");
                        Console.WriteLine("├─────────────────────┬─────────┤");
                        Console.WriteLine("│       Opções        │ Teclas  │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 1. Cadastrar Item   │    1    │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 2. Editar Item      │    2    │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 3. Lista de Itens   │    3    │");
                        Console.WriteLine("│    Cadastrados      │         │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 4. Remover Item     │    4    │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 0. Voltar ao Menu   │    0    │");
                        Console.WriteLine("│    Principal        │         │");
                        Console.WriteLine("└─────────────────────┴─────────┘");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("Escolha uma opção: ");
                        escolha = Convert.ToInt32(Console.ReadLine());



                        if (escolha == 1)
                        {
                            Console.WriteLine("Quantos Equipamentos deseja cadastrar?");
                            nrDeEquipamentosCadastrados = Convert.ToInt32(Console.ReadLine());

                            while (nomeDoFabricante.Count < nrDeEquipamentosCadastrados)
                            {
                                Console.WriteLine("Qual o nome do Equipamento?");
                                string equipamento = Console.ReadLine();

                                if (equipamento.Length < 6)
                                {
                                    Console.WriteLine("Não é possível cadastrar o Equipamento com menos de 6 letras. Favor preencher novamente.");
                                    continue;
                                }

                                nomeDoEquipamento.Add(equipamento);

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

                            if (equipamento.Length < 6)
                            {
                                Console.WriteLine("Não é possível cadastrar o Equipamento com menos de 6 letras. Favor preencher novamente.");
                                equipamento = Console.ReadLine(); 
                            }

                            nomeDoEquipamento[id - 1] = equipamento;
                        


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
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Lista de Equipamentos:");
                            Console.WriteLine("------------------------------------------------------------------------------------------------");
                            Console.WriteLine("| Nr de Série |    Nome do Equipamento    | Preço | Fabricante |       Data de Fabricação        |");
                            Console.WriteLine("------------------------------------------------------------------------------------------------");
                            for (int i = 0; i < dataDeFabricacao.Count; i++)
                            {
                                Console.WriteLine("| {0,-11} | {1,-25} | {2,-5} | {3,-10} | {4,-30} |", nrDeSerie[i], nomeDoEquipamento[i], precoDeAquisicao[i], nomeDoFabricante[i], dataDeFabricacao[i]);
                            }
                            Console.WriteLine("------------------------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            Console.ResetColor();

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
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("┌───────────────────────────────┐");
                        Console.WriteLine("│      Cadastro de Equipamentos │");
                        Console.WriteLine("├─────────────────────┬─────────┤");
                        Console.WriteLine("│       Opções        │ Teclas  │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 1. Registro de      │    1    │");
                        Console.WriteLine("│    Chamados         │         │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 2. Editar Chamado   │    2    │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 3. Lista de Chamados│    3    │");
                        Console.WriteLine("├─────────────────────┼─────────┤");
                        Console.WriteLine("│ 0. Voltar ao Menu   │    0    │");
                        Console.WriteLine("│    Principal        │         │");
                        Console.WriteLine("└─────────────────────┴─────────┘");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("Escolha uma opção: ");
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
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Lista de Chamados:");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("| Nr Chamado |             Título do Chamado             |                Descrição do Chamado               |   Data de Abertura  |   Equipamento da Chamada   |");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            for (int i = 0; i < EquipamentoDaChamada.Count; i++)
                            {
                                Console.WriteLine("| {0,-10} | {1,-40} | {2,-48} | {3,-20} | {4,-27} |", numeroDaChamada[i], tituloDoChamado[i], descricaoDoChamado[i], dataDeAbertura[i], EquipamentoDaChamada[i]);
                            }
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            Console.ResetColor();

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