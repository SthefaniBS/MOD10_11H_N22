namespace GestaoEquipamentos.Interface
{
    partial class FormEquipamento
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
            lblTipo = new System.Windows.Forms.Label();
            cmbTipo = new System.Windows.Forms.ComboBox();
            lblMarca = new System.Windows.Forms.Label();
            txtMarca = new System.Windows.Forms.TextBox();
            lblModelo = new System.Windows.Forms.Label();
            txtModelo = new System.Windows.Forms.TextBox();
            lblNumeroSerie = new System.Windows.Forms.Label();
            txtNumeroSerie = new System.Windows.Forms.TextBox();
            lblSala = new System.Windows.Forms.Label();
            txtSala = new System.Windows.Forms.TextBox();
            lblAno = new System.Windows.Forms.Label();
            nudAno = new System.Windows.Forms.NumericUpDown();
            lblPreco = new System.Windows.Forms.Label();
            nudPreco = new System.Windows.Forms.NumericUpDown();
            lblEstado = new System.Windows.Forms.Label();
            cmbEstado = new System.Windows.Forms.ComboBox();
            grpComputador = new System.Windows.Forms.GroupBox();
            chkSSD = new System.Windows.Forms.CheckBox();
            nudRam = new System.Windows.Forms.NumericUpDown();
            lblRam = new System.Windows.Forms.Label();
            grpImpressora = new System.Windows.Forms.GroupBox();
            chkCores = new System.Windows.Forms.CheckBox();
            grpProjetor = new System.Windows.Forms.GroupBox();
            nudLumens = new System.Windows.Forms.NumericUpDown();
            lblLumens = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudAno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            grpComputador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRam).BeginInit();
            grpImpressora.SuspendLayout();
            grpProjetor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLumens).BeginInit();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new System.Drawing.Point(15, 21);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(34, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTipo.Enabled = false;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Computador", "Impressora", "Projetor" });
            cmbTipo.Location = new System.Drawing.Point(130, 17);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(150, 23);
            cmbTipo.TabIndex = 1;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new System.Drawing.Point(15, 54);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(43, 15);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new System.Drawing.Point(130, 50);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new System.Drawing.Size(150, 23);
            txtMarca.TabIndex = 3;
            txtMarca.TextChanged += txtMarca_TextChanged;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new System.Drawing.Point(15, 87);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new System.Drawing.Size(51, 15);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new System.Drawing.Point(130, 83);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new System.Drawing.Size(150, 23);
            txtModelo.TabIndex = 5;
            // 
            // lblNumeroSerie
            // 
            lblNumeroSerie.AutoSize = true;
            lblNumeroSerie.Location = new System.Drawing.Point(15, 120);
            lblNumeroSerie.Name = "lblNumeroSerie";
            lblNumeroSerie.Size = new System.Drawing.Size(70, 15);
            lblNumeroSerie.TabIndex = 6;
            lblNumeroSerie.Text = "N.º de série:";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtNumeroSerie.Location = new System.Drawing.Point(130, 116);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new System.Drawing.Size(150, 23);
            txtNumeroSerie.TabIndex = 7;
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new System.Drawing.Point(15, 153);
            lblSala.Name = "lblSala";
            lblSala.Size = new System.Drawing.Size(31, 15);
            lblSala.TabIndex = 8;
            lblSala.Text = "Sala:";
            // 
            // txtSala
            // 
            txtSala.Location = new System.Drawing.Point(130, 149);
            txtSala.Name = "txtSala";
            txtSala.Size = new System.Drawing.Size(150, 23);
            txtSala.TabIndex = 9;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new System.Drawing.Point(15, 186);
            lblAno.Name = "lblAno";
            lblAno.Size = new System.Drawing.Size(101, 15);
            lblAno.TabIndex = 10;
            lblAno.Text = "Ano de aquisição:";
            // 
            // nudAno
            // 
            nudAno.Location = new System.Drawing.Point(130, 182);
            nudAno.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudAno.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            nudAno.Name = "nudAno";
            nudAno.Size = new System.Drawing.Size(80, 23);
            nudAno.TabIndex = 11;
            nudAno.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new System.Drawing.Point(15, 219);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new System.Drawing.Size(109, 15);
            lblPreco.TabIndex = 12;
            lblPreco.Text = "Preço de compra €:";
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudPreco.Location = new System.Drawing.Point(130, 215);
            nudPreco.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new System.Drawing.Size(100, 23);
            nudPreco.TabIndex = 13;
            nudPreco.ThousandsSeparator = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new System.Drawing.Point(15, 252);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(45, 15);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEstado.Enabled = false;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new System.Drawing.Point(130, 248);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new System.Drawing.Size(150, 23);
            cmbEstado.TabIndex = 15;
            // 
            // grpComputador
            // 
            grpComputador.Controls.Add(chkSSD);
            grpComputador.Controls.Add(nudRam);
            grpComputador.Controls.Add(lblRam);
            grpComputador.Enabled = false;
            grpComputador.Location = new System.Drawing.Point(305, 12);
            grpComputador.Name = "grpComputador";
            grpComputador.Size = new System.Drawing.Size(240, 90);
            grpComputador.TabIndex = 16;
            grpComputador.TabStop = false;
            grpComputador.Text = "Computador";
            // 
            // chkSSD
            // 
            chkSSD.AutoSize = true;
            chkSSD.Checked = true;
            chkSSD.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSSD.Location = new System.Drawing.Point(15, 58);
            chkSSD.Name = "chkSSD";
            chkSSD.Size = new System.Drawing.Size(78, 19);
            chkSSD.TabIndex = 2;
            chkSSD.Text = "Disco SSD";
            chkSSD.UseVisualStyleBackColor = true;
            // 
            // nudRam
            // 
            nudRam.Location = new System.Drawing.Point(110, 24);
            nudRam.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudRam.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRam.Name = "nudRam";
            nudRam.Size = new System.Drawing.Size(70, 23);
            nudRam.TabIndex = 1;
            nudRam.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Location = new System.Drawing.Point(12, 28);
            lblRam.Name = "lblRam";
            lblRam.Size = new System.Drawing.Size(84, 15);
            lblRam.TabIndex = 0;
            lblRam.Text = "Memória (GB):";
            // 
            // grpImpressora
            // 
            grpImpressora.Controls.Add(chkCores);
            grpImpressora.Enabled = false;
            grpImpressora.Location = new System.Drawing.Point(305, 110);
            grpImpressora.Name = "grpImpressora";
            grpImpressora.Size = new System.Drawing.Size(240, 60);
            grpImpressora.TabIndex = 17;
            grpImpressora.TabStop = false;
            grpImpressora.Text = "Impressora";
            // 
            // chkCores
            // 
            chkCores.AutoSize = true;
            chkCores.Location = new System.Drawing.Point(15, 26);
            chkCores.Name = "chkCores";
            chkCores.Size = new System.Drawing.Size(111, 19);
            chkCores.TabIndex = 0;
            chkCores.Text = "Imprime a cores";
            chkCores.UseVisualStyleBackColor = true;
            // 
            // grpProjetor
            // 
            grpProjetor.Controls.Add(nudLumens);
            grpProjetor.Controls.Add(lblLumens);
            grpProjetor.Enabled = false;
            grpProjetor.Location = new System.Drawing.Point(305, 178);
            grpProjetor.Name = "grpProjetor";
            grpProjetor.Size = new System.Drawing.Size(240, 60);
            grpProjetor.TabIndex = 18;
            grpProjetor.TabStop = false;
            grpProjetor.Text = "Projetor";
            // 
            // nudLumens
            // 
            nudLumens.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudLumens.Location = new System.Drawing.Point(110, 23);
            nudLumens.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            nudLumens.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudLumens.Name = "nudLumens";
            nudLumens.Size = new System.Drawing.Size(90, 23);
            nudLumens.TabIndex = 1;
            nudLumens.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // lblLumens
            // 
            lblLumens.AutoSize = true;
            lblLumens.Location = new System.Drawing.Point(12, 27);
            lblLumens.Name = "lblLumens";
            lblLumens.Size = new System.Drawing.Size(52, 15);
            lblLumens.TabIndex = 0;
            lblLumens.Text = "Lumens:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(335, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(100, 30);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Location = new System.Drawing.Point(445, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 30);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEquipamento
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(560, 335);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpProjetor);
            Controls.Add(grpImpressora);
            Controls.Add(grpComputador);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(nudPreco);
            Controls.Add(lblPreco);
            Controls.Add(nudAno);
            Controls.Add(lblAno);
            Controls.Add(txtSala);
            Controls.Add(lblSala);
            Controls.Add(txtNumeroSerie);
            Controls.Add(lblNumeroSerie);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(txtMarca);
            Controls.Add(lblMarca);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEquipamento";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Equipamento";
            ((System.ComponentModel.ISupportInitialize)nudAno).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            grpComputador.ResumeLayout(false);
            grpComputador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRam).EndInit();
            grpImpressora.ResumeLayout(false);
            grpImpressora.PerformLayout();
            grpProjetor.ResumeLayout(false);
            grpProjetor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLumens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox grpComputador;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.NumericUpDown nudRam;
        private System.Windows.Forms.CheckBox chkSSD;
        private System.Windows.Forms.GroupBox grpImpressora;
        private System.Windows.Forms.CheckBox chkCores;
        private System.Windows.Forms.GroupBox grpProjetor;
        private System.Windows.Forms.Label lblLumens;
        private System.Windows.Forms.NumericUpDown nudLumens;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
