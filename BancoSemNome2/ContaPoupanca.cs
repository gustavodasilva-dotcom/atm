using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSemNome2
{
    class ContaPoupanca : Conta
    {
        private int extratoMes;

        public void emitirExtratoMes() { } // Método a ser implementado.

        /*
         * Ao instanciar essa classe, automaticamente, o atributo 'tipoConta', herença da classe-mãe 'Conta', será 
         * definido como "Conta Poupança". Essa informação será exibida ao usuário no caixa eletrônico. Essa carac-
         * terística acontecerá em ambos os contrutores.
         */
        public ContaPoupanca()
        {
            this.tipoConta = "Conta Poupança";

            /*
             * Definição automatica da data de abertura da conta. O "d", em .toString(), serve para 'pegar', do método
             * definirDataAbertura(), apenas a data, pois esse método retorna, também, a horá de criação da conta.
             */
            this.dataDeAbertura = this.definirDataAbertura().ToString("d");
        }

        public ContaPoupanca(Cliente cl, bool statCon, double sal, String agen, String con, String sen)
            : base(cl, statCon, sal, agen, con, sen)
        {
            this.titular = cl;
            this.statusConta = statCon;
            this.saldo = sal;
            this.agencia = agen;
            this.conta = con;
            this.senha = sen;

            this.tipoConta = "Conta Poupança";

            /*
             * Definição automatica da data de abertura da conta. O "d", em .toString(), serve para 'pegar', do método
             * definirDataAbertura(), apenas a data, pois esse método retorna, também, a horá de criação da conta.
             */
            this.dataDeAbertura = this.definirDataAbertura().ToString("d");
        }

        public int getExtratoMes()
        {
            return this.extratoMes;
        }

        public void setExtratoMes(int entExtMes)
        {
            this.extratoMes = entExtMes;
        }
    }
}
