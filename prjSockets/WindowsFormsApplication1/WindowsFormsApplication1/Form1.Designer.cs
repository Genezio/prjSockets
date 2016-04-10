namespace frmServidor
{
    partial class frm_principal
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
            this.tb_Control_server = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gBox_propreties = new System.Windows.Forms.GroupBox();
            this.lb_envia = new System.Windows.Forms.Label();
            this.lb_separador = new System.Windows.Forms.Label();
            this.tx_enviaComando = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rt_monitor = new System.Windows.Forms.RichTextBox();
            this.bt_desconecta = new System.Windows.Forms.Button();
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.tx_porta = new System.Windows.Forms.TextBox();
            this.lb_porta = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.tx_ip = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_Control_server.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBox_propreties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Control_server
            // 
            this.tb_Control_server.Controls.Add(this.tabPage1);
            this.tb_Control_server.Controls.Add(this.tabPage2);
            this.tb_Control_server.Location = new System.Drawing.Point(12, 12);
            this.tb_Control_server.Name = "tb_Control_server";
            this.tb_Control_server.SelectedIndex = 0;
            this.tb_Control_server.Size = new System.Drawing.Size(916, 507);
            this.tb_Control_server.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gBox_propreties);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Propriedades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gBox_propreties
            // 
            this.gBox_propreties.Controls.Add(this.lb_envia);
            this.gBox_propreties.Controls.Add(this.lb_separador);
            this.gBox_propreties.Controls.Add(this.tx_enviaComando);
            this.gBox_propreties.Controls.Add(this.groupBox1);
            this.gBox_propreties.Controls.Add(this.bt_desconecta);
            this.gBox_propreties.Controls.Add(this.bt_iniciar);
            this.gBox_propreties.Controls.Add(this.tx_porta);
            this.gBox_propreties.Controls.Add(this.lb_porta);
            this.gBox_propreties.Controls.Add(this.lb_ip);
            this.gBox_propreties.Controls.Add(this.tx_ip);
            this.gBox_propreties.Location = new System.Drawing.Point(6, 6);
            this.gBox_propreties.Name = "gBox_propreties";
            this.gBox_propreties.Size = new System.Drawing.Size(275, 469);
            this.gBox_propreties.TabIndex = 0;
            this.gBox_propreties.TabStop = false;
            this.gBox_propreties.Text = "Conexão";
            // 
            // lb_envia
            // 
            this.lb_envia.AutoSize = true;
            this.lb_envia.Location = new System.Drawing.Point(6, 113);
            this.lb_envia.Name = "lb_envia";
            this.lb_envia.Size = new System.Drawing.Size(84, 13);
            this.lb_envia.TabIndex = 9;
            this.lb_envia.Text = "Enviar comando";
            // 
            // lb_separador
            // 
            this.lb_separador.AutoSize = true;
            this.lb_separador.Location = new System.Drawing.Point(6, 93);
            this.lb_separador.Name = "lb_separador";
            this.lb_separador.Size = new System.Drawing.Size(265, 13);
            this.lb_separador.TabIndex = 8;
            this.lb_separador.Text = "---------------------------------------------------------------------------------" +
    "-----";
            // 
            // tx_enviaComando
            // 
            this.tx_enviaComando.Location = new System.Drawing.Point(9, 129);
            this.tx_enviaComando.Name = "tx_enviaComando";
            this.tx_enviaComando.Size = new System.Drawing.Size(262, 20);
            this.tx_enviaComando.TabIndex = 7;
            this.tx_enviaComando.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_enviaComando_KeyDown);
            this.tx_enviaComando.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_enviaComando_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rt_monitor);
            this.groupBox1.Location = new System.Drawing.Point(9, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitor";
            // 
            // rt_monitor
            // 
            this.rt_monitor.Location = new System.Drawing.Point(7, 19);
            this.rt_monitor.Name = "rt_monitor";
            this.rt_monitor.Size = new System.Drawing.Size(247, 283);
            this.rt_monitor.TabIndex = 0;
            this.rt_monitor.Text = "";
            // 
            // bt_desconecta
            // 
            this.bt_desconecta.Location = new System.Drawing.Point(142, 67);
            this.bt_desconecta.Name = "bt_desconecta";
            this.bt_desconecta.Size = new System.Drawing.Size(127, 23);
            this.bt_desconecta.TabIndex = 5;
            this.bt_desconecta.Text = "Parar Servidor";
            this.bt_desconecta.UseVisualStyleBackColor = true;
            this.bt_desconecta.Click += new System.EventHandler(this.bt_desconecta_Click);
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Location = new System.Drawing.Point(9, 67);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(124, 23);
            this.bt_iniciar.TabIndex = 4;
            this.bt_iniciar.Text = "Iniciar Servidor";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // tx_porta
            // 
            this.tx_porta.Location = new System.Drawing.Point(142, 31);
            this.tx_porta.Name = "tx_porta";
            this.tx_porta.Size = new System.Drawing.Size(127, 20);
            this.tx_porta.TabIndex = 3;
            // 
            // lb_porta
            // 
            this.lb_porta.AutoSize = true;
            this.lb_porta.Location = new System.Drawing.Point(139, 15);
            this.lb_porta.Name = "lb_porta";
            this.lb_porta.Size = new System.Drawing.Size(32, 13);
            this.lb_porta.TabIndex = 2;
            this.lb_porta.Text = "Porta";
            this.lb_porta.Click += new System.EventHandler(this.lb_porta_Click);
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Location = new System.Drawing.Point(6, 15);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(17, 13);
            this.lb_ip.TabIndex = 1;
            this.lb_ip.Text = "IP";
            // 
            // tx_ip
            // 
            this.tx_ip.Location = new System.Drawing.Point(6, 31);
            this.tx_ip.Name = "tx_ip";
            this.tx_ip.Size = new System.Drawing.Size(127, 20);
            this.tx_ip.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supervisório";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 531);
            this.Controls.Add(this.tb_Control_server);
            this.Name = "frm_principal";
            this.Text = "Sockets Servidor";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.tb_Control_server.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gBox_propreties.ResumeLayout(false);
            this.gBox_propreties.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_Control_server;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gBox_propreties;
        private System.Windows.Forms.Button bt_desconecta;
        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.TextBox tx_porta;
        private System.Windows.Forms.Label lb_porta;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.TextBox tx_ip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rt_monitor;
        private System.Windows.Forms.Label lb_envia;
        private System.Windows.Forms.Label lb_separador;
        private System.Windows.Forms.TextBox tx_enviaComando;
    }
}

