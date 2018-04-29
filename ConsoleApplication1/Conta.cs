using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Conta
    {
        private string nome;
        private Int32 rg;
        private Int32 agConta;
        private Int32 nConta;
        private float saldo;
        private bool status;
        private bool existe;

        public bool existe_C
        {
            get { return existe; }
            set { existe = value; }
        }

        public Conta()
        {
            status_C = false;
            saldo_C = 0;
            existe_C = false;
        }

        public string nome_C
        {
            get { return nome; }
            set { nome = value; }
        }

        public int rg_C
        {
            get { return rg; }
            set { rg = value; }
        }

        public bool status_C
        {
            get { return status; }
            set { status = value; }
        }

        public int agencia_C
        {
            get { return agConta; }
            set { agConta = value; }
        }

        public int numero_C
        {
            get { return nConta; }
            set { nConta = value; }
        }

        public float saldo_C
        {
            get { return saldo; }
            set { saldo = value; }
        }
     
        public void testeConta(int n, int a)
        {
            if (n == numero_C && a == agencia_C)
            {
                existe_C = true;
            }
        }

        public void deposito(float vdepositado)
        {
            if (status_C == true && existe_C == true)
            {
                saldo_C = saldo_C + vdepositado;
                Console.WriteLine("Deposito realizado com sucesso!");
                Console.ReadLine();
                existe_C = false;
            }
            else
            {
                Console.WriteLine("Conta inexistente");
                Console.ReadLine();
            }
        }
            

        public void saque(float vsacado)
        {
            if (status_C == true && existe_C == true)
            {
                if (saldo_C >= vsacado)
                {
                    saldo_C = saldo_C - vsacado;
                    Console.WriteLine("Saque realizado com sucesso!");
                    Console.ReadLine();
                    existe_C = false;
                }

                else
                {
                    Console.WriteLine("Saldo insuficiente");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Conta inexistente");
                Console.ReadLine();
            }
        }

        public void abrirConta(string n, Int32 rg)
        {           
            Random r = new Random();
            Int32 t = r.Next(1000, 9999);                         
            agencia_C = 1993;
            numero_C = t;
            status_C = true;
            nome_C = n;
            rg_C = rg;            
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
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Conta inexistente");
                Console.ReadLine();
            }
        }        
    }
}
