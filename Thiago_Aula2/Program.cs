string caminhoArquivo = "dados.txt";

Console.WriteLine("=== EXEMPLO DE PERSISTÊNCIA DE DADOS ===");

PersistenciaDados persistencia = new PersistenciaDados();

persistencia.CaminhoArquivo = "Thiago_Aula2.txt";

while (true)
{
    Console.WriteLine("\n1 - Adicionar nome");
    Console.WriteLine("2 - Listar nomes");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            AdicionarNome(caminhoArquivo);
            break;
        case "2":
            ListarNomes(caminhoArquivo);
            break;
        case "0":
            Console.WriteLine("Encerrando o programa.");
            return;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
