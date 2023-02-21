namespace projetoContasemDia_0._0._1
{
    partial class telaAreaLogada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaAreaLogada));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logoContasemDia = new System.Windows.Forms.PictureBox();
            this.lnkFooter = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarCelularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dbUsuarioDataSet = new projetoContasemDia_0._0._1.dbUsuarioDataSet();
            this.tbContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContasTableAdapter = new projetoContasemDia_0._0._1.dbUsuarioDataSetTableAdapters.tbContasTableAdapter();
            this.dtContas = new System.Windows.Forms.DataGridView();
            this.tpContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProprioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logoContasemDia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContas)).BeginInit();
            this.SuspendLayout();
            // 
            // logoContasemDia
            // 
            this.logoContasemDia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoContasemDia.BackgroundImage")));
            this.logoContasemDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoContasemDia.Location = new System.Drawing.Point(243, 12);
            this.logoContasemDia.Name = "logoContasemDia";
            this.logoContasemDia.Size = new System.Drawing.Size(289, 97);
            this.logoContasemDia.TabIndex = 0;
            this.logoContasemDia.TabStop = false;
            this.logoContasemDia.Tag = "logoContasemDia";
            // 
            // lnkFooter
            // 
            this.lnkFooter.AutoSize = true;
            this.lnkFooter.BackColor = System.Drawing.Color.Transparent;
            this.lnkFooter.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Italic);
            this.lnkFooter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnkFooter.Location = new System.Drawing.Point(465, 477);
            this.lnkFooter.Name = "lnkFooter";
            this.lnkFooter.Size = new System.Drawing.Size(118, 21);
            this.lnkFooter.TabIndex = 36;
            this.lnkFooter.TabStop = true;
            this.lnkFooter.Text = "Contas em Dia";
            this.lnkFooter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFooter_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bonde do TI Sem Freio © 2022  by ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarEmailToolStripMenuItem,
            this.atualizarSenhaToolStripMenuItem,
            this.atualizarCelularToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // atualizarEmailToolStripMenuItem
            // 
            this.atualizarEmailToolStripMenuItem.Name = "atualizarEmailToolStripMenuItem";
            this.atualizarEmailToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.atualizarEmailToolStripMenuItem.Text = "Atualizar E-mail";
            this.atualizarEmailToolStripMenuItem.Click += new System.EventHandler(this.atualizarEmailToolStripMenuItem_Click);
            // 
            // atualizarSenhaToolStripMenuItem
            // 
            this.atualizarSenhaToolStripMenuItem.Name = "atualizarSenhaToolStripMenuItem";
            this.atualizarSenhaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.atualizarSenhaToolStripMenuItem.Text = "Atualizar Senha";
            this.atualizarSenhaToolStripMenuItem.Click += new System.EventHandler(this.atualizarSenhaToolStripMenuItem_Click);
            // 
            // atualizarCelularToolStripMenuItem
            // 
            this.atualizarCelularToolStripMenuItem.Name = "atualizarCelularToolStripMenuItem";
            this.atualizarCelularToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.atualizarCelularToolStripMenuItem.Text = "Atualizar Celular";
            this.atualizarCelularToolStripMenuItem.Click += new System.EventHandler(this.atualizarCelularToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btnAcessar
            // 
            this.btnAcessar.AutoSize = true;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAcessar.Location = new System.Drawing.Point(75, 231);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(151, 34);
            this.btnAcessar.TabIndex = 38;
            this.btnAcessar.Text = "Nova Conta";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(75, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 39;
            this.button1.Text = "Editar Conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(75, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 34);
            this.button2.TabIndex = 40;
            this.button2.Text = "Excluír";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(75, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 34);
            this.button3.TabIndex = 43;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dbUsuarioDataSet
            // 
            this.dbUsuarioDataSet.DataSetName = "dbUsuarioDataSet";
            this.dbUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbContasBindingSource
            // 
            this.tbContasBindingSource.DataMember = "tbContas";
            this.tbContasBindingSource.DataSource = this.dbUsuarioDataSet;
            // 
            // tbContasTableAdapter
            // 
            this.tbContasTableAdapter.ClearBeforeFill = true;
            // 
            // dtContas
            // 
            this.dtContas.AllowUserToAddRows = false;
            this.dtContas.AllowUserToDeleteRows = false;
            this.dtContas.AutoGenerateColumns = false;
            this.dtContas.BackgroundColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tpContaDataGridViewTextBoxColumn,
            this.vlContaDataGridViewTextBoxColumn,
            this.codProprioDataGridViewTextBoxColumn,
            this.dtVencimentoDataGridViewTextBoxColumn});
            this.dtContas.DataSource = this.tbContasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtContas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtContas.GridColor = System.Drawing.Color.Black;
            this.dtContas.Location = new System.Drawing.Point(263, 231);
            this.dtContas.Name = "dtContas";
            this.dtContas.ReadOnly = true;
            this.dtContas.Size = new System.Drawing.Size(444, 216);
            this.dtContas.TabIndex = 44;
            // 
            // tpContaDataGridViewTextBoxColumn
            // 
            this.tpContaDataGridViewTextBoxColumn.DataPropertyName = "TpConta";
            this.tpContaDataGridViewTextBoxColumn.HeaderText = "Conta";
            this.tpContaDataGridViewTextBoxColumn.Name = "tpContaDataGridViewTextBoxColumn";
            this.tpContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vlContaDataGridViewTextBoxColumn
            // 
            this.vlContaDataGridViewTextBoxColumn.DataPropertyName = "VlConta";
            this.vlContaDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vlContaDataGridViewTextBoxColumn.Name = "vlContaDataGridViewTextBoxColumn";
            this.vlContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codProprioDataGridViewTextBoxColumn
            // 
            this.codProprioDataGridViewTextBoxColumn.DataPropertyName = "CodProprio";
            this.codProprioDataGridViewTextBoxColumn.HeaderText = "Cod Proprio";
            this.codProprioDataGridViewTextBoxColumn.Name = "codProprioDataGridViewTextBoxColumn";
            this.codProprioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtVencimentoDataGridViewTextBoxColumn
            // 
            this.dtVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DtVencimento";
            this.dtVencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento";
            this.dtVencimentoDataGridViewTextBoxColumn.Name = "dtVencimentoDataGridViewTextBoxColumn";
            this.dtVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telaAreaLogada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 507);
            this.Controls.Add(this.dtContas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.lnkFooter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoContasemDia);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telaAreaLogada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas em Dia";
            this.Load += new System.EventHandler(this.telaAreaLogada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoContasemDia)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoContasemDia;
        private System.Windows.Forms.LinkLabel lnkFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarCelularToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private dbUsuarioDataSet dbUsuarioDataSet;
        private System.Windows.Forms.BindingSource tbContasBindingSource;
        private dbUsuarioDataSetTableAdapters.tbContasTableAdapter tbContasTableAdapter;
        private System.Windows.Forms.DataGridView dtContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProprioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVencimentoDataGridViewTextBoxColumn;
    }
}