using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestaoEquipamentos.Modelo;
// TODO Fase 1: depois de criar a classe Equipamento na pasta Modelo, acrescentar:
//              using GestaoEquipamentos.Modelo;

namespace GestaoEquipamentos.Interface
{
    public partial class FormPrincipal : Form
    {
        // TODO Fase 1: criar o campo List<Equipamento> equipamentos (já com new)
        List<Equipamento> equipamentos = new List<Equipamento>();
        const int ncolunas = 9;

        public FormPrincipal()
        {
            InitializeComponent();
            equipamentos.Add(new Equipamento("AS", "ASDFG", "B12", 2024, 200));
            MostrarEquipamento();// TODO Fase 1: no fim do construtor, chamar MostrarEquipamentos()

        }

        // TODO Fase 1: criar o método MostrarEquipamentos(), que limpa a ListView
        //              (lvEquipamentos.Items.Clear()) e junta uma linha por equipamento.
        //              Ordem das colunas: Id, Tipo, Marca, Modelo, N.º de série, Sala, Ano,
        //              Preço, Estado, Valor atual. Por agora, Id, Tipo, N.º de série, Estado
        //              e Valor atual ficam vazias ("").
        //              Dica:  ListViewItem linha = new ListViewItem("");
        //                     linha.SubItems.Add("");  linha.SubItems.Add(equipamento.Marca); ...
        //                     lvEquipamentos.Items.Add(linha);
        public void MostrarEquipamento()
        {
            lvEquipamentos.Items.Clear();
            foreach (Equipamento equipamento in equipamentos)
            {
                ListViewItem linha = new ListViewItem("");
                int i = 0;
                while (i <= ncolunas)
                {

                    linha.SubItems.Add(equipamento.MostrarDado(i));
                    i++;

                }
                lvEquipamentos.Items.Add(linha);
            }
            AtualizarResumo();
        }
        public void AtualizarResumo()
        {
            lblResumo.Text = $"Equipamentos na lista: {equipamentos.Count}";
        }
        // ---------- Botões ----------

        public Equipamento EquipamentoSelecionado()
        {
            int i = Convert.ToInt32(lvEquipamentos.SelectedIndices[0]);
            return equipamentos[i];
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: abrir o FormEquipamento com ShowDialog(); se devolver DialogResult.OK,
            //              juntar form.EquipamentoCriado à lista e chamar MostrarEquipamentos()
            FormEquipamento forme = new FormEquipamento();
            forme.ShowDialog();

            if (forme.DialogResult == DialogResult.OK)
            {
                equipamentos.Add(forme.equipamento_criado);

                
                MostrarEquipamento();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              abrir new FormEquipamento(equipamento) e, se devolver OK,
            //              chamar MostrarEquipamentos()
            if (lvEquipamentos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhum equipamento foi selecionado para edição.");
                
            }
            else
            {
                int i = lvEquipamentos.SelectedIndices[0];

                FormEquipamento forme = new FormEquipamento(equipamentos[i]);
                forme.ShowDialog();
                if (forme.DialogResult == DialogResult.OK)
                {
                    MostrarEquipamento();
                }
            }
                
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // TODO Fase 1: obter o equipamento selecionado (se não houver, mostrar uma mensagem),
            //              pedir confirmação, retirar da lista e pôr a variável a null
            if (EquipamentoSelecionado() == null)
            {
                MessageBox.Show("Nenhum equipamento foi selecionado para remoção.");

            }
            else
            {
                DialogResult r = MessageBox.Show("Tens a certeza que queres eliminar este registo?","Confirmar Ação",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    equipamentos.Remove(equipamentos[lvEquipamentos.SelectedIndices[0]]);
                    equipamentos[lvEquipamentos.SelectedIndices[0]] = null;
                    MostrarEquipamento() ;
                }
            }
        }

        private void lvEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 1: mostrar em txtDetalhes os dados do equipamento selecionado
            if (lvEquipamentos.SelectedIndices.Count != 0)
            {
                txtDetalhes.Text = EquipamentoSelecionado().ObterDescricao();
            }
            else
            {
                txtDetalhes.Clear();
            }
            
        }

        // Duplo clique numa linha = Editar
        private void lvEquipamentos_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void btnAlterarResponsavel_Click(object sender, EventArgs e)
        {
            // TODO Fase 2: alterar o responsável de informática com Escola.AlterarResponsavel(...)
        }

        // ---------- Pesquisa e filtros ----------

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // TODO Fase 5: mostrar só os equipamentos devolvidos por gestor.Pesquisar(txtPesquisa.Text)
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void btnImpressorasCores_Click(object sender, EventArgs e)
        {
            // TODO Fase 7: mostrar só as impressoras a cores (gestor.ObterImpressorasACores())
        }

        private void btnPoucaRam_Click(object sender, EventArgs e)
        {
            // TODO Fase 7: mostrar só os computadores com 4 GB de RAM ou menos
            //              (gestor.ObterComputadoresComPoucaRam(4))
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Fase 8: mostrar só os equipamentos do estado escolhido (gestor.Pesquisar(estado))
        }

        private void txtResponsavel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
