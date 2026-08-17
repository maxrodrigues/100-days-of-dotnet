using System.Text;
using LogViewerCLI;
using LogViewerCLI.Models;

string logFilePath = "app_test.log";

Console.WriteLine("==========================================");
Console.WriteLine(" 🚀 LogViewer CLI - Day 03 ");
Console.WriteLine("==========================================");

if (!File.Exists(logFilePath))
{
    Console.WriteLine("Execute o código do Dia 02 primeiro para gerar o arquivo de logs!");
    return;
}

using FileStream fileStream = new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
using StreamReader reader = new StreamReader(fileStream, Encoding.UTF8);

string? line;
List<LogEntry> parsedLogs = new();

while ((line = await reader.ReadLineAsync()) != null)
{
    LogEntry entry = LogParser.ParseLine(line);
    parsedLogs.Add(entry);
}

Console.WriteLine($"\nProcessados {parsedLogs.Count} registros de log com sucesso! \n");

foreach (var log in parsedLogs)
{
    Console.WriteLine(LogParser.FormatLogOutput(log));
}

if (parsedLogs.Count > 0)
{
    var firstLog = parsedLogs[0];
    var modifiedLog = firstLog with { Message = "Mensagem alterada mantendo os outros dados intactos!" };
    
    Console.WriteLine("\n--- Teste de imutabilidade com expressão 'with' ---\n");
    Console.WriteLine($"Original: {firstLog.Message}");
    Console.WriteLine($"Modificada: {modifiedLog.Message}");
}