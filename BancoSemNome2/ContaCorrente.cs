using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSemNome2
{
    class ContaCorrente : Conta
    {
        private double saldoChequeEspecial;

        public void emitirHolerite() { } // Método a ser implementado.

        public ContaCorrente()
        {
            /*
             * Ao instanciar essa classe, automaticamente, o atributo 'tipoConta', herença da classe-mãe 'Conta', será 
             * definido como "Conta Corrente". Essa informação será exibida ao usuário no caixa eletrônico. Essa carac-
             * terística acontecerá em ambos os construtores.
             */
            this.tipoConta = "Conta Corrente";

            /*
             * Definição automatica da data de abertura da conta. O "d", em .toString(), serve para 'pegar', do método
             * definirDataAbertura(), apenas a data, pois esse método retorna, também, a horá de criação da conta.
             */
            this.dataDeAbertura = this.definirDataAbertura().ToString("d");
        }

        public ContaCorrente(Cliente cl, bool statCon, double sal, String agen, String con, String sen)
            : base(cl, statCon, sal, agen, con, sen)
        {
            this.titular = cl;
            this.statusConta = statCon;
            this.saldo = sal;
            this.agencia = agen;
            this.conta = con;
            this.senha = sen;

            this.tipoConta = "Conta Corrente";

            /*
             * Definição automatica da data de abertura da conta. O "d", em .toString(), serve para 'pegar', do método
             * definirDataAbertura(), apenas a data, pois esse método retorna, também, a horá de criação da conta.
             */
            this.dataDeAbertura = this.definirDataAbertura().ToString("d");
        }

        public double getSaldoChequeEspecial()
        {
            return this.saldoChequeEspecial;
        }

        public void setSaldoChequeEspecial(double entSce)
        {
            this.saldoChequeEspecial = entSce;
        }
    }
}
