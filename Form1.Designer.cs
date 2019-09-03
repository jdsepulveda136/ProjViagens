namespace ProjViagens
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
            this.cmb_veiculo = new System.Windows.Forms.ComboBox();
            this.lbl_veiculo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_calcula = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_copia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_veiculo
            // 
            this.cmb_veiculo.FormattingEnabled = true;
            this.cmb_veiculo.Location = new System.Drawing.Point(80, 156);
            this.cmb_veiculo.Name = "cmb_veiculo";
            this.cmb_veiculo.Size = new System.Drawing.Size(121, 21);
            this.cmb_veiculo.TabIndex = 0;
            // 
            // lbl_veiculo
            // 
            this.lbl_veiculo.AutoSize = true;
            this.lbl_veiculo.Location = new System.Drawing.Point(121, 140);
            this.lbl_veiculo.Name = "lbl_veiculo";
            this.lbl_veiculo.Size = new System.Drawing.Size(44, 13);
            this.lbl_veiculo.TabIndex = 1;
            this.lbl_veiculo.Text = "Veículo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 118);
            this.dataGridView1.TabIndex = 2;
            // 
            // bt_calcula
            // 
            this.bt_calcula.Location = new System.Drawing.Point(80, 184);
            this.bt_calcula.Name = "bt_calcula";
            this.bt_calcula.Size = new System.Drawing.Size(121, 23);
            this.bt_calcula.TabIndex = 3;
            this.bt_calcula.Text = "Calcular";
            this.bt_calcula.UseVisualStyleBackColor = true;
            this.bt_calcula.Click += new System.EventHandler(this.Bt_calcula_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(80, 214);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(121, 20);
            this.txt_result.TabIndex = 4;
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(104, 292);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 5;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.Bt_sair_Click);
            // 
            // bt_copia
            // 
            this.bt_copia.Location = new System.Drawing.Point(80, 241);
            this.bt_copia.Name = "bt_copia";
            this.bt_copia.Size = new System.Drawing.Size(121, 23);
            this.bt_copia.TabIndex = 6;
            this.bt_copia.Text = "Copiar";
            this.bt_copia.UseVisualStyleBackColor = true;
            this.bt_copia.Click += new System.EventHandler(this.Bt_copia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 327);
            this.Controls.Add(this.bt_copia);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.bt_calcula);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_veiculo);
            this.Controls.Add(this.cmb_veiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_veiculo;
        private System.Windows.Forms.Label lbl_veiculo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_calcula;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_copia;
    }
}

