namespace GestaoEquipamentos.Interface
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável necessária para o Designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão a ser utilizados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            lblPesquisa = new System.Windows.Forms.Label();
            txtPesquisa = new System.Windows.Forms.TextBox();
            btnPesquisar = new System.Windows.Forms.Button();
            btnMostrarTodos = new System.Windows.Forms.Button();
            lblFiltroEstado = new System.Windows.Forms.Label();
            cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            btnImpressorasCores = new System.Windows.Forms.Button();
            btnPoucaRam = new System.Windows.Forms.Button();
            lblResponsavel = new System.Windows.Forms.Label();
            txtResponsavel = new System.Windows.Forms.TextBox();
            btnAlterarResponsavel = new System.Windows.Forms.Button();
            lvEquipamentos = new System.Windows.Forms.ListView();
            colId = new System.Windows.Forms.ColumnHeader();
            colTipo = new System.Windows.Forms.ColumnHeader();
            colMarca = new System.Windows.Forms.ColumnHeader();
            colModelo = new System.Windows.Forms.ColumnHeader();
            colNumeroSerie = new System.Windows.Forms.ColumnHeader();
            colSala = new System.Windows.Forms.ColumnHeader();
            colAno = new System.Windows.Forms.ColumnHeader();
            colPreco = new System.Windows.Forms.ColumnHeader();
            colEstado = new System.Windows.Forms.ColumnHeader();
            colValorAtual = new System.Windows.Forms.ColumnHeader();
            lblDetalhes = new System.Windows.Forms.Label();
            txtDetalhes = new System.Windows.Forms.TextBox();
            btnAdicionar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnRemover = new System.Windows.Forms.Button();
            lblResumo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new System.Drawing.Point(12, 17);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new System.Drawing.Size(60, 15);
            lblPesquisa.TabIndex = 0;
            lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new System.Drawing.Point(82, 13);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new System.Drawing.Size(200, 23);
            txtPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new System.Drawing.Point(288, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new System.Drawing.Size(90, 26);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new System.Drawing.Point(384, 12);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new System.Drawing.Size(105, 26);
            btnMostrarTodos.TabIndex = 3;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // lblFiltroEstado
            // 
            lblFiltroEstado.AutoSize = true;
            lblFiltroEstado.Location = new System.Drawing.Point(505, 17);
            lblFiltroEstado.Name = "lblFiltroEstado";
            lblFiltroEstado.Size = new System.Drawing.Size(45, 15);
            lblFiltroEstado.TabIndex = 4;
            lblFiltroEstado.Text = "Estado:";
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFiltroEstado.Enabled = false;
            cmbFiltroEstado.FormattingEnabled = true;
            cmbFiltroEstado.Location = new System.Drawing.Point(556, 13);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new System.Drawing.Size(130, 23);
            cmbFiltroEstado.TabIndex = 5;
            cmbFiltroEstado.SelectedIndexChanged += cmbFiltroEstado_SelectedIndexChanged;
            // 
            // btnImpressorasCores
            // 
            btnImpressorasCores.Location = new System.Drawing.Point(702, 12);
            btnImpressorasCores.Name = "btnImpressorasCores";
            btnImpressorasCores.Size = new System.Drawing.Size(140, 26);
            btnImpressorasCores.TabIndex = 6;
            btnImpressorasCores.Text = "Impressoras a cores";
            btnImpressorasCores.UseVisualStyleBackColor = true;
            btnImpressorasCores.Click += btnImpressorasCores_Click;
            // 
            // btnPoucaRam
            // 
            btnPoucaRam.Location = new System.Drawing.Point(848, 12);
            btnPoucaRam.Name = "btnPoucaRam";
            btnPoucaRam.Size = new System.Drawing.Size(190, 26);
            btnPoucaRam.TabIndex = 7;
            btnPoucaRam.Text = "Computadores com pouca RAM";
            btnPoucaRam.UseVisualStyleBackColor = true;
            btnPoucaRam.Click += btnPoucaRam_Click;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new System.Drawing.Point(12, 53);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new System.Drawing.Size(155, 15);
            lblResponsavel.TabIndex = 8;
            lblResponsavel.Text = "Responsável de informática:";
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new System.Drawing.Point(178, 49);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new System.Drawing.Size(200, 23);
            txtResponsavel.TabIndex = 9;
            txtResponsavel.TextChanged += txtResponsavel_TextChanged;
            // 
            // btnAlterarResponsavel
            // 
            btnAlterarResponsavel.Location = new System.Drawing.Point(384, 48);
            btnAlterarResponsavel.Name = "btnAlterarResponsavel";
            btnAlterarResponsavel.Size = new System.Drawing.Size(105, 26);
            btnAlterarResponsavel.TabIndex = 10;
            btnAlterarResponsavel.Text = "Alterar";
            btnAlterarResponsavel.UseVisualStyleBackColor = true;
            btnAlterarResponsavel.Click += btnAlterarResponsavel_Click;
            // 
            // lvEquipamentos
            // 
            lvEquipamentos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvEquipamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colId, colTipo, colMarca, colModelo, colNumeroSerie, colSala, colAno, colPreco, colEstado, colValorAtual });
            lvEquipamentos.FullRowSelect = true;
            lvEquipamentos.GridLines = true;
            lvEquipamentos.Location = new System.Drawing.Point(12, 88);
            lvEquipamentos.MultiSelect = false;
            lvEquipamentos.Name = "lvEquipamentos";
            lvEquipamentos.Size = new System.Drawing.Size(790, 440);
            lvEquipamentos.TabIndex = 11;
            lvEquipamentos.UseCompatibleStateImageBehavior = false;
            lvEquipamentos.View = System.Windows.Forms.View.Details;
            lvEquipamentos.SelectedIndexChanged += lvEquipamentos_SelectedIndexChanged;
            lvEquipamentos.DoubleClick += lvEquipamentos_DoubleClick;
            // 
            // colId
            // 
            colId.Text = "Id";
            colId.Width = 40;
            // 
            // colTipo
            // 
            colTipo.Text = "Tipo";
            colTipo.Width = 85;
            // 
            // colMarca
            // 
            colMarca.Text = "Marca";
            colMarca.Width = 70;
            // 
            // colModelo
            // 
            colModelo.Text = "Modelo";
            colModelo.Width = 115;
            // 
            // colNumeroSerie
            // 
            colNumeroSerie.Text = "N.º de série";
            colNumeroSerie.Width = 95;
            // 
            // colSala
            // 
            colSala.Text = "Sala";
            colSala.Width = 85;
            // 
            // colAno
            // 
            colAno.Text = "Ano";
            colAno.Width = 45;
            // 
            // colPreco
            // 
            colPreco.Text = "Preço";
            colPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            colPreco.Width = 80;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 85;
            // 
            // colValorAtual
            // 
            colValorAtual.Text = "Valor atual";
            colValorAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            colValorAtual.Width = 80;
            // 
            // lblDetalhes
            // 
            lblDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblDetalhes.AutoSize = true;
            lblDetalhes.Location = new System.Drawing.Point(815, 68);
            lblDetalhes.Name = "lblDetalhes";
            lblDetalhes.Size = new System.Drawing.Size(52, 15);
            lblDetalhes.TabIndex = 12;
            lblDetalhes.Text = "Detalhes";
            // 
            // txtDetalhes
            // 
            txtDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            txtDetalhes.Location = new System.Drawing.Point(815, 88);
            txtDetalhes.Multiline = true;
            txtDetalhes.Name = "txtDetalhes";
            txtDetalhes.ReadOnly = true;
            txtDetalhes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDetalhes.Size = new System.Drawing.Size(223, 440);
            txtDetalhes.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAdicionar.Location = new System.Drawing.Point(12, 538);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new System.Drawing.Size(110, 30);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnEditar.Location = new System.Drawing.Point(128, 538);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(110, 30);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRemover.Location = new System.Drawing.Point(244, 538);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new System.Drawing.Size(110, 30);
            btnRemover.TabIndex = 16;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblResumo
            // 
            lblResumo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblResumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblResumo.Location = new System.Drawing.Point(12, 576);
            lblResumo.Name = "lblResumo";
            lblResumo.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            lblResumo.Size = new System.Drawing.Size(1026, 42);
            lblResumo.TabIndex = 17;
            lblResumo.Text = "Resumo";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1050, 630);
            Controls.Add(lblResumo);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtDetalhes);
            Controls.Add(lblDetalhes);
            Controls.Add(lvEquipamentos);
            Controls.Add(btnAlterarResponsavel);
            Controls.Add(txtResponsavel);
            Controls.Add(lblResponsavel);
            Controls.Add(btnPoucaRam);
            Controls.Add(btnImpressorasCores);
            Controls.Add(cmbFiltroEstado);
            Controls.Add(lblFiltroEstado);
            Controls.Add(btnMostrarTodos);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(lblPesquisa);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MinimumSize = new System.Drawing.Size(900, 500);
            Name = "FormPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gestão de Equipamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Button btnImpressorasCores;
        private System.Windows.Forms.Button btnPoucaRam;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Button btnAlterarResponsavel;
        private System.Windows.Forms.ListView lvEquipamentos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colModelo;
        private System.Windows.Forms.ColumnHeader colNumeroSerie;
        private System.Windows.Forms.ColumnHeader colSala;
        private System.Windows.Forms.ColumnHeader colAno;
        private System.Windows.Forms.ColumnHeader colPreco;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ColumnHeader colValorAtual;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblResumo;
    }
}
