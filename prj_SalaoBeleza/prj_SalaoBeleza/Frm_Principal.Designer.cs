namespace prj_SalaoBeleza
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.btn_Agenda = new System.Windows.Forms.Button();
            this.btn_CadClie = new System.Windows.Forms.Button();
            this.btn_CadServi = new System.Windows.Forms.Button();
            this.btn_CadFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Agenda
            // 
            this.btn_Agenda.Location = new System.Drawing.Point(27, 244);
            this.btn_Agenda.Name = "btn_Agenda";
            this.btn_Agenda.Size = new System.Drawing.Size(139, 45);
            this.btn_Agenda.TabIndex = 0;
            this.btn_Agenda.Text = "ACESSAR";
            this.btn_Agenda.UseVisualStyleBackColor = true;
            this.btn_Agenda.Visible = false;
            this.btn_Agenda.Click += new System.EventHandler(this.btn_Agenda_Click);
            // 
            // btn_CadClie
            // 
            this.btn_CadClie.Location = new System.Drawing.Point(261, 439);
            this.btn_CadClie.Name = "btn_CadClie";
            this.btn_CadClie.Size = new System.Drawing.Size(139, 45);
            this.btn_CadClie.TabIndex = 1;
            this.btn_CadClie.Text = "ACESSAR";
            this.btn_CadClie.UseVisualStyleBackColor = true;
            this.btn_CadClie.Visible = false;
            // 
            // btn_CadServi
            // 
            this.btn_CadServi.Location = new System.Drawing.Point(533, 289);
            this.btn_CadServi.Name = "btn_CadServi";
            this.btn_CadServi.Size = new System.Drawing.Size(139, 45);
            this.btn_CadServi.TabIndex = 2;
            this.btn_CadServi.Text = "ACESSAR";
            this.btn_CadServi.UseVisualStyleBackColor = true;
            this.btn_CadServi.Visible = false;
            // 
            // btn_CadFun
            // 
            this.btn_CadFun.Location = new System.Drawing.Point(739, 452);
            this.btn_CadFun.Name = "btn_CadFun";
            this.btn_CadFun.Size = new System.Drawing.Size(139, 42);
            this.btn_CadFun.TabIndex = 3;
            this.btn_CadFun.Text = "ACESSAR";
            this.btn_CadFun.UseVisualStyleBackColor = true;
            this.btn_CadFun.Visible = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 546);
            this.Controls.Add(this.btn_CadFun);
            this.Controls.Add(this.btn_CadServi);
            this.Controls.Add(this.btn_CadClie);
            this.Controls.Add(this.btn_Agenda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.Text = "ACESSO AO SISTEMA";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Agenda;
        private Button btn_CadClie;
        private Button btn_CadServi;
        private Button btn_CadFun;
    }
}