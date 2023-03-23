using csharp_exception.Titular;
using csharp_exception.Contas;
using ByteBankEx;
using ByteBank;
using System.Numerics;

/*
try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
    //conta1.Sacar(50);
    //Console.WriteLine(conta1.GetSaldo());
    //conta1.Sacar(150);
    //Console.WriteLine(conta1.GetSaldo());
}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro " + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.StackTrace);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine("Operação negada, saldo insuficiente!");
    Console.WriteLine(e.Message);
}

//ContaCorrente conta2 = new(283, "5464856");
//Console.WriteLine(ContaCorrente.TaxaOperacao);*/
LeitorDeArquivo leitor = new("contaz.txt");

try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch (IOException)
{
    Console.WriteLine("Leitura interrompida!");
}
finally
{
    leitor.Dispose();
}