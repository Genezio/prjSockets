namespace frm_cliente
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_porta = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.bt_conectar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txb_enviarDados = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rt_recepcao = new System.Windows.Forms.RichTextBox();
            this.txb_porta = new System.Windows.Forms.TextBox();
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.bt_desconecta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_desconecta);
            this.groupBox1.Controls.Add(this.lb_porta);
            this.groupBox1.Controls.Add(this.lb_ip);
            this.groupBox1.Controls.Add(this.bt_conectar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txb_porta);
            this.groupBox1.Controls.Add(this.txb_ip);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão Servidor";
            // 
            // lb_porta
            // 
            this.lb_porta.AutoSize = true;
            this.lb_porta.Location = new System.Drawing.Point(166, 16);
            this.lb_porta.Name = "lb_porta";
            this.lb_porta.Size = new System.Drawing.Size(32, 13);
            this.lb_porta.TabIndex = 6;
            this.lb_porta.Text = "Porta";
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Location = new System.Drawing.Point(6, 16);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(17, 13);
            this.lb_ip.TabIndex = 5;
            this.lb_ip.Text = "IP";
            // 
            // bt_conectar
            // 
            this.bt_conectar.Location = new System.Drawing.Point(7, 59);
            this.bt_conectar.Name = "bt_conectar";
            this.bt_conectar.Size = new System.Drawing.Size(155, 23);
            this.bt_conectar.TabIndex = 4;
            this.bt_conectar.Text = "Conectar Servidor";
            this.bt_conectar.UseVisualStyleBackColor = true;
            this.bt_conectar.Click += new System.EventHandler(this.bt_conectar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txb_enviarDados);
            this.groupBox3.Location = new System.Drawing.Point(7, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 47);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enviar Dados";
            // 
            // txb_enviarDados
            // 
            this.txb_enviarDados.Location = new System.Drawing.Point(7, 20);
            this.txb_enviarDados.Name = "txb_enviarDados";
            this.txb_enviarDados.Size = new System.Drawing.Size(291, 20);
            this.txb_enviarDados.TabIndex = 0;
            this.txb_enviarDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.txb_enviarDados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_enviarDados_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rt_recepcao);
            this.groupBox2.Location = new System.Drawing.Point(7, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 281);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recepção";
            // 
            // rt_recepcao
            // 
            this.rt_recepcao.Location = new System.Drawing.Point(7, 19);
            this.rt_recepcao.Name = "rt_recepcao";
            this.rt_recepcao.Size = new System.Drawing.Size(298, 256);
            this.rt_recepcao.TabIndex = 0;
            this.rt_recepcao.Text = "";
            // 
            // txb_porta
            // 
            this.txb_porta.Location = new System.Drawing.Point(169, 32);
            this.txb_porta.Name = "txb_porta";
            this.txb_porta.Size = new System.Drawing.Size(149, 20);
            this.txb_porta.TabIndex = 1;
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(7, 32);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(155, 20);
            this.txb_ip.TabIndex = 0;
            // 
            // bt_desconecta
            // 
            this.bt_desconecta.Location = new System.Drawing.Point(169, 58);
            this.bt_desconecta.Name = "bt_desconecta";
            this.bt_desconecta.Size = new System.Drawing.Size(149, 23);
            this.bt_desconecta.TabIndex = 7;
            this.bt_desconecta.Text = "Desconectar Servidor";
            this.bt_desconecta.UseVisualStyleBackColor = true;
            this.bt_desconecta.Click += new System.EventHandler(this.bt_desconecta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 468);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cliente Socket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_porta;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Button bt_conectar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txb_enviarDados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rt_recepcao;
        private System.Windows.Forms.TextBox txb_porta;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.Button bt_desconecta;
    }
}

