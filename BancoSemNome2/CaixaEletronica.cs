using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSemNome2
{
    class CaixaEletronica : InterfaceCaixaEletronico
    {
        private Conta usuario;
        private double valorTran;
        private bool sessao;

        public void transacoes()
        {
            String controle = "S";
            int operacao;

            /**
             * Implementação do método declarado na interface 'InterfaceCaixaEletronico.cs'. A variável de controle,
             * 'controle', enquanto tiver o valor diferente de 'N' e 'n', fará com que o loop continue, possibilitando
             * o usuário escolher entre as opções de ações no caixa eletrônico.
             */
            while ((controle != "N") && (controle != "n"))
            {
                Console.WriteLine("1 - Sacar;");
                Console.WriteLine("2 - Depositar;");
                Console.WriteLine("3 - Visualizar saldo;");
                Console.WriteLine("4 - Visualizar informações de conta.");

                Console.Write("Digite o número da operação desejada: ");
                operacao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(); // Comando sendo usado apenas para pular uma linha.

                switch(operacao)
                {
                    case 1:
                        // Se o usuário digitar 1, a operação sacar() será realizada!
                        this.sacar();

                        // Sempre pular uma linha após a execução do método (aqui e em todos os próximos 'cases').
                        Console.WriteLine();
                        break;
                    case 2:
                        // Se o usuário digitar 2, a operação depositar() será realizada!
                        this.depositar();

                        Console.WriteLine();
                        break;
                    case 3:
                        // Se o usuário digitar 3, a operação saldoCliente() será realizada!
                        this.saldoCliente();

                        Console.WriteLine();
                        break;
                    case 4:
                        // Se o usuário digitar 4, a operação contaCliente() será realizada!
                        this.contaCliente();

                        Console.WriteLine();
                        break;
                    default:
                        /*
                         * Se o usuário digitar qualquer valor diferente dos previstos anteriormente nos 'cases', o
                         * programa cairá neste 'default'.
                         */
                        Console.WriteLine("Operação inválida! Tentar novamente.");

                        Console.WriteLine();
                        break;
                }

                // Atualização do valor da variável de controle através da entrada do usuário.
                Console.Write("Deseja realizar mais uma operação? (S/N) ");
                controle = Console.ReadLine();
            }
        }

        private void contaCliente()
        {
            bool validacaoSenha;

            validacaoSenha = this.processamentoSenha();

            if (validacaoSenha == true)
            {
                Console.WriteLine("Nome do cliente: {0}", this.usuario.getTitular().getNome());
                Console.WriteLine("CPF: {0}", this.usuario.getTitular().getCpf());
                Console.WriteLine("Data de nascimento: {0}", this.usuario.getTitular().getDataDeNascimento());
                Console.WriteLine("Tipo de conta: {0} ", this.usuario.getTipoConta());
                Console.WriteLine("Data de abertura: {0}", this.usuario.getDataDeAbertura());
            } else
            {
                Console.WriteLine("Senha inválida! Impossível continuar com a operação.");
            }
        }

        private void saldoCliente()
        {
            bool validacaoSenha;

            validacaoSenha = this.processamentoSenha();

            if (validacaoSenha == true)
            {
                Console.WriteLine("Seu saldo atual é: R$ {0}", this.usuario.getSaldo());
            } else
            {
                Console.WriteLine("Senha inválida! Impossível continuar com a operação.");
            }
        }

        private void sacar()
        {
            bool validacaoSenha;

            validacaoSenha = this.processamentoSenha();

            if (validacaoSenha == true)
            {
                Console.Write("Informe o valor de saque: ");
                this.valorTran = Convert.ToDouble(Console.ReadLine());

                validacaoSenha = this.processamentoSenha();
                
                if (validacaoSenha == true)
                {
                    this.usuario.setSaldo(this.usuario.getSaldo() - this.valorTran);

                    Console.WriteLine("Saque de R$ {0} realizado com sucesso!", this.valorTran.ToString());
                } else
                {
                    Console.WriteLine("Senha inválida! Impossível continuar com a operação.");
                }
            } else
            {
                Console.WriteLine("Senha inválida! Impossível continuar com a operação.");
            }
        }

        private void depositar()
        {
            bool validacaoSenha;

            validacaoSenha = this.processamentoSenha();

            if (validacaoSenha == true)
            {
                Console.Write("Informe o valor para deposito: ");
                this.valorTran = Convert.ToDouble(Console.ReadLine());

                validacaoSenha = this.processamentoSenha();

                if (validacaoSenha == true)
                {
                    this.usuario.setSaldo(this.usuario.getSaldo() + this.valorTran);

                    Console.WriteLine("Deposito de R$ {0} realizado com sucesso!", this.valorTran);
                } else
                {
                    Console.WriteLine("Senha inválida! Impossível continuar com a operação.");
                }
            } else
            {
                Console.WriteLine("Senha inválida! Impossível continuar com a operação.");
            }
        }

        /*
         * Método para fazer o processamento da senha. Aqui, a variável 'entSenha' receberá a senha digitada pelo usuário.
         * Em uma operação ternária, o resultado lógico (true ou false) da comparação da senha digitada pelo usuário com
         * a senha cadastrada na conta do cliente (this.usuario), determinará se a senha está correta ou incorreta. Esse
         * método será chamado antes de todas as operações do caixa eletrônico.
         */
        private bool processamentoSenha()
        {
            String entSenha;
            bool ret;

            Console.Write("Por favor, informe sua senha: ");
            entSenha = Console.ReadLine();

            // Operador ternário que verificará se a senha está correta. O resultado lógico será alocado à 'ret'.
            ret = (entSenha == this.usuario.getSenha()) ? true : false;

            return ret;
        }

        public CaixaEletronica() { }

        public CaixaEletronica(Conta entTitular)
        {
            this.usuario = entTitular;
        }
        
        public Conta getUsuario()
        {
            return this.usuario;
        }

        public void setUsuario(Conta entCon)
        {
            this.usuario = entCon;
        }

        public double getValorTran()
        {
            return this.valorTran;
        }

        public void setValorTran(double entValTran)
        {
            this.valorTran = entValTran;
        }

        public bool getSessao()
        {
            return this.sessao;
        }

        public void setSessao(bool entSes)
        {
            this.sessao = entSes;
        }
    }
}
