namespace prj_SalaoBeleza.View
{
    partial class Frm_EditFunci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditFunci));
            this.dgv_Funci = new System.Windows.Forms.DataGridView();
            this.btn_ExcluirFun = new System.Windows.Forms.Button();
            this.btn_AtuFun = new System.Windows.Forms.Button();
            this.txtb_NomeFunEx = new System.Windows.Forms.TextBox();
            this.txtb_CargoFunEx = new System.Windows.Forms.TextBox();
            this.txtb_TelEx = new System.Windows.Forms.TextBox();
            this.txtb_UsuEx = new System.Windows.Forms.TextBox();
            this.txtb_SenhaEx = new System.Windows.Forms.TextBox();
            this.txtb_IdEx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Funci
            // 
            this.dgv_Funci.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Funci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funci.Location = new System.Drawing.Point(510, 221);
            this.dgv_Funci.Name = "dgv_Funci";
            this.dgv_Funci.RowTemplate.Height = 25;
            this.dgv_Funci.Size = new System.Drawing.Size(584, 196);
            this.dgv_Funci.TabIndex = 1;
            this.dgv_Funci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Funci_CellClick);
            // 
            // btn_ExcluirFun
            // 
            this.btn_ExcluirFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ExcluirFun.BackgroundImage")));
            this.btn_ExcluirFun.Enabled = false;
            this.btn_ExcluirFun.Location = new System.Drawing.Point(510, 590);
            this.btn_ExcluirFun.Name = "btn_ExcluirFun";
            this.btn_ExcluirFun.Size = new System.Drawing.Size(222, 61);
            this.btn_ExcluirFun.TabIndex = 17;
            this.btn_ExcluirFun.UseVisualStyleBackColor = true;
            this.btn_ExcluirFun.Click += new System.EventHandler(this.btn_ExcluirFun_Click);
            // 
            // btn_AtuFun
            // 
            this.btn_AtuFun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AtuFun.BackgroundImage")));
            this.btn_AtuFun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_AtuFun.Enabled = false;
            this.btn_AtuFun.Location = new System.Drawing.Point(240, 590);
            this.btn_AtuFun.Name = "btn_AtuFun";
            this.btn_AtuFun.Size = new System.Drawing.Size(206, 58);
            this.btn_AtuFun.TabIndex = 16;
            this.btn_AtuFun.UseVisualStyleBackColor = true;
            this.btn_AtuFun.Click += new System.EventHandler(this.btn_AtuFun_Click);
            // 
            // txtb_NomeFunEx
            // 
            this.txtb_NomeFunEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_NomeFunEx.Enabled = false;
            this.txtb_NomeFunEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_NomeFunEx.Location = new System.Drawing.Point(12, 176);
            this.txtb_NomeFunEx.Name = "txtb_NomeFunEx";
            this.txtb_NomeFunEx.Size = new System.Drawing.Size(187, 32);
            this.txtb_NomeFunEx.TabIndex = 18;
            // 
            // txtb_CargoFunEx
            // 
            this.txtb_CargoFunEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_CargoFunEx.Enabled = false;
            this.txtb_CargoFunEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_CargoFunEx.Location = new System.Drawing.Point(12, 260);
            this.txtb_CargoFunEx.Name = "txtb_CargoFunEx";
            this.txtb_CargoFunEx.Size = new System.Drawing.Size(187, 32);
            this.txtb_CargoFunEx.TabIndex = 19;
            // 
            // txtb_TelEx
            // 
            this.txtb_TelEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_TelEx.Enabled = false;
            this.txtb_TelEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_TelEx.Location = new System.Drawing.Point(12, 337);
            this.txtb_TelEx.Name = "txtb_TelEx";
            this.txtb_TelEx.Size = new System.Drawing.Size(187, 32);
            this.txtb_TelEx.TabIndex = 20;
            // 
            // txtb_UsuEx
            // 
            this.txtb_UsuEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_UsuEx.Enabled = false;
            this.txtb_UsuEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_UsuEx.Location = new System.Drawing.Point(12, 419);
            this.txtb_UsuEx.Name = "txtb_UsuEx";
            this.txtb_UsuEx.Size = new System.Drawing.Size(187, 32);
            this.txtb_UsuEx.TabIndex = 21;
            // 
            // txtb_SenhaEx
            // 
            this.txtb_SenhaEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_SenhaEx.Enabled = false;
            this.txtb_SenhaEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_SenhaEx.Location = new System.Drawing.Point(259, 176);
            this.txtb_SenhaEx.Name = "txtb_SenhaEx";
            this.txtb_SenhaEx.Size = new System.Drawing.Size(187, 32);
            this.txtb_SenhaEx.TabIndex = 22;
            // 
            // txtb_IdEx
            // 
            this.txtb_IdEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_IdEx.Enabled = false;
            this.txtb_IdEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_IdEx.Location = new System.Drawing.Point(292, 260);
            this.txtb_IdEx.Name = "txtb_IdEx";
            this.txtb_IdEx.Size = new System.Drawing.Size(109, 32);
            this.txtb_IdEx.TabIndex = 23;
            this.txtb_IdEx.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Frm_EditFunci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 699);
            this.Controls.Add(this.txtb_IdEx);
            this.Controls.Add(this.txtb_SenhaEx);
            this.Controls.Add(this.txtb_UsuEx);
            this.Controls.Add(this.txtb_TelEx);
            this.Controls.Add(this.txtb_CargoFunEx);
            this.Controls.Add(this.txtb_NomeFunEx);
            this.Controls.Add(this.btn_ExcluirFun);
            this.Controls.Add(this.btn_AtuFun);
            this.Controls.Add(this.dgv_Funci);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_EditFunci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXIBIÇÃO,EXCLUSÃO,ATUALIZAÇÃO DE FUNCIONARIO";
            this.Load += new System.EventHandler(this.Frm_EditFunci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_Funci;
        private Button btn_ExcluirFun;
        private Button btn_AtuFun;
        private TextBox txtb_NomeFunEx;
        private TextBox txtb_CargoFunEx;
        private TextBox txtb_TelEx;
        private TextBox txtb_UsuEx;
        private TextBox txtb_SenhaEx;
        private TextBox txtb_IdEx;
    }
}