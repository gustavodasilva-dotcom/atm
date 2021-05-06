using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSemNome2
{
    public class Endereco
    {
        private String cep;
        private String logradouro;
        private String numero;
        private String complemento;
        private String bairro;
        private String localidade;
        private String uf;

        public Endereco() { }

        public Endereco(String entCep, String entLog, String entNum, String entCom, String entBai, String entLoc,
            String entUf)
        {
            this.cep = entCep;
            this.logradouro = entLog;
            this.numero = entNum;
            this.complemento = entCom;
            this.bairro = entBai;
            this.localidade = entLoc;
            this.uf = entUf;
        }

        public String getCep()
        {
            return this.cep;
        }

        public void setCep(String entCep)
        {
            this.cep = entCep;
        }

        public String getLogradouro()
        {
            return this.logradouro;
        }

        public void setLogradouro(String entLog)
        {
            this.logradouro = entLog;
        }

        public String getNumero()
        {
            return this.numero;
        }

        public void setNumero(String entNum)
        {
            this.numero = entNum;
        }

        public String getComplemento()
        {
            return this.complemento;
        }

        public void setComplemento(String entCom)
        {
            this.complemento = entCom;
        }

        public String getBairro()
        {
            return this.bairro;
        }

        public void setBairro(String entBai)
        {
            this.bairro = entBai;
        }

        public String getLocalidade()
        {
            return this.localidade;
        }

        public void setLocalidade(String entLoc)
        {
            this.localidade = entLoc;
        }

        public String getUf()
        {
            return this.uf;
        }

        public void setUf(String entUf)
        {
            this.uf = entUf;
        }
    }
}
