namespace prj_SalaoBeleza.View
{
    partial class Frm_EditServi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditServi));
            this.dgv_Servi = new System.Windows.Forms.DataGridView();
            this.txtb_DescEx = new System.Windows.Forms.TextBox();
            this.txtb_NomeServiEx = new System.Windows.Forms.TextBox();
            this.txtb_IdEx = new System.Windows.Forms.TextBox();
            this.btn_ExcluirSer = new System.Windows.Forms.Button();
            this.btn_AtuSer = new System.Windows.Forms.Button();
            this.dtp_HrsMed = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Servi
            // 
            this.dgv_Servi.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Servi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Servi.Location = new System.Drawing.Point(600, 238);
            this.dgv_Servi.Name = "dgv_Servi";
            this.dgv_Servi.RowTemplate.Height = 25;
            this.dgv_Servi.Size = new System.Drawing.Size(481, 165);
            this.dgv_Servi.TabIndex = 1;
            this.dgv_Servi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Servi_CellClick);
            // 
            // txtb_DescEx
            // 
            this.txtb_DescEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_DescEx.Enabled = false;
            this.txtb_DescEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_DescEx.Location = new System.Drawing.Point(33, 340);
            this.txtb_DescEx.Name = "txtb_DescEx";
            this.txtb_DescEx.Size = new System.Drawing.Size(187, 32);
            this.txtb_DescEx.TabIndex = 23;
            // 
            // txtb_NomeServiEx
            // 
            this.txtb_NomeServiEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_NomeServiEx.Enabled = false;
            this.txtb_NomeServiEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_NomeServiEx.Location = new System.Drawing.Point(33, 179);
            this.txtb_NomeServiEx.Name = "txtb_NomeServiEx";
            this.txtb_NomeServiEx.Size = new System.Drawing.Size(187, 32);
            this.txtb_NomeServiEx.TabIndex = 21;
            // 
            // txtb_IdEx
            // 
            this.txtb_IdEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_IdEx.Enabled = false;
            this.txtb_IdEx.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_IdEx.Location = new System.Drawing.Point(464, 179);
            this.txtb_IdEx.Name = "txtb_IdEx";
            this.txtb_IdEx.Size = new System.Drawing.Size(95, 32);
            this.txtb_IdEx.TabIndex = 24;
            // 
            // btn_ExcluirSer
            // 
            this.btn_ExcluirSer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ExcluirSer.BackgroundImage")));
            this.btn_ExcluirSer.Enabled = false;
            this.btn_ExcluirSer.Location = new System.Drawing.Point(637, 591);
            this.btn_ExcluirSer.Name = "btn_ExcluirSer";
            this.btn_ExcluirSer.Size = new System.Drawing.Size(222, 61);
            this.btn_ExcluirSer.TabIndex = 27;
            this.btn_ExcluirSer.UseVisualStyleBackColor = true;
            this.btn_ExcluirSer.Click += new System.EventHandler(this.btn_ExcluirSer_Click);
            // 
            // btn_AtuSer
            // 
            this.btn_AtuSer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AtuSer.BackgroundImage")));
            this.btn_AtuSer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_AtuSer.Enabled = false;
            this.btn_AtuSer.Location = new System.Drawing.Point(402, 592);
            this.btn_AtuSer.Name = "btn_AtuSer";
            this.btn_AtuSer.Size = new System.Drawing.Size(206, 58);
            this.btn_AtuSer.TabIndex = 26;
            this.btn_AtuSer.UseVisualStyleBackColor = true;
            this.btn_AtuSer.Click += new System.EventHandler(this.btn_AtuSer_Click);
            // 
            // dtp_HrsMed
            // 
            this.dtp_HrsMed.Enabled = false;
            this.dtp_HrsMed.Location = new System.Drawing.Point(33, 269);
            this.dtp_HrsMed.Name = "dtp_HrsMed";
            this.dtp_HrsMed.Size = new System.Drawing.Size(200, 23);
            this.dtp_HrsMed.TabIndex = 28;
            // 
            // Frm_EditServi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 699);
            this.Controls.Add(this.dtp_HrsMed);
            this.Controls.Add(this.btn_ExcluirSer);
            this.Controls.Add(this.btn_AtuSer);
            this.Controls.Add(this.txtb_IdEx);
            this.Controls.Add(this.txtb_DescEx);
            this.Controls.Add(this.txtb_NomeServiEx);
            this.Controls.Add(this.dgv_Servi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_EditServi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXIBIÇÃO,EXCLUSÃO,ATUALIZAÇÃO DE SERVIÇO";
            this.Load += new System.EventHandler(this.Frm_EditServi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_Servi;
        private TextBox txtb_DescEx;
        private TextBox txtb_NomeServiEx;
        private TextBox txtb_IdEx;
        private Button btn_ExcluirSer;
        private Button btn_AtuSer;
        private DateTimePicker dtp_HrsMed;
    }
}