using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSemNome2
{
    public class Cliente
    {
        private String nome;
        private String dataDeNascimento;
        private String cpf;
        private String numCarteiraTrabalho;
        private Endereco endereco;

        public Cliente() { }

        public Cliente(String entNo, String entDdN, String entCpf, String entNcT, Endereco end)
        {
            this.nome = entNo;
            this.dataDeNascimento = entDdN;
            this.cpf = entCpf;
            this.numCarteiraTrabalho = entNcT;
            this.endereco = end;
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String entNo)
        {
            this.nome = entNo;
        }

        public String getDataDeNascimento()
        {
            return this.dataDeNascimento;
        }

        public void setDataDeNascimento(String entDdN)
        {
            this.dataDeNascimento = entDdN;
        }

        public String getCpf()
        {
            return this.cpf;
        }

        public void setCpf(String entCpf)
        {
            this.cpf = entCpf;
        }

        public String getNumCarteiraTrabalho()
        {
            return this.numCarteiraTrabalho;
        }

        public void setNumCarteiraTrabalho(String entNct)
        {
            this.numCarteiraTrabalho = entNct;
        }

        public Endereco getEndereco()
        {
            return this.endereco;
        }

        public void setEndereco(Endereco entEnd)
        {
            this.endereco = entEnd;
        }
    }
}
