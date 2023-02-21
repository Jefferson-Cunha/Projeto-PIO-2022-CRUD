namespace projetoContasemDia_0._0._1
{
    partial class telaCadastroCriado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCadastroCriado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCadastroCriado = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-148, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 457);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtCadastroCriado
            // 
            this.txtCadastroCriado.AutoSize = true;
            this.txtCadastroCriado.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtCadastroCriado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCadastroCriado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroCriado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCadastroCriado.Location = new System.Drawing.Point(43, 323);
            this.txtCadastroCriado.Name = "txtCadastroCriado";
            this.txtCadastroCriado.Size = new System.Drawing.Size(252, 22);
            this.txtCadastroCriado.TabIndex = 49;
            this.txtCadastroCriado.Text = "Cadastro criado com sucesso!";
            // 
            // btnAcessar
            // 
            this.btnAcessar.AutoSize = true;
            this.btnAcessar.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.Location = new System.Drawing.Point(81, 366);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(169, 26);
            this.btnAcessar.TabIndex = 53;
            this.btnAcessar.Text = "Fechar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // telaCadastroCriado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.txtCadastroCriado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "telaCadastroCriado";
            this.Text = "Cadastro Criado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtCadastroCriado;
        private System.Windows.Forms.Button btnAcessar;
    }
}