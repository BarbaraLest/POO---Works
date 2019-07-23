namespace WindowsFormsApp
{
    partial class Form1
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.lbIdade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMostra1 = new System.Windows.Forms.TextBox();
            this.txtMostrar2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(119, 47);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 22);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // tbIdade
            // 
            this.tbIdade.Location = new System.Drawing.Point(119, 99);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(100, 22);
            this.tbIdade.TabIndex = 1;
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(13, 104);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(47, 17);
            this.lbIdade.TabIndex = 3;
            this.lbIdade.Text = "Idade:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(16, 243);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.Size = new System.Drawing.Size(417, 439);
            this.dgvDados.TabIndex = 5;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            this.dgvDados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDados_DataBindingComplete);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(16, 47);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 17);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 82);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mostrar conteudo da linha selecionada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Os dados inseridos nessa linha são:";
            this.label1.Visible = false;
            // 
            // txtMostra1
            // 
            this.txtMostra1.Location = new System.Drawing.Point(538, 390);
            this.txtMostra1.Name = "txtMostra1";
            this.txtMostra1.Size = new System.Drawing.Size(165, 22);
            this.txtMostra1.TabIndex = 8;
            this.txtMostra1.Visible = false;
            this.txtMostra1.TextChanged += new System.EventHandler(this.txtAlteracao_TextChanged);
            // 
            // txtMostrar2
            // 
            this.txtMostrar2.Location = new System.Drawing.Point(538, 453);
            this.txtMostrar2.Name = "txtMostrar2";
            this.txtMostrar2.Size = new System.Drawing.Size(100, 22);
            this.txtMostrar2.TabIndex = 10;
            this.txtMostrar2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 721);
            this.Controls.Add(this.txtMostrar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMostra1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.tbNome);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMostra1;
        private System.Windows.Forms.TextBox txtMostrar2;
    }
}

