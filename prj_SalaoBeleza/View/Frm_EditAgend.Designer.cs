namespace prj_SalaoBeleza.View
{
    partial class Frm_EditAgend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditAgend));
            this.dgv_Agend = new System.Windows.Forms.DataGridView();
            this.cmd_ServiEx = new System.Windows.Forms.ComboBox();
            this.cmb_FunciEx = new System.Windows.Forms.ComboBox();
            this.cmb_ClienEx = new System.Windows.Forms.ComboBox();
            this.dtp_DataAgendEx = new System.Windows.Forms.DateTimePicker();
            this.txtb_IdEx = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_AtuAgend = new System.Windows.Forms.Button();
            this.btn_ExcluirAgen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Agend)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Agend
            // 
            this.dgv_Agend.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Agend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Agend.Location = new System.Drawing.Point(596, 150);
            this.dgv_Agend.Name = "dgv_Agend";
            this.dgv_Agend.RowTemplate.Height = 25;
            this.dgv_Agend.Size = new System.Drawing.Size(498, 196);
            this.dgv_Agend.TabIndex = 2;
            this.dgv_Agend.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Agend_CellClick);
            // 
            // cmd_ServiEx
            // 
            this.cmd_ServiEx.Enabled = false;
            this.cmd_ServiEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmd_ServiEx.FormattingEnabled = true;
            this.cmd_ServiEx.Location = new System.Drawing.Point(134, 297);
            this.cmd_ServiEx.Name = "cmd_ServiEx";
            this.cmd_ServiEx.Size = new System.Drawing.Size(151, 29);
            this.cmd_ServiEx.TabIndex = 5;
            // 
            // cmb_FunciEx
            // 
            this.cmb_FunciEx.Enabled = false;
            this.cmb_FunciEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_FunciEx.FormattingEnabled = true;
            this.cmb_FunciEx.Location = new System.Drawing.Point(185, 223);
            this.cmb_FunciEx.Name = "cmb_FunciEx";
            this.cmb_FunciEx.Size = new System.Drawing.Size(151, 29);
            this.cmb_FunciEx.TabIndex = 4;
            // 
            // cmb_ClienEx
            // 
            this.cmb_ClienEx.Enabled = false;
            this.cmb_ClienEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_ClienEx.FormattingEnabled = true;
            this.cmb_ClienEx.Location = new System.Drawing.Point(134, 150);
            this.cmb_ClienEx.Name = "cmb_ClienEx";
            this.cmb_ClienEx.Size = new System.Drawing.Size(151, 29);
            this.cmb_ClienEx.TabIndex = 3;
            // 
            // dtp_DataAgendEx
            // 
            this.dtp_DataAgendEx.Enabled = false;
            this.dtp_DataAgendEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_DataAgendEx.Location = new System.Drawing.Point(238, 358);
            this.dtp_DataAgendEx.Name = "dtp_DataAgendEx";
            this.dtp_DataAgendEx.Size = new System.Drawing.Size(200, 29);
            this.dtp_DataAgendEx.TabIndex = 6;
            // 
            // txtb_IdEx
            // 
            this.txtb_IdEx.Enabled = false;
            this.txtb_IdEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_IdEx.Location = new System.Drawing.Point(410, 276);
            this.txtb_IdEx.Name = "txtb_IdEx";
            this.txtb_IdEx.Size = new System.Drawing.Size(93, 29);
            this.txtb_IdEx.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btn_AtuAgend
            // 
            this.btn_AtuAgend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AtuAgend.BackgroundImage")));
            this.btn_AtuAgend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_AtuAgend.Enabled = false;
            this.btn_AtuAgend.Location = new System.Drawing.Point(197, 608);
            this.btn_AtuAgend.Name = "btn_AtuAgend";
            this.btn_AtuAgend.Size = new System.Drawing.Size(206, 58);
            this.btn_AtuAgend.TabIndex = 10;
            this.btn_AtuAgend.UseVisualStyleBackColor = true;
            this.btn_AtuAgend.Click += new System.EventHandler(this.btn_AtuAgend_Click);
            // 
            // btn_ExcluirAgen
            // 
            this.btn_ExcluirAgen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ExcluirAgen.BackgroundImage")));
            this.btn_ExcluirAgen.Enabled = false;
            this.btn_ExcluirAgen.Location = new System.Drawing.Point(495, 608);
            this.btn_ExcluirAgen.Name = "btn_ExcluirAgen";
            this.btn_ExcluirAgen.Size = new System.Drawing.Size(222, 63);
            this.btn_ExcluirAgen.TabIndex = 11;
            this.btn_ExcluirAgen.UseVisualStyleBackColor = true;
            this.btn_ExcluirAgen.Click += new System.EventHandler(this.btn_ExcluirAgen_Click);
            // 
            // Frm_EditAgend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 699);
            this.Controls.Add(this.btn_ExcluirAgen);
            this.Controls.Add(this.btn_AtuAgend);
            this.Controls.Add(this.txtb_IdEx);
            this.Controls.Add(this.dtp_DataAgendEx);
            this.Controls.Add(this.cmd_ServiEx);
            this.Controls.Add(this.cmb_FunciEx);
            this.Controls.Add(this.cmb_ClienEx);
            this.Controls.Add(this.dgv_Agend);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_EditAgend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXIBIÇÃO,EXCLUSÃO,ATUALIZAÇÃO DE AGENDAMENTO";
            this.Load += new System.EventHandler(this.Frm_EditAgend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Agend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_Agend;
        private ComboBox cmd_ServiEx;
        private ComboBox cmb_FunciEx;
        private ComboBox cmb_ClienEx;
        private DateTimePicker dtp_DataAgendEx;
        private TextBox txtb_IdEx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_AtuAgend;
        private Button btn_ExcluirAgen;
    }
}