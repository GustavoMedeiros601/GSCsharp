namespace SafeRoute.Client.Views
{
    partial class MainForm
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
            txtOrigem = new System.Windows.Forms.TextBox();
            txtDestino = new System.Windows.Forms.TextBox();
            lblOrigem = new System.Windows.Forms.Label();
            lblDestino = new System.Windows.Forms.Label();
            btnCadastrar = new System.Windows.Forms.Button();
            btnListar = new System.Windows.Forms.Button();
            dgvPedidos = new System.Windows.Forms.DataGridView();
            btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // txtOrigem
            // 
            txtOrigem.Location = new System.Drawing.Point(97, 20);
            txtOrigem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new System.Drawing.Size(228, 27);
            txtOrigem.TabIndex = 0;
            // 
            // txtDestino
            // 
            txtDestino.Location = new System.Drawing.Point(97, 59);
            txtDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new System.Drawing.Size(228, 27);
            txtDestino.TabIndex = 1;
            // 
            // lblOrigem
            // 
            lblOrigem.AutoSize = true;
            lblOrigem.Location = new System.Drawing.Point(26, 24);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new System.Drawing.Size(62, 20);
            lblOrigem.TabIndex = 2;
            lblOrigem.Text = "Origem:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new System.Drawing.Point(26, 63);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new System.Drawing.Size(63, 20);
            lblDestino.TabIndex = 3;
            lblDestino.Text = "Destino:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new System.Drawing.Point(354, 20);
            btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(137, 31);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Pedido";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new System.Drawing.Point(354, 59);
            btnListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new System.Drawing.Size(137, 31);
            btnListar.TabIndex = 5;
            btnListar.Text = "Listar Pedidos";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new System.Drawing.Point(26, 111);
            dgvPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.Size = new System.Drawing.Size(640, 333);
            dgvPedidos.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(546, 24);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(120, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar Pedido";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 473);
            Controls.Add(dgvPedidos);
            Controls.Add(btnListar);
            Controls.Add(btnCadastrar);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigem);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigem);
            Controls.Add(btnCancelar);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "SafeRoute Client";
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnCancelar;

    }
}
