using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPraticaMatrizes
{
   public class Cadastro
    {
        int i = 0;

        public Cliente[] Clientes { get; set; }


        public Cadastro(int maximoClientes)
        {
            Clientes = new Cliente[maximoClientes];
        }

        public void RegistroCliente(Cliente cliente)
        {
            if (i < Clientes.Length)
            {
                Clientes[i++] = cliente;
            }
        }
        public int QuantidadeCliente()
        {
            return i;
        }


        public Cliente RetornaCliente()
        {
            return Clientes[i];
        }

        
    }
}
