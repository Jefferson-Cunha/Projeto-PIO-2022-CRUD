namespace projetoContasemDia_0._0._1
{
    partial class telaNovaConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaNovaConta));
            this.lnkFooter = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTpConta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVlConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrestador = new System.Windows.Forms.TextBox();
            this.DtVenci = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCampoVazio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkFooter
            // 
            this.lnkFooter.AutoSize = true;
            this.lnkFooter.BackColor = System.Drawing.Color.Transparent;
            this.lnkFooter.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Italic);
            this.lnkFooter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnkFooter.Location = new System.Drawing.Point(288, 489);
            this.lnkFooter.Name = "lnkFooter";
            this.lnkFooter.Size = new System.Drawing.Size(118, 21);
            this.lnkFooter.TabIndex = 38;
            this.lnkFooter.TabStop = true;
            this.lnkFooter.Text = "Contas em Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Bonde do TI Sem Freio © 2022  by ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(67, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 92);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Preencha os campos a seguir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(62, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Titulo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTpConta
            // 
            this.txtTpConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTpConta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTpConta.Location = new System.Drawing.Point(197, 224);
            this.txtTpConta.Name = "txtTpConta";
            this.txtTpConta.Size = new System.Drawing.Size(163, 22);
            this.txtTpConta.TabIndex = 42;
            this.txtTpConta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(63, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor da conta:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtVlConta
            // 
            this.txtVlConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlConta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlConta.HideSelection = false;
            this.txtVlConta.Location = new System.Drawing.Point(197, 266);
            this.txtVlConta.Name = "txtVlConta";
            this.txtVlConta.Size = new System.Drawing.Size(163, 22);
            this.txtVlConta.TabIndex = 44;
            this.txtVlConta.Text = "R$";
            this.txtVlConta.WordWrap = false;
            this.txtVlConta.TextChanged += new System.EventHandler(this.txtVlConta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(62, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Data de Venc:";
            // 
            // txtPrestador
            // 
            this.txtPrestador.AcceptsReturn = true;
            this.txtPrestador.AcceptsTab = true;
            this.txtPrestador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrestador.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrestador.Location = new System.Drawing.Point(198, 309);
            this.txtPrestador.Name = "txtPrestador";
            this.txtPrestador.Size = new System.Drawing.Size(163, 22);
            this.txtPrestador.TabIndex = 48;
            this.txtPrestador.Tag = "";
            this.txtPrestador.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // DtVenci
            // 
            this.DtVenci.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtVenci.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.DtVenci.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtVenci.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtVenci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtVenci.Location = new System.Drawing.Point(197, 349);
            this.DtVenci.Name = "DtVenci";
            this.DtVenci.Size = new System.Drawing.Size(163, 23);
            this.DtVenci.TabIndex = 49;
            this.DtVenci.UseWaitCursor = true;
            this.DtVenci.Value = new System.DateTime(2022, 5, 12, 15, 4, 23, 0);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(134, 412);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(155, 31);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCampoVazio
            // 
            this.txtCampoVazio.AutoSize = true;
            this.txtCampoVazio.BackColor = System.Drawing.Color.Transparent;
            this.txtCampoVazio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampoVazio.ForeColor = System.Drawing.Color.Red;
            this.txtCampoVazio.Location = new System.Drawing.Point(114, 385);
            this.txtCampoVazio.Name = "txtCampoVazio";
            this.txtCampoVazio.Size = new System.Drawing.Size(0, 15);
            this.txtCampoVazio.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(63, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cod Próprio:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // telaNovaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 515);
            this.Controls.Add(this.txtCampoVazio);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.DtVenci);
            this.Controls.Add(this.txtPrestador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVlConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTpConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkFooter);
            this.Controls.Add(this.label2);
            this.Name = "telaNovaConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Conta";
            this.Load += new System.EventHandler(this.telaNovaConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTpConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVlConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrestador;
        public System.Windows.Forms.DateTimePicker DtVenci;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label txtCampoVazio;
        private System.Windows.Forms.Label label6;
    }
}