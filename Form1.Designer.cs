namespace notetakingapp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            dgvCaixa = new DataGridView();
            txtTitulo = new TextBox();
            txtMensagem = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnLer = new Button();
            btnDEL = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Título";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Mensagem";
            // 
            // dgvCaixa
            // 
            dgvCaixa.AllowUserToAddRows = false;
            dgvCaixa.AllowUserToDeleteRows = false;
            dgvCaixa.AllowUserToResizeColumns = false;
            dgvCaixa.AllowUserToResizeRows = false;
            dgvCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaixa.Location = new Point(333, 12);
            dgvCaixa.Name = "dgvCaixa";
            dgvCaixa.ReadOnly = true;
            dgvCaixa.RowHeadersVisible = false;
            dgvCaixa.Size = new Size(300, 237);
            dgvCaixa.TabIndex = 6;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(89, 33);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(189, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(91, 72);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(236, 178);
            txtMensagem.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Lime;
            btnNovo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = SystemColors.ControlText;
            btnNovo.Location = new Point(21, 280);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(104, 65);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ControlText;
            btnSalvar.Location = new Point(174, 280);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(104, 65);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLer
            // 
            btnLer.BackColor = Color.Lime;
            btnLer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLer.ForeColor = SystemColors.ControlText;
            btnLer.Location = new Point(333, 280);
            btnLer.Name = "btnLer";
            btnLer.Size = new Size(104, 65);
            btnLer.TabIndex = 4;
            btnLer.Text = "Ler";
            btnLer.UseVisualStyleBackColor = false;
            btnLer.Click += btnLer_Click;
            // 
            // btnDEL
            // 
            btnDEL.BackColor = Color.Lime;
            btnDEL.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDEL.ForeColor = SystemColors.ControlText;
            btnDEL.Location = new Point(498, 280);
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(104, 65);
            btnDEL.TabIndex = 5;
            btnDEL.Text = "Apagar";
            btnDEL.UseVisualStyleBackColor = false;
            btnDEL.Click += btnDEL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDEL);
            Controls.Add(btnLer);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(txtMensagem);
            Controls.Add(txtTitulo);
            Controls.Add(dgvCaixa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvCaixa;
        private TextBox txtTitulo;
        private TextBox txtMensagem;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnLer;
        private Button btnDEL;
    }
}
