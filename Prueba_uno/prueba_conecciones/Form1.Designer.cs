namespace prueba_conecciones
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
            this.dgvTablaAgentes = new System.Windows.Forms.DataGridView();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAgentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaAgentes
            // 
            this.dgvTablaAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaAgentes.Location = new System.Drawing.Point(80, 44);
            this.dgvTablaAgentes.Name = "dgvTablaAgentes";
            this.dgvTablaAgentes.Size = new System.Drawing.Size(377, 342);
            this.dgvTablaAgentes.TabIndex = 0;
            this.dgvTablaAgentes.SelectionChanged += new System.EventHandler(this.dgvTablaAgentes_SelectionChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(482, 44);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(237, 230);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(80, 415);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Alta Agente";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.dgvTablaAgentes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAgentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaAgentes;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnAlta;
    }
}

