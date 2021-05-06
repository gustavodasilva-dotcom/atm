using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSemNome2
{
    abstract class Conta
    {
        protected Cliente titular;
        protected bool statusConta;
        protected double saldo;
        protected String dataDeAbertura;
        protected String agencia;
        protected String conta;
        protected String senha;
        protected String tipoConta;

        /*
         * Sempre que as instâncias filhas destas classe, 'ContaPoupanca' e 'ContaPoupanca', forem instanciadas -- ou
         * seja, sempre que uma nova conta for aberta -- automaticamente, esse método definirá o dia que o objeto for
         * criado como o dia da criação/abertura da conta.
         */
        protected DateTime definirDataAbertura()
        {
            DateTime dataHoje = DateTime.Today;
            DateTime apenasData = dataHoje.Date;

            return apenasData;
        }

        public Conta() { }

        public Conta(Cliente cl, bool statCon, double sal, String agen, String con, String sen)
        {
            this.titular = cl;
            this.statusConta = statCon;
            this.saldo = sal;
            this.agencia = agen;
            this.conta = con;
            this.senha = sen;           
        }

        public Cliente getTitular()
        {
            return this.titular;
        }

        public void setTitular(Cliente entCl)
        {
            this.titular = entCl;
        }

        public bool getStatusConta()
        {
            return this.statusConta;
        }

        public void setStatusConta(bool entStC)
        {
            this.statusConta = entStC;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public void setSaldo(double entSal)
        {
            this.saldo = entSal;
        }

        public String getDataDeAbertura()
        {
            return this.dataDeAbertura;
        }

        protected void setDataDeAbertura(String entDdA)
        {
            this.dataDeAbertura = entDdA;
        }

        public String getAgencia()
        {
            return this.agencia;
        }

        public void setAgencia(String entAge)
        {
            this.agencia = entAge;
        }

        public String getConta()
        {
            return this.conta;
        }

        public void setConta(String entCon)
        {
            this.conta = entCon;
        }

        public String getSenha()
        {
            return this.senha;
        }

        public void setSenha(String entSe)
        {
            this.senha = entSe;
        }

        public String getTipoConta()
        {
            return this.tipoConta;
        }

        protected void setTipoConta(String entTipCon)
        {
            this.tipoConta = entTipCon;
        }
    }
}
