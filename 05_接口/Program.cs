using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_接口
{
    public interface IBankAccount //银行账号
    {
        void PayIn(decimal amount);//存款
        bool Withdraw(decimal amount);//取款 并返回是否成功
        decimal Balance { get; }//余额
    }

    public interface ITransferBankAccount : IBankAccount//转账银行账户
    {
        bool TransferTo(IBankAccount destination, decimal amount);
    }

    public class CurrentAccount : ITransferBankAccount //当前账户
    {
        private decimal balance;//余额
        public void PayIn(decimal amount) { balance += amount; }//存款
        public bool Withdraw(decimal amount)//取款
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("余额不足,取款失败！");
                return false;
            }
        }
        public decimal Balance { get { return balance; } }//返回余额

        public bool TransferTo(IBankAccount destination, decimal amount) //银行转账
        {
            if (Withdraw(amount)==true)
            {
                destination.PayIn(amount);
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            return string.Format("Current Bank Account  :Balance={0:0.00}", this.Balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount account1 = new CurrentAccount();//账户1
            ITransferBankAccount account2 = new CurrentAccount();//账户2

            account1.PayIn(200);//账户1存款200
            account2.PayIn(500);//账户2存款500

            account2.TransferTo(account1, 100);//账户2转账100元到账户1

            //显示余额

            Console.WriteLine("account1's  " + account1.ToString());

            Console.WriteLine("account2's  " + account2.ToString());

            Console.ReadKey();
        }
    }
}
