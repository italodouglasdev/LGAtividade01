using LGAtividade01.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LGAtividade01.Forms
{
    public partial class FormPrincipal : Form
    {
               
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarDataGridViewClientes();
            CarregarComboboxTipoRelacionamento();
        }      



        #region Clientes

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            LimparControlesCliente();
            LimparControlesCliente();
            CarregarDataGridViewContatos(0);
        }
        private void buttonGravarCliente_Click(object sender, EventArgs e)
        {
            var Retorno = Cliente.Gravar(textBoxCodigoCliente.Text, textBoxCPFCliente.Text, textBoxNomeCliente.Text, textBoxTelefoneCliente.Text);

            if (Retorno.Sucesso == true)
            {
                CarregarDataGridViewClientes();
                LimparControlesCliente();
            }

            MessageBox.Show(Retorno.Mensagem);
        }

        private void LimparControlesCliente()
        {
            textBoxCodigoCliente.Text = "";
            textBoxCPFCliente.Text = "";
            textBoxNomeCliente.Text = "";
            textBoxTelefoneCliente.Text = "";
        }

        private void CarregarControlesCliente(int CodigoCliente)
        {
            var cliente = Cliente.ObterPorCodigo(CodigoCliente);

            textBoxCodigoCliente.Text = cliente.Codigo.ToString();
            textBoxCPFCliente.Text = cliente.Cpf;
            textBoxNomeCliente.Text = cliente.Nome;
            textBoxTelefoneCliente.Text = cliente.Telefone;

            CarregarDataGridViewContatos(CodigoCliente);

            LimparControlesContato();
        }


        private void CarregarDataGridViewClientes()
        {

            if (dataGridViewClientes.Rows.Count > 0)
                dataGridViewClientes.Rows.Clear();

            var listaClientes = Cliente.ObterListaJson();

            foreach (var cliente in listaClientes)
                dataGridViewClientes.Rows.Add(cliente.Codigo, cliente.Cpf, cliente.Nome, cliente.Telefone, "Editar");

            labelQuantidadeClientes.Text = $"Quantidade Clientes: {listaClientes.Count()}";

        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            var CodigoCliente = dgv[0, e.RowIndex].Value.ToString();        
            CarregarControlesCliente(Convert.ToInt32(CodigoCliente));
            LimparControlesContato();
           
        }

        #endregion

        #region Contatos
        private void buttonNovoContato_Click(object sender, EventArgs e)
        {
            LimparControlesContato();
        }

        private void buttonGravarContato_Click(object sender, EventArgs e)
        {
            var Retorno = Contato.Gravar(textBoxCodigoCliente.Text, textBoxCodigoContato.Text, textBoxNomeContato.Text, textBoxTelefoneContato.Text, comboBoxTipoRelacionamentoContato.Text);

            if (Retorno.Sucesso == true)
            {
                CarregarDataGridViewContatos(Convert.ToInt32(textBoxCodigoCliente.Text));
                LimparControlesContato();
            }

            MessageBox.Show(Retorno.Mensagem);
        }

        private void LimparControlesContato()
        {
            textBoxCodigoContato.Text = "";
            textBoxNomeContato.Text = "";
            textBoxTelefoneContato.Text = "";
            comboBoxTipoRelacionamentoContato.Text = "";
        }

        private void CarregarControlesContato(int CodigoContato)
        {

            CarregarComboboxTipoRelacionamento();


            var contato = Contato.ObterPorCodigo(CodigoContato);

            if (contato != null)
            {
                textBoxCodigoContato.Text = contato.Codigo.ToString();
                textBoxNomeContato.Text = contato.Nome;
                textBoxTelefoneContato.Text = contato.Telefone;
                comboBoxTipoRelacionamentoContato.Text = contato.TipoRelacionamento.ToString();
            }


        }

        private void CarregarComboboxTipoRelacionamento()
        {
            if (comboBoxTipoRelacionamentoContato.Items.Count > 0)
                comboBoxTipoRelacionamentoContato.Items.Clear();
            var listaEnums = new[] { "Pai", "Mãe", "Irmão(ã)", "Amigo", "Outro" };

            foreach (var Enum in listaEnums)
                comboBoxTipoRelacionamentoContato.Items.Add(Enum);
        }

        private void CarregarDataGridViewContatos(int CodigoCliente)
        {

            if (dataGridViewContatos.Rows.Count > 0)
                dataGridViewContatos.Rows.Clear();

            var listaContatos = Contato.ObterListaJson(CodigoCliente);

            foreach (var Contato in listaContatos)
                dataGridViewContatos.Rows.Add(Contato.Codigo, Contato.Nome, Contato.Telefone, Contato.TipoRelacionamento, "Editar");

            labelQuantidadeContatos.Text = $"Quantidade Contatos: {listaContatos.Count()}";

        }

        private void dataGridViewContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            var CodigoContato = dgv[0, e.RowIndex].Value.ToString();
            CarregarControlesContato(Convert.ToInt32(CodigoContato));
        }
        #endregion


    }
}
