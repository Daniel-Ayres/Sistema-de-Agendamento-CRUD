namespace prj_SalaoBeleza.View
{
    partial class Frm_CadFunci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadFunci));
            this.txtb_NomFun = new System.Windows.Forms.TextBox();
            this.txtb_NomCarg = new System.Windows.Forms.TextBox();
            this.txtb_TelFun = new System.Windows.Forms.TextBox();
            this.txtb_UsuFun = new System.Windows.Forms.TextBox();
            this.txtb_SenFun = new System.Windows.Forms.TextBox();
            this.btn_CadFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_NomFun
            // 
            this.txtb_NomFun.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_NomFun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_NomFun.Location = new System.Drawing.Point(12, 194);
            this.txtb_NomFun.Name = "txtb_NomFun";
            this.txtb_NomFun.Size = new System.Drawing.Size(195, 34);
            this.txtb_NomFun.TabIndex = 0;
            // 
            // txtb_NomCarg
            // 
            this.txtb_NomCarg.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_NomCarg.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_NomCarg.Location = new System.Drawing.Point(12, 272);
            this.txtb_NomCarg.Name = "txtb_NomCarg";
            this.txtb_NomCarg.Size = new System.Drawing.Size(195, 34);
            this.txtb_NomCarg.TabIndex = 1;
            // 
            // txtb_TelFun
            // 
            this.txtb_TelFun.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_TelFun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_TelFun.Location = new System.Drawing.Point(12, 346);
            this.txtb_TelFun.Name = "txtb_TelFun";
            this.txtb_TelFun.Size = new System.Drawing.Size(195, 34);
            this.txtb_TelFun.TabIndex = 2;
            // 
            // txtb_UsuFun
            // 
            this.txtb_UsuFun.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_UsuFun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_UsuFun.Location = new System.Drawing.Point(236, 206);
            this.txtb_UsuFun.Name = "txtb_UsuFun";
            this.txtb_UsuFun.Size = new System.Drawing.Size(195, 34);
            this.txtb_UsuFun.TabIndex = 3;
            // 
            // txtb_SenFun
            // 
            this.txtb_SenFun.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_SenFun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_SenFun.Location = new System.Drawing.Point(236, 293);
            this.txtb_SenFun.Name = "txtb_SenFun";
            this.txtb_SenFun.Size = new System.Drawing.Size(195, 34);
            this.txtb_SenFun.TabIndex = 4;
            // 
            // btn_CadFun
            // 
            this.btn_CadFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CadFun.BackgroundImage")));
            this.btn_CadFun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CadFun.Location = new System.Drawing.Point(620, 480);
            this.btn_CadFun.Name = "btn_CadFun";
            this.btn_CadFun.Size = new System.Drawing.Size(198, 55);
            this.btn_CadFun.TabIndex = 5;
            this.btn_CadFun.UseVisualStyleBackColor = true;
            this.btn_CadFun.Click += new System.EventHandler(this.btn_CadFun_Click);
            // 
            // Frm_CadFunci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 574);
            this.Controls.Add(this.btn_CadFun);
            this.Controls.Add(this.txtb_SenFun);
            this.Controls.Add(this.txtb_UsuFun);
            this.Controls.Add(this.txtb_TelFun);
            this.Controls.Add(this.txtb_NomCarg);
            this.Controls.Add(this.txtb_NomFun);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_CadFunci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO FUNCIONARIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtb_NomFun;
        private TextBox txtb_NomCarg;
        private TextBox txtb_TelFun;
        private TextBox txtb_UsuFun;
        private TextBox txtb_SenFun;
        private Button btn_CadFun;
    }
}