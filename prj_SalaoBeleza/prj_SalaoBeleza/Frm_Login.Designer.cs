namespace prj_SalaoBeleza
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txtb_Nome = new System.Windows.Forms.TextBox();
            this.txtb_Senha = new System.Windows.Forms.TextBox();
            this.btn_Acessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Nome.Location = new System.Drawing.Point(186, 152);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(225, 29);
            this.txtb_Nome.TabIndex = 0;
            // 
            // txtb_Senha
            // 
            this.txtb_Senha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Senha.Location = new System.Drawing.Point(186, 230);
            this.txtb_Senha.Name = "txtb_Senha";
            this.txtb_Senha.Size = new System.Drawing.Size(225, 29);
            this.txtb_Senha.TabIndex = 1;
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.Location = new System.Drawing.Point(225, 282);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Size = new System.Drawing.Size(138, 32);
            this.btn_Acessar.TabIndex = 2;
            this.btn_Acessar.Text = "Acessar";
            this.btn_Acessar.UseVisualStyleBackColor = true;
            this.btn_Acessar.Visible = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 395);
            this.Controls.Add(this.btn_Acessar);
            this.Controls.Add(this.txtb_Senha);
            this.Controls.Add(this.txtb_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtb_Nome;
        private TextBox txtb_Senha;
        private Button btn_Acessar;
    }
}