using System.Text;

string logFilePath = "app_test.log";

Console.WriteLine("==========================================");
Console.WriteLine(" 🚀 LogViewer CLI - Day 02 ");
Console.WriteLine("==========================================");

// 1. Gerando um arquivo de log usando StreamWriter
Console.WriteLine($"\n[1] Gerando arquivo de log em: {logFilePath}...");

using (StreamWriter writer = new StreamWriter(logFilePath, append: false, Encoding.UTF8))
{
    writer.WriteLine("2026-08-10 10:00:01|INFO|Aplicação iniciada com sucesso.");
    writer.WriteLine("2026-08-10 10:02:15|WARN|Memória acima de 70%.");
    writer.WriteLine("2026-08-10 10:05:43|ERROR|Falha ao conectar no Banco de Dados.");
    writer.WriteLine("2026-08-10 10:08:12|INFO|Tentativa de reconexão bem-sucedida.");
    writer.WriteLine("2026-08-10 10:12:00|ERROR|Timeout na requisição HTTP da API externa.");
    writer.WriteLine("2026-08-10 10:15:02|ERROR|Falha na tentativa de retornar o processo à fila.");
}

Console.WriteLine("Arquivo de log gerado!");

Console.WriteLine("\n[2] Lendo e filtrando apenas erros (ERROR) usando StreamReader:\n");

if (File.Exists(logFilePath))
{
    // Criamos o FileStream com acesso de leitura (FileAccess.Read) e modo de abertura
    using FileStream fileStream = new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
    using StreamReader reader = new StreamReader(fileStream, Encoding.UTF8);

    string? currentLine;
    int totalLines = 0;
    int errorCount = 0;

    // Processamento linha por linha sem carregar o arquivo na RAM
    while ((currentLine = await reader.ReadLineAsync()) != null)
    {
        totalLines++;

        // Processamento básico da linha
        if (currentLine.Contains("|ERROR|"))
        {
            errorCount++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[LINHA {totalLines}] {currentLine}");
            Console.ResetColor();
        }
    }

    Console.WriteLine($"\n---------------------------------");
    Console.WriteLine($"Total de linhas processadas: {totalLines}");
    Console.WriteLine($"Total de erros encontrados: {errorCount}");
}
else
{
    Console.WriteLine("Erro: O arquivo de log não foi encontrado.");
}