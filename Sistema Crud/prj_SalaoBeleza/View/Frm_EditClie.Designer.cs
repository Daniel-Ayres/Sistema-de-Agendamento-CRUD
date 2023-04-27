namespace prj_SalaoBeleza.View
{
    partial class Frm_EditClie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditClie));
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dgv_Clie = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtb_NomeEx = new System.Windows.Forms.TextBox();
            this.txtb_EmailEx = new System.Windows.Forms.TextBox();
            this.txtb_Telex = new System.Windows.Forms.TextBox();
            this.txtb_Ruaex = new System.Windows.Forms.TextBox();
            this.txtb_CidEx = new System.Windows.Forms.TextBox();
            this.txtb_EstadoEx = new System.Windows.Forms.TextBox();
            this.txtb_PaisEx = new System.Windows.Forms.TextBox();
            this.txtb_Id = new System.Windows.Forms.TextBox();
            this.btn_ExcluirClie = new System.Windows.Forms.Button();
            this.btn_AtuClie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clie)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // dgv_Clie
            // 
            this.dgv_Clie.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Clie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clie.Location = new System.Drawing.Point(670, 160);
            this.dgv_Clie.Name = "dgv_Clie";
            this.dgv_Clie.RowTemplate.Height = 25;
            this.dgv_Clie.Size = new System.Drawing.Size(424, 177);
            this.dgv_Clie.TabIndex = 0;
            this.dgv_Clie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clie_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtb_NomeEx
            // 
            this.txtb_NomeEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_NomeEx.Enabled = false;
            this.txtb_NomeEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_NomeEx.Location = new System.Drawing.Point(125, 186);
            this.txtb_NomeEx.Name = "txtb_NomeEx";
            this.txtb_NomeEx.Size = new System.Drawing.Size(176, 29);
            this.txtb_NomeEx.TabIndex = 1;
            // 
            // txtb_EmailEx
            // 
            this.txtb_EmailEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_EmailEx.Enabled = false;
            this.txtb_EmailEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_EmailEx.Location = new System.Drawing.Point(125, 308);
            this.txtb_EmailEx.Name = "txtb_EmailEx";
            this.txtb_EmailEx.Size = new System.Drawing.Size(176, 29);
            this.txtb_EmailEx.TabIndex = 2;
            // 
            // txtb_Telex
            // 
            this.txtb_Telex.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_Telex.Enabled = false;
            this.txtb_Telex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Telex.Location = new System.Drawing.Point(457, 186);
            this.txtb_Telex.Name = "txtb_Telex";
            this.txtb_Telex.Size = new System.Drawing.Size(180, 29);
            this.txtb_Telex.TabIndex = 3;
            // 
            // txtb_Ruaex
            // 
            this.txtb_Ruaex.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_Ruaex.Enabled = false;
            this.txtb_Ruaex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Ruaex.Location = new System.Drawing.Point(536, 358);
            this.txtb_Ruaex.Name = "txtb_Ruaex";
            this.txtb_Ruaex.Size = new System.Drawing.Size(172, 29);
            this.txtb_Ruaex.TabIndex = 4;
            // 
            // txtb_CidEx
            // 
            this.txtb_CidEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_CidEx.Enabled = false;
            this.txtb_CidEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_CidEx.Location = new System.Drawing.Point(125, 248);
            this.txtb_CidEx.Name = "txtb_CidEx";
            this.txtb_CidEx.Size = new System.Drawing.Size(176, 29);
            this.txtb_CidEx.TabIndex = 5;
            // 
            // txtb_EstadoEx
            // 
            this.txtb_EstadoEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_EstadoEx.Enabled = false;
            this.txtb_EstadoEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_EstadoEx.Location = new System.Drawing.Point(125, 382);
            this.txtb_EstadoEx.Name = "txtb_EstadoEx";
            this.txtb_EstadoEx.Size = new System.Drawing.Size(176, 29);
            this.txtb_EstadoEx.TabIndex = 6;
            // 
            // txtb_PaisEx
            // 
            this.txtb_PaisEx.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_PaisEx.Enabled = false;
            this.txtb_PaisEx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_PaisEx.Location = new System.Drawing.Point(430, 270);
            this.txtb_PaisEx.Name = "txtb_PaisEx";
            this.txtb_PaisEx.Size = new System.Drawing.Size(180, 29);
            this.txtb_PaisEx.TabIndex = 7;
            // 
            // txtb_Id
            // 
            this.txtb_Id.BackColor = System.Drawing.Color.DarkGray;
            this.txtb_Id.Enabled = false;
            this.txtb_Id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Id.Location = new System.Drawing.Point(215, 455);
            this.txtb_Id.Name = "txtb_Id";
            this.txtb_Id.Size = new System.Drawing.Size(65, 29);
            this.txtb_Id.TabIndex = 8;
            // 
            // btn_ExcluirClie
            // 
            this.btn_ExcluirClie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ExcluirClie.BackgroundImage")));
            this.btn_ExcluirClie.Enabled = false;
            this.btn_ExcluirClie.Location = new System.Drawing.Point(486, 599);
            this.btn_ExcluirClie.Name = "btn_ExcluirClie";
            this.btn_ExcluirClie.Size = new System.Drawing.Size(222, 63);
            this.btn_ExcluirClie.TabIndex = 14;
            this.btn_ExcluirClie.UseVisualStyleBackColor = true;
            this.btn_ExcluirClie.Click += new System.EventHandler(this.btn_ExcluirClie_Click);
            // 
            // btn_AtuClie
            // 
            this.btn_AtuClie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AtuClie.BackgroundImage")));
            this.btn_AtuClie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_AtuClie.Enabled = false;
            this.btn_AtuClie.Location = new System.Drawing.Point(185, 604);
            this.btn_AtuClie.Name = "btn_AtuClie";
            this.btn_AtuClie.Size = new System.Drawing.Size(206, 58);
            this.btn_AtuClie.TabIndex = 13;
            this.btn_AtuClie.UseVisualStyleBackColor = true;
            this.btn_AtuClie.Click += new System.EventHandler(this.btn_AtuClie_Click);
            // 
            // Frm_EditClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 699);
            this.Controls.Add(this.btn_ExcluirClie);
            this.Controls.Add(this.btn_AtuClie);
            this.Controls.Add(this.txtb_Id);
            this.Controls.Add(this.txtb_PaisEx);
            this.Controls.Add(this.txtb_EstadoEx);
            this.Controls.Add(this.txtb_CidEx);
            this.Controls.Add(this.txtb_Ruaex);
            this.Controls.Add(this.txtb_Telex);
            this.Controls.Add(this.txtb_EmailEx);
            this.Controls.Add(this.txtb_NomeEx);
            this.Controls.Add(this.dgv_Clie);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_EditClie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXIBIÇÃO,EXCLUSÃO,ATUALIZAÇÃO DE CLIENTE";
            this.Load += new System.EventHandler(this.Frm_EditClie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dgv_Clie;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtb_NomeEx;
        private TextBox txtb_EmailEx;
        private TextBox txtb_Telex;
        private TextBox txtb_Ruaex;
        private TextBox txtb_CidEx;
        private TextBox txtb_EstadoEx;
        private TextBox txtb_PaisEx;
        private TextBox txtb_Id;
        private Button btn_ExcluirClie;
        private Button btn_AtuClie;
    }
}