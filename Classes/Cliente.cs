using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LGAtividade01.Classes
{
    class Cliente
    {

        public int Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public List<Contato> ListaContatos { get; set; }


        public static Retorno Gravar(string Codigo, string Cpf, string Nome, string Telefone)
        {

            try
            {
                var listaClientes = Cliente.ObterListaJson();

                if (string.IsNullOrEmpty(Codigo))
                    Codigo = "0";

                var cliente = new Cliente();
                cliente.Codigo = Convert.ToInt32(Codigo);
                cliente.Cpf = Cpf;
                cliente.Nome = Nome;
                cliente.Telefone = Telefone;

                if (cliente.Codigo == 0)
                {
                    cliente.Codigo = ObterProximoCodigo(listaClientes);
                }
                else
                {
                    var clienteRemover = listaClientes.Find(c => c.Codigo == cliente.Codigo);
                    listaClientes.Remove(clienteRemover);
                }

                listaClientes.Add(cliente);

                Cliente.GravarListaJson(listaClientes.OrderBy(c => c.Codigo).ToList());
            }
            catch (Exception ex)
            {
                return new Retorno { Sucesso = false, Mensagem = $"Erro. Detalhes: {ex.Message}!" };
            }


            return new Retorno { Sucesso = true, Mensagem = "Sucesso!" };


        }

        public static Cliente ObterPorCodigo(int CodigoCliente)
        {
            var listaClientes = Cliente.ObterListaJson(); 
            return listaClientes.Find(c => c.Codigo == CodigoCliente);
        }

        public static List<Cliente> ObterListaJson()
        {
            var listaClientes = new List<Cliente>();

            var json = "";

            if (File.Exists("Clientes.json"))
            {
                json = File.ReadAllText("Clientes.json");
                listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
            }


            return listaClientes;

        }

        private static List<Cliente> GravarListaJson(List<Cliente> listaClientes)
        {
            var json = JsonConvert.SerializeObject(listaClientes);
            File.WriteAllText("Clientes.json", json);

            return ObterListaJson();

        }

        private static int ObterProximoCodigo(List<Cliente> listaClientes)
        {
            if (listaClientes.Count > 0)
                return listaClientes.Max(c => c.Codigo) + 1;

            return 1;
        }


    }
}
