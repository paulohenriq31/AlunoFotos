namespace Sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_escola = new System.Windows.Forms.Button();
            this.btn_cad_escola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_escola
            // 
            this.btn_escola.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_escola.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_escola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_escola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_escola.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_escola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_escola.Image = global::Sistema.Properties.Resources.novo_png;
            this.btn_escola.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_escola.Location = new System.Drawing.Point(196, 55);
            this.btn_escola.Name = "btn_escola";
            this.btn_escola.Size = new System.Drawing.Size(326, 286);
            this.btn_escola.TabIndex = 1;
            this.btn_escola.Text = "ESCOLHER ESCOLAS";
            this.btn_escola.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_escola.UseVisualStyleBackColor = false;
            this.btn_escola.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_cad_escola
            // 
            this.btn_cad_escola.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_cad_escola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_escola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_escola.Location = new System.Drawing.Point(68, 289);
            this.btn_cad_escola.Name = "btn_cad_escola";
            this.btn_cad_escola.Size = new System.Drawing.Size(90, 52);
            this.btn_cad_escola.TabIndex = 2;
            this.btn_cad_escola.Text = "CADASTRAR ESCOLA";
            this.btn_cad_escola.UseVisualStyleBackColor = false;
            this.btn_cad_escola.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 409);
            this.Controls.Add(this.btn_cad_escola);
            this.Controls.Add(this.btn_escola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_escola;
        private System.Windows.Forms.Button btn_cad_escola;
    }
}

