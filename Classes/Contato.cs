using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LGAtividade01.Classes
{
    class Contato
    {

        public int CodigoCliente { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string TipoRelacionamento { get; set; }



        public static Retorno Gravar(string CodigoCliente, string Codigo, string Nome, string Telefone, string TipoRelacionamento)
        {

            try
            {

                var listaContatos = Contato.ObterListaJson();

                if (string.IsNullOrEmpty(CodigoCliente))
                    return new Retorno { Sucesso = false, Mensagem = $"O cliente informado é inválido!" };

                if (string.IsNullOrEmpty(Codigo))
                    Codigo = "0";


                if (String.IsNullOrEmpty(TipoRelacionamento))
                    return new Retorno { Sucesso = false, Mensagem = $"O Tipo Relacionamento é inválido!" };

                var contato = new Contato();
                contato.CodigoCliente = Convert.ToInt32(CodigoCliente);
                contato.Codigo = Convert.ToInt32(Codigo);
                contato.Nome = Nome;
                contato.Telefone = Telefone;
                contato.TipoRelacionamento =  TipoRelacionamento;

                //Bloqueia duplicidade no cadastro de Contatos
                var contatoValidadorDuplicidade = listaContatos.Find(c => c.Codigo != contato.Codigo && c.Telefone == Telefone && c.TipoRelacionamento == contato.TipoRelacionamento && c.CodigoCliente == contato.CodigoCliente);
                if (contatoValidadorDuplicidade != null)
                    return new Retorno { Sucesso = false, Mensagem = $"A relação entre Telefone e Tipo Relacionamento já existe!" };


                if (contato.Codigo == 0)
                {                

                    contato.Codigo = ObterProximoCodigo(listaContatos);
                }
                else
                {

                    var contatoRemover = listaContatos.Find(c => c.Codigo == contato.Codigo);
                    listaContatos.Remove(contatoRemover);
                }

                listaContatos.Add(contato);

                Contato.GravarListaJson(listaContatos.OrderBy(c => c.Codigo).ToList());

            }
            catch (Exception ex)
            {

                return new Retorno { Sucesso = false, Mensagem = $"Erro. Detalhes: {ex.Message}!" };
            }

            return new Retorno { Sucesso = true, Mensagem = "Sucesso!" };

        }



        public static Contato ObterPorCodigo(int CodigoContato)
        {
            var listaContatos = Contato.ObterListaJson();
            return listaContatos.Find(c => c.Codigo == CodigoContato);
        }

        public static List<Contato> ObterListaJson(int CodigoCliente)
        {
            var listaContatos = new List<Contato>();

            var json = "";

            if (File.Exists("Contatos.json"))
            {
                json = File.ReadAllText("Contatos.json");
                listaContatos = JsonConvert.DeserializeObject<List<Contato>>(json);
                listaContatos = listaContatos.FindAll(c => c.CodigoCliente == CodigoCliente);
            }

            return listaContatos;

        }

        public static List<Contato> ObterListaJson()
        {
            var listaContatos = new List<Contato>();

            var json = "";

            if (File.Exists("Contatos.json"))
            {
                json = File.ReadAllText("Contatos.json");
                listaContatos = JsonConvert.DeserializeObject<List<Contato>>(json);
            }

            return listaContatos;

        }


        private static List<Contato> GravarListaJson(List<Contato> listaContatos)
        {
            var json = JsonConvert.SerializeObject(listaContatos);
            File.WriteAllText("Contatos.json", json);

            return ObterListaJson();

        }

        private static int ObterProximoCodigo(List<Contato> listaContatos)
        {
            if (listaContatos.Count > 0)
                return listaContatos.Max(c => c.Codigo) + 1;

            return 1;
        }


    }
}
