using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace frm_cliente
{
    public partial class Form1 : Form
    {
        private TcpClient tcpCliente;
        private NetworkStream netWorkStream;
        private Thread thInteracao;


        public Form1()
        {
            InitializeComponent();
        }

        private void bt_conectar_Click(object sender, EventArgs e)
        {
            this.conecta();
            this.thInteracao = new Thread(new ThreadStart(this.monitora));
            this.thInteracao.IsBackground = true;
            this.thInteracao.Priority = ThreadPriority.Highest;
            this.thInteracao.Name = "thInteracao";
            this.thInteracao.Start();
        }

        private void conecta()
        {
            this.tcpCliente = new TcpClient();
            setMsg("##Estabelecendo conexão");
            tcpCliente.Connect(this.txb_ip.Text, Convert.ToInt32(this.txb_porta.Text));

        }

        private void desconecta()
        {
            if (this.thInteracao != null)
            {

                if (this.thInteracao.ThreadState == ThreadState.Running)
                {
                    this.thInteracao.Abort();

                }
                tcpCliente.Close();
            }


        }

        private void enviarMensagem(string mensagem)
        {
            if (this.netWorkStream.CanWrite)
            {
                byte[] sendBytes = Encoding.ASCII.GetBytes(mensagem);
                this.netWorkStream.Write(sendBytes, 0, sendBytes.Length);

            }

        }

        delegate void delsetMsg(string mensagem);
        private void setMsg(string mensagem)
        {
            if (this.InvokeRequired)
            {

                this.BeginInvoke(new delsetMsg(setMsg), mensagem);
            }
            else
            {
                rt_recepcao.Text += "\n Cliente: " + mensagem;
            }
        }

        delegate void delgetMsg(string mensagem);
        private void getMsg(string mensagem)
        {
            if (this.InvokeRequired)
            {

                this.BeginInvoke(new delgetMsg(getMsg), mensagem);
            }
            else
            {
                rt_recepcao.Text += "\n Server: " + mensagem;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.netWorkStream.CanWrite)
                {
                    string mensagem = this.txb_enviarDados.Text;
                    this.enviarMensagem(mensagem);
                    setMsg(mensagem);
                }
                else
                {

                    this.setMsg("## Não foi possível enviar os dados");
                    this.desconecta();
                }

            }
        }

        private void txb_enviarDados_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txb_enviarDados.Clear();
            }
        }


        private void monitora()
        {

            try
            {
                do
                {
                    this.netWorkStream = tcpCliente.GetStream(); 
                    //Se tem algo para ler
                    if (this.netWorkStream.CanRead)
                    {
                        byte[] bytes = new byte[this.tcpCliente.ReceiveBufferSize];
                        this.netWorkStream.Read(bytes, 0, Convert.ToInt32(this.tcpCliente.ReceiveBufferSize));

                        string returnData = Encoding.ASCII.GetString(bytes);
                        this.getMsg(returnData);
                    }
                    else
                    {
                        setMsg("Não foi possível ler os dados...");
                        this.desconecta();
                    }
                    

                } while (this.tcpCliente != null);

            }
            catch
            {

            }

        }

        private void bt_desconecta_Click(object sender, EventArgs e)
        {
            this.desconecta();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.desconecta();
        }



    }
}
