namespace prj_SalaoBeleza.View
{
    partial class Frm_CadServi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadServi));
            this.txtb_Desc = new System.Windows.Forms.TextBox();
            this.txtb_NomeServ = new System.Windows.Forms.TextBox();
            this.btn_CadServi = new System.Windows.Forms.Button();
            this.dtp_HrsMed = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtb_Desc
            // 
            this.txtb_Desc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtb_Desc.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtb_Desc.Location = new System.Drawing.Point(12, 291);
            this.txtb_Desc.Name = "txtb_Desc";
            this.txtb_Desc.Size = new System.Drawing.Size(200, 38);
            this.txtb_Desc.TabIndex = 5;
            // 
            // txtb_NomeServ
            // 
            this.txtb_NomeServ.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtb_NomeServ.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtb_NomeServ.Location = new System.Drawing.Point(12, 197);
            this.txtb_NomeServ.Name = "txtb_NomeServ";
            this.txtb_NomeServ.Size = new System.Drawing.Size(188, 38);
            this.txtb_NomeServ.TabIndex = 4;
            // 
            // btn_CadServi
            // 
            this.btn_CadServi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CadServi.BackgroundImage")));
            this.btn_CadServi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CadServi.Location = new System.Drawing.Point(566, 461);
            this.btn_CadServi.Name = "btn_CadServi";
            this.btn_CadServi.Size = new System.Drawing.Size(196, 70);
            this.btn_CadServi.TabIndex = 7;
            this.btn_CadServi.UseVisualStyleBackColor = true;
            this.btn_CadServi.Click += new System.EventHandler(this.btn_CadServi_Click);
            // 
            // dtp_HrsMed
            // 
            this.dtp_HrsMed.Location = new System.Drawing.Point(277, 207);
            this.dtp_HrsMed.Name = "dtp_HrsMed";
            this.dtp_HrsMed.Size = new System.Drawing.Size(200, 23);
            this.dtp_HrsMed.TabIndex = 8;
            this.dtp_HrsMed.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Frm_CadServi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 553);
            this.Controls.Add(this.dtp_HrsMed);
            this.Controls.Add(this.btn_CadServi);
            this.Controls.Add(this.txtb_Desc);
            this.Controls.Add(this.txtb_NomeServ);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_CadServi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO SERVIÇO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtb_Desc;
        private TextBox txtb_NomeServ;
        private Button btn_CadServi;
        private DateTimePicker dtp_HrsMed;
    }
}