using System;
using System.Windows.Forms;
using GestaoEquipamentos.Modelo;
namespace GestaoEquipamentos.Interface
{
    public partial class FormEquipamento : Form
    {
         
        static int proximoId = 1;
        readonly int id;

        public Equipamento equipamento_criado;
        // TODO Fase 1: criar o campo privado equipamentoEmEdicao (fica null no modo adicionar)
        Equipamento equipamento_em_edicao;
        // Construtor para ADICIONAR

        public FormEquipamento(Equipamento equipamento_)
        {
            InitializeComponent();
            equipamento_em_edicao = equipamento_;
            Text = "Editar equipamento";
            txtMarca.Text = equipamento_em_edicao.marca;
            txtModelo.Text = equipamento_em_edicao.modelo;
            txtSala.Text = equipamento_em_edicao.sala;
            nudAno.Value = equipamento_em_edicao.ano_aquisicao;
            nudPreco.Value = equipamento_em_edicao.preco_compra;

        }
        public FormEquipamento()
        {
            InitializeComponent();
            Text = "Adicionar equipamento";
            id = proximoId;
            proximoId++;


        }
        
        public int ObterId()
        {
            return id;
        }

        // TODO Fase 1: criar um segundo construtor, para EDITAR, que recebe o equipamento selecionado,
        //              o guarda em equipamentoEmEdicao e preenche as caixas com os dados dele

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: ler os dados das caixas; no modo adicionar criar o objeto com new e guardá-lo
            //              em EquipamentoCriado; no modo editar alterar os campos de equipamentoEmEdicao
            //              (sem criar nenhum objeto novo). No fim: DialogResult = DialogResult.OK;
            if (txtMarca.Text.Trim() == "" || txtModelo.Text.Trim() == "" || txtSala.Text.Trim() == "" || nudAno.Value == 0 || nudPreco.Value == 0)
            {
                MessageBox.Show("Certifique-se de que todos os dados foram devidamente preenchidos.");
                return;
            }

            int ano = (int)nudAno.Value;
            if (equipamento_em_edicao == null)
            {
                equipamento_criado = new Equipamento(txtMarca.Text, txtModelo.Text, txtSala.Text, ano, nudPreco.Value);
            }
            else
            {
                equipamento_em_edicao.marca = txtMarca.Text;
                equipamento_em_edicao.modelo = txtModelo.Text;
                equipamento_em_edicao.sala = txtSala.Text;
                equipamento_em_edicao.ano_aquisicao = ano;
                equipamento_em_edicao.preco_compra = nudPreco.Value;

            }
            DialogResult = DialogResult.OK;
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 6: ativar só o grupo do tipo escolhido (grpComputador, grpImpressora, grpProjetor)
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
