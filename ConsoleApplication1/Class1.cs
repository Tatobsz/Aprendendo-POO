using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        private int agConta;
        private int nConta;
        private float saldo;
        private bool status;

        public void Conta()
        {
            status_C = false;
            salde_C = 0;
        }

        public void status_C
        {
            get { return status; }
            set { status = value; }
        }

        public void agencia_C
        {
            get { return agConta; }
            set { agConta = value; }
        }

        public void numero_C
        {
            get { return nConta; }
            set { nConta = value; }
        }

        public void saldo_C
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void verifSaldo()
        {
            saldo_C();
        }

        public void deposito(float vdepositado)
        {
            if (status_C == true)
            {
                saldo_C = saldo_C + vdepositado;
                Console.WriteLine("Deposito realizado com sucesso!");
            }
            else
                Console.WriteLine("Conta inexistente");
        }

        public void saque(float vsacado)
        {
            if (status_C == true)
            {
                if (saldo_C >= vsacado)
                {
                    saldo_C = saldo_C - vsacado;
                    Console.WriteLine("Saque realizado com sucesso!");
                }

                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else
                Console.WriteLine("Conta inexistente");
        }

        public void abrirConta()
        {
            status_C = true;
        }

        public void fecharConta()        
        {
            if (status_C == true)
            {
                if (saldo_C >= 0)
                {
                    status_C = false;
                }

                else
                {
                    Console.WriteLine("Faça a kitação dos seus débitos");
                }
            }
            else
                Console.WriteLine("Conta inexistente");            
        }
    }
}
