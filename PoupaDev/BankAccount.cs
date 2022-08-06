using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoupaDev
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;

        // As três primeiras são propriedades. Propriedades são elementos de dados
        // que podem ter um código que impõe a validação ou outras regras.
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        //construtores que atribua esses valores.
        //Um construtor é um membro que tem o mesmo nome da classe.
        //Ele é usado para inicializar objetos desse tipo de classe.
        public BankAccount(string name, decimal initialBalance)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Saldo Inicial");
        }

        private List<Transaction> allTransactions = new List<Transaction>();


        //Os dois últimos são métodos. Os métodos são blocos de código que executam
        //uma única função. A leitura dos nomes de cada um dos membros
        //deve fornecer informações suficientes para você, ou outro desenvolvedor
        public void MakeDeposit(decimal amount, DateTime date, string note) 
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "O valor do depósito deve ser positivo e acima de 5$ Reais ");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        //A instrução 'throw = lança' uma exceção.
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "O valor da retirada deve ser positivo");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Fundos insuficientes para esta retirada");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        // cria um string para o histórico de transações
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}
