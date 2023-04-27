namespace prj_SalaoBeleza.View
{
    partial class Frm_CadClie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadClie));
            this.txtb_Nome = new System.Windows.Forms.TextBox();
            this.txtb_Email = new System.Windows.Forms.TextBox();
            this.txtb_Tel = new System.Windows.Forms.TextBox();
            this.txtb_Ender = new System.Windows.Forms.TextBox();
            this.txtb_Cid = new System.Windows.Forms.TextBox();
            this.txtb_Esta = new System.Windows.Forms.TextBox();
            this.txtb_Pais = new System.Windows.Forms.TextBox();
            this.btn_Cad = new System.Windows.Forms.Button();
            this.btn_Limp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Nome.Location = new System.Drawing.Point(126, 135);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(161, 29);
            this.txtb_Nome.TabIndex = 0;
            // 
            // txtb_Email
            // 
            this.txtb_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Email.Location = new System.Drawing.Point(126, 194);
            this.txtb_Email.Name = "txtb_Email";
            this.txtb_Email.Size = new System.Drawing.Size(161, 29);
            this.txtb_Email.TabIndex = 1;
            // 
            // txtb_Tel
            // 
            this.txtb_Tel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Tel.Location = new System.Drawing.Point(126, 251);
            this.txtb_Tel.Name = "txtb_Tel";
            this.txtb_Tel.Size = new System.Drawing.Size(161, 29);
            this.txtb_Tel.TabIndex = 2;
            // 
            // txtb_Ender
            // 
            this.txtb_Ender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Ender.Location = new System.Drawing.Point(126, 304);
            this.txtb_Ender.Name = "txtb_Ender";
            this.txtb_Ender.Size = new System.Drawing.Size(161, 29);
            this.txtb_Ender.TabIndex = 3;
            // 
            // txtb_Cid
            // 
            this.txtb_Cid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Cid.Location = new System.Drawing.Point(366, 147);
            this.txtb_Cid.Name = "txtb_Cid";
            this.txtb_Cid.Size = new System.Drawing.Size(161, 29);
            this.txtb_Cid.TabIndex = 4;
            // 
            // txtb_Esta
            // 
            this.txtb_Esta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Esta.Location = new System.Drawing.Point(366, 211);
            this.txtb_Esta.Name = "txtb_Esta";
            this.txtb_Esta.Size = new System.Drawing.Size(161, 29);
            this.txtb_Esta.TabIndex = 5;
            // 
            // txtb_Pais
            // 
            this.txtb_Pais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Pais.Location = new System.Drawing.Point(366, 275);
            this.txtb_Pais.Name = "txtb_Pais";
            this.txtb_Pais.Size = new System.Drawing.Size(161, 29);
            this.txtb_Pais.TabIndex = 6;
            // 
            // btn_Cad
            // 
            this.btn_Cad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cad.Location = new System.Drawing.Point(199, 395);
            this.btn_Cad.Name = "btn_Cad";
            this.btn_Cad.Size = new System.Drawing.Size(143, 34);
            this.btn_Cad.TabIndex = 7;
            this.btn_Cad.Text = "Cadastrar";
            this.btn_Cad.UseVisualStyleBackColor = true;
            // 
            // btn_Limp
            // 
            this.btn_Limp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Limp.Location = new System.Drawing.Point(423, 395);
            this.btn_Limp.Name = "btn_Limp";
            this.btn_Limp.Size = new System.Drawing.Size(143, 34);
            this.btn_Limp.TabIndex = 8;
            this.btn_Limp.Text = "Limpar";
            this.btn_Limp.UseVisualStyleBackColor = true;
            this.btn_Limp.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_CadClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Limp);
            this.Controls.Add(this.btn_Cad);
            this.Controls.Add(this.txtb_Pais);
            this.Controls.Add(this.txtb_Esta);
            this.Controls.Add(this.txtb_Cid);
            this.Controls.Add(this.txtb_Ender);
            this.Controls.Add(this.txtb_Tel);
            this.Controls.Add(this.txtb_Email);
            this.Controls.Add(this.txtb_Nome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CadClie";
            this.Text = "CADASTRO CLIENTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtb_Nome;
        private TextBox txtb_Email;
        private TextBox txtb_Tel;
        private TextBox txtb_Ender;
        private TextBox txtb_Cid;
        private TextBox txtb_Esta;
        private TextBox txtb_Pais;
        private Button btn_Cad;
        private Button btn_Limp;
    }
}