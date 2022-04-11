using static System.Console;

WriteLine("Digite o nome do arquivo:");
var nome = ReadLine();

nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
// Combina caminho de arquivo da pasta atual do arquivo
CriarArquivo(path);

WriteLine("Digite enter para finalizar");
Console.ReadLine();


static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path); // retorna um objeto do tipo StreamWriter
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 2 do arquivo");
        sw.WriteLine("Esta é a linha 3 do arquivo");

        // As linhas estão na memória

        //sw.Flush();
        //As linhas são descarregadas para o arquivo
        //Com a utilização de USING na criação de SW, não é necessário o Flush, pois o .NET faz sozinho
    }

    catch
    {
        WriteLine("O nome do arquivo está inválido.");
    }


}



