namespace AQUA_DATA
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
            this.txtInserir = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTesteSelectBanco = new System.Windows.Forms.TextBox();
            this.cboTeste = new System.Windows.Forms.ComboBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInserir
            // 
            this.txtInserir.Location = new System.Drawing.Point(12, 12);
            this.txtInserir.Name = "txtInserir";
            this.txtInserir.Size = new System.Drawing.Size(304, 20);
            this.txtInserir.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 38);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(304, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadGrid
            // 
            this.btnLoadGrid.Location = new System.Drawing.Point(12, 78);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(304, 23);
            this.btnLoadGrid.TabIndex = 2;
            this.btnLoadGrid.Text = "LoadGrid";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtTesteSelectBanco
            // 
            this.txtTesteSelectBanco.Location = new System.Drawing.Point(12, 276);
            this.txtTesteSelectBanco.Name = "txtTesteSelectBanco";
            this.txtTesteSelectBanco.Size = new System.Drawing.Size(304, 20);
            this.txtTesteSelectBanco.TabIndex = 4;
            // 
            // cboTeste
            // 
            this.cboTeste.FormattingEnabled = true;
            this.cboTeste.Location = new System.Drawing.Point(12, 344);
            this.cboTeste.Name = "cboTeste";
            this.cboTeste.Size = new System.Drawing.Size(304, 21);
            this.cboTeste.TabIndex = 5;
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(12, 315);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(304, 23);
            this.btnCombo.TabIndex = 6;
            this.btnCombo.Text = "Carregar Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Location = new System.Drawing.Point(9, 260);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(307, 13);
            this.lblGrid.TabIndex = 7;
            this.lblGrid.Text = "Clique no código da célula para exibir o nome no textbox abaixo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 376);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.cboTeste);
            this.Controls.Add(this.txtTesteSelectBanco);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadGrid);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtInserir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInserir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTesteSelectBanco;
        private System.Windows.Forms.ComboBox cboTeste;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Label lblGrid;
    }
}

