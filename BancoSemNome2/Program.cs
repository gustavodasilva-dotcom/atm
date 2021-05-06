using System;

namespace BancoSemNome2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar, primeiramente, o 'Endereco'.
            Endereco end = new Endereco("01010101", "Rua Avenida Rodovia", "000", "", "Jardim Bairro",
                "São Paulo", "SP");

            // Criar, depois, o objeto cliente e, por último, passar, como parâmetro, 'Endereco'.
            Cliente cl = new Cliente("Gustavo da Silva", "01/01/2001", "00000000001", "00000", end);

            // Por último, passar, como parâmetro, o objeto da classe 'Cliente'.
            ContaCorrente cc = new ContaCorrente(cl, true, 25000, "000000", "0000001", "010101");

            CaixaEletronica ce = new CaixaEletronica(cc);
            ce.transacoes();
        }
    }
}
