Console.WriteLine("==========================================");
Console.WriteLine(" 🚀 LogViewer CLI - Day 01 Started");
Console.WriteLine("==========================================");

if (args.Length > 0)
{
    Console.WriteLine($"\n[ARGUMENTOS RECEBIDOS]: {string.Join(", ", args)}");
}
else
{
    Console.WriteLine($"\n[INFO]: Nenhum argumento fornecido via CLI.");
}

Console.WriteLine("\nAmbiente configurado com sucesso! Pronto para o Dia 02.");