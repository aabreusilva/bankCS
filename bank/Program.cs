namespace bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoAlexandre = new ContaCorrente();

            //Nome do titutlar da conta.
            contaDoAlexandre.titular = "Alexandre Abreu Silva";

            //Número da agência.
            contaDoAlexandre.agencia = 15;

            //Número da conta.
            contaDoAlexandre.conta = "1010-X";

            //Saldo da conta.
            contaDoAlexandre.saldo = 100.00;

            Console.WriteLine(contaDoAlexandre.titular);
            Console.WriteLine(contaDoAlexandre.agencia);
            Console.WriteLine(contaDoAlexandre.conta);
            Console.WriteLine(contaDoAlexandre.saldo);


        }
    }
}