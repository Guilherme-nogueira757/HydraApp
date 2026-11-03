using System;

namespace HydraApp
{
    partial class Dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_25 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_zerar = new System.Windows.Forms.Button();
            this.menu_lateral = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_ham = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_dashbord = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.painel_principal = new System.Windows.Forms.Panel();
            this.flow_historico = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_msg = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new HydraApp.Class.CircularProgressBar();
            this.menu_lateral.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flow_dashbord.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.painel_principal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_25
            // 
            this.btn_25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_25.Location = new System.Drawing.Point(113, 3);
            this.btn_25.Name = "btn_25";
            this.btn_25.Size = new System.Drawing.Size(104, 38);
            this.btn_25.TabIndex = 1;
            this.btn_25.Text = "25%";
            this.btn_25.UseVisualStyleBackColor = true;
            this.btn_25.Click += new System.EventHandler(this.btn_25_Click);
            // 
            // btn_50
            // 
            this.btn_50.Location = new System.Drawing.Point(223, 3);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(104, 38);
            this.btn_50.TabIndex = 2;
            this.btn_50.Text = "50%";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_100
            // 
            this.btn_100.Location = new System.Drawing.Point(3, 50);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(104, 38);
            this.btn_100.TabIndex = 3;
            this.btn_100.Text = "100%";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_zerar
            // 
            this.btn_zerar.Location = new System.Drawing.Point(3, 3);
            this.btn_zerar.Name = "btn_zerar";
            this.btn_zerar.Size = new System.Drawing.Size(104, 41);
            this.btn_zerar.TabIndex = 4;
            this.btn_zerar.Text = "zerar";
            this.btn_zerar.UseVisualStyleBackColor = true;
            this.btn_zerar.Click += new System.EventHandler(this.btn_zerar_Click);
            // 
            // menu_lateral
            // 
            this.menu_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.menu_lateral.Controls.Add(this.flowLayoutPanel2);
            this.menu_lateral.Location = new System.Drawing.Point(0, 28);
            this.menu_lateral.Name = "menu_lateral";
            this.menu_lateral.Size = new System.Drawing.Size(175, 422);
            this.menu_lateral.TabIndex = 5;
            this.menu_lateral.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_lateral_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Salmon;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(172, 18);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_ham
            // 
            this.btn_ham.Location = new System.Drawing.Point(3, 3);
            this.btn_ham.Name = "btn_ham";
            this.btn_ham.Size = new System.Drawing.Size(34, 27);
            this.btn_ham.TabIndex = 6;
            this.btn_ham.Text = "=\r\n";
            this.btn_ham.UseVisualStyleBackColor = true;
            this.btn_ham.Click += new System.EventHandler(this.btn_ham_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btn_ham);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 34);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flow_dashbord
            // 
            this.flow_dashbord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flow_dashbord.BackColor = System.Drawing.Color.Salmon;
            this.flow_dashbord.Controls.Add(this.flowLayoutPanel4);
            this.flow_dashbord.Controls.Add(this.circularProgressBar1);
            this.flow_dashbord.Controls.Add(this.button1);
            this.flow_dashbord.Location = new System.Drawing.Point(3, 46);
            this.flow_dashbord.Name = "flow_dashbord";
            this.flow_dashbord.Size = new System.Drawing.Size(411, 232);
            this.flow_dashbord.TabIndex = 6;
            this.flow_dashbord.Paint += new System.Windows.Forms.PaintEventHandler(this.flow_dashbord_Paint);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Salmon;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(85, 229);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "notificaçao";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel3.Controls.Add(this.btn_zerar);
            this.flowLayoutPanel3.Controls.Add(this.btn_25);
            this.flowLayoutPanel3.Controls.Add(this.btn_50);
            this.flowLayoutPanel3.Controls.Add(this.btn_100);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 307);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(405, 93);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // painel_principal
            // 
            this.painel_principal.BackColor = System.Drawing.Color.Transparent;
            this.painel_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.painel_principal.Controls.Add(this.flow_historico);
            this.painel_principal.Controls.Add(this.flow_msg);
            this.painel_principal.Controls.Add(this.flowLayoutPanel3);
            this.painel_principal.Controls.Add(this.flow_dashbord);
            this.painel_principal.Location = new System.Drawing.Point(174, 31);
            this.painel_principal.Name = "painel_principal";
            this.painel_principal.Size = new System.Drawing.Size(625, 428);
            this.painel_principal.TabIndex = 8;
            this.painel_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_principal_Paint);
            // 
            // flow_historico
            // 
            this.flow_historico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flow_historico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flow_historico.Location = new System.Drawing.Point(422, 300);
            this.flow_historico.Name = "flow_historico";
            this.flow_historico.Size = new System.Drawing.Size(192, 100);
            this.flow_historico.TabIndex = 9;
            // 
            // flow_msg
            // 
            this.flow_msg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flow_msg.BackColor = System.Drawing.Color.Magenta;
            this.flow_msg.Location = new System.Drawing.Point(420, 46);
            this.flow_msg.Name = "flow_msg";
            this.flow_msg.Size = new System.Drawing.Size(200, 232);
            this.flow_msg.TabIndex = 8;
            this.flow_msg.Paint += new System.Windows.Forms.PaintEventHandler(this.flow_msg_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Location = new System.Drawing.Point(43, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(640, 27);
            this.flowLayoutPanel5.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(689, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 26);
            this.panel1.TabIndex = 8;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.Location = new System.Drawing.Point(94, 3);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.Percentage = 0;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.TabIndex = 8;
            this.circularProgressBar1.Text = "circularProgressBar1";
            this.circularProgressBar1.Thickness = 12;
            this.circularProgressBar1.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.painel_principal);
            this.Controls.Add(this.menu_lateral);
            this.Name = "Dashboard";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menu_lateral.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flow_dashbord.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.painel_principal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btn_25;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_zerar;
        private System.Windows.Forms.FlowLayoutPanel menu_lateral;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_ham;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flow_dashbord;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel painel_principal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Class.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.FlowLayoutPanel flow_historico;
        private System.Windows.Forms.FlowLayoutPanel flow_msg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
    }
}

