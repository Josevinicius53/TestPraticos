// See https://aka.ms/new-console-template for more information


using PoupaDev;

var account = new BankAccount("José Vinicius", 1000);
Console.WriteLine($"A conta {account.Number} foi criado para { account.Owner} com {account.Balance}$ de saldo inicial.");

account.MakeWithdrawal(500, DateTime.Now, "Pagamento de aluguel");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Amigo me pagou");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

// Teste para um saldo negativo.
try
{
    account.MakeWithdrawal(750, DateTime.Now, "Tentativa de saque em excesso");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exceção capturada tentando saque em excesso");
    Console.WriteLine(e.ToString());
}

// Teste se os saldos iniciais devem ser positivos.
try
{
  var  invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exceção capturada ao criar conta com saldo negativo");
    Console.WriteLine(e.ToString());
    return;
}