namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txCodSap = new TextBox();
            btLocalizar = new Button();
            dvFornecedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvFornecedores).BeginInit();
            SuspendLayout();
            // 
            // txCodSap
            // 
            txCodSap.Location = new Point(12, 12);
            txCodSap.Name = "txCodSap";
            txCodSap.Size = new Size(273, 23);
            txCodSap.TabIndex = 0;
            txCodSap.TextChanged += txCodSap_TextChanged;
            // 
            // btLocalizar
            // 
            btLocalizar.Location = new Point(309, 12);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(75, 23);
            btLocalizar.TabIndex = 1;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // dvFornecedores
            // 
            dvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvFornecedores.Location = new Point(12, 53);
            dvFornecedores.Name = "dvFornecedores";
            dvFornecedores.Size = new Size(928, 422);
            dvFornecedores.TabIndex = 2;
            dvFornecedores.CellContentClick += dvFornecedores_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(952, 487);
            Controls.Add(dvFornecedores);
            Controls.Add(btLocalizar);
            Controls.Add(txCodSap);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txCodSap;
        private Button btLocalizar;
        private DataGridView dvFornecedores;
    }
}
