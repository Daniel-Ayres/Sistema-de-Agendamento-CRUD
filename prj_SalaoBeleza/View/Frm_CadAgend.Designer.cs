namespace prj_SalaoBeleza.View
{
    partial class Frm_CadAgend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadAgend));
            this.cmb_Clien = new System.Windows.Forms.ComboBox();
            this.cmb_Funci = new System.Windows.Forms.ComboBox();
            this.cmd_Servi = new System.Windows.Forms.ComboBox();
            this.dtp_DataAgend = new System.Windows.Forms.DateTimePicker();
            this.btn_CadAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Clien
            // 
            this.cmb_Clien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_Clien.FormattingEnabled = true;
            this.cmb_Clien.Location = new System.Drawing.Point(138, 104);
            this.cmb_Clien.Name = "cmb_Clien";
            this.cmb_Clien.Size = new System.Drawing.Size(151, 29);
            this.cmb_Clien.TabIndex = 0;
            // 
            // cmb_Funci
            // 
            this.cmb_Funci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_Funci.FormattingEnabled = true;
            this.cmb_Funci.Location = new System.Drawing.Point(164, 156);
            this.cmb_Funci.Name = "cmb_Funci";
            this.cmb_Funci.Size = new System.Drawing.Size(151, 29);
            this.cmb_Funci.TabIndex = 1;
            // 
            // cmd_Servi
            // 
            this.cmd_Servi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_Servi.FormattingEnabled = true;
            this.cmd_Servi.Location = new System.Drawing.Point(138, 202);
            this.cmd_Servi.Name = "cmd_Servi";
            this.cmd_Servi.Size = new System.Drawing.Size(151, 29);
            this.cmd_Servi.TabIndex = 2;
            // 
            // dtp_DataAgend
            // 
            this.dtp_DataAgend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_DataAgend.Location = new System.Drawing.Point(209, 247);
            this.dtp_DataAgend.Name = "dtp_DataAgend";
            this.dtp_DataAgend.Size = new System.Drawing.Size(200, 29);
            this.dtp_DataAgend.TabIndex = 3;
            // 
            // btn_CadAge
            // 
            this.btn_CadAge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CadAge.BackgroundImage")));
            this.btn_CadAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CadAge.Location = new System.Drawing.Point(544, 363);
            this.btn_CadAge.Name = "btn_CadAge";
            this.btn_CadAge.Size = new System.Drawing.Size(174, 62);
            this.btn_CadAge.TabIndex = 5;
            this.btn_CadAge.UseVisualStyleBackColor = true;
            this.btn_CadAge.Click += new System.EventHandler(this.btn_CadAge_Click);
            // 
            // Frm_CadAgend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CadAge);
            this.Controls.Add(this.dtp_DataAgend);
            this.Controls.Add(this.cmd_Servi);
            this.Controls.Add(this.cmb_Funci);
            this.Controls.Add(this.cmb_Clien);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_CadAgend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO AGENDAMENTO";
            this.Load += new System.EventHandler(this.Frm_CadAgend_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmb_Clien;
        private ComboBox cmb_Funci;
        private ComboBox cmd_Servi;
        private DateTimePicker dtp_DataAgend;
        private Button btn_CadAge;
    }
}