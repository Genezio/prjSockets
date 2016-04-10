using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmServidor
{
    public partial class frm_principal : Form
    {
        private int porta;
        private TcpListener tcpListener;
        private TcpClient tcpClient;
        private NetworkStream newWorkStream;
        private Thread thInteraction;

        public frm_principal()
        {
            InitializeComponent();
        }

        private void lb_porta_Click(object sender, EventArgs e)
        {

        }

        //Método responsávael por efetuar a conexão
        private bool conecta()
        {

            bool retorno = false;

            try
            {
                this.porta = Convert.ToInt32(this.tx_porta.Text);
                this.tcpListener = new TcpListener(System.Net.IPAddress.Any, this.porta);
                this.tcpListener.Start();
                retorno = true;

            }
            catch
            {

            }
            return retorno;


        }
        //Método responsávael por fechar a conexão
        private void desconecta()
        {

            if (this.thInteraction != null)
            {
                if (this.thInteraction.ThreadState == ThreadState.Running)
                {
                    this.thInteraction.Abort();
                }

            }

            if (this.tcpClient != null)
            {
                this.tcpClient.Client.Disconnect(true);
                this.tcpListener.Stop();
                setMsg("### Conexões Perdidas ###", true);
            }
            

        }

        //Método responsávael por aceitas as conexãoes

        private void acceptConnection()
        {

            try
            {
                this.tcpClient = this.tcpListener.AcceptTcpClient();
            }
            catch
            {

            }

        }
        //Método responsávael por enviar mensagens
        private void enviarMensagem(string mensagem)
        {

            if (podeEscrever())
            {
                byte[] sedBytes = Encoding.ASCII.GetBytes(mensagem);//Converte a mensagem para bytes
                this.newWorkStream.Write(sedBytes, 0, sedBytes.Length);


            }

        }
        //Método responsávael por verificar se pode enviar mensagens
        private bool podeEscrever()
        {
            if (this.newWorkStream == null)
            {
                return false;
            }

            if (this.newWorkStream.CanWrite && this.tcpClient != null)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

        //Quando usar therads tem que usar o delegate para não dar erro
        delegate void delSetMsg(string mensgem, bool isAdm);
        //Método responsávael por setar mensagens;
        private void setMsg(string mensagem, bool isAmd)
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delSetMsg(setMsg), mensagem, isAmd);
            }
            else
            {
                if (isAmd == true || podeEscrever())
                {
                    this.rt_monitor.Text += "\n Server: " + mensagem;
                }
            }


        }

        //Quando usar therads tem que usar o delegate para não dar erro
        delegate void delGetMsg(string mensgem);
        //Método responsávael por pegar as  mensagens do cliente;
        private void getMsg(string mensagem)
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delGetMsg(getMsg), mensagem);
            }
            else
            {
                if (podeEscrever())
                {
                    this.rt_monitor.Text += "\n + Client: " + mensagem;
                }
            }

        }
        //Método responsávael por startar o servidor;
        private void start()
        {

            if (this.conecta())
            {
                this.setMsg("## Aguardando Conexão ...", true);

                this.thInteraction = new Thread(new ThreadStart(monitora));
                this.thInteraction.IsBackground = true;
                this.thInteraction.Priority = ThreadPriority.Highest;
                this.thInteraction.Name = "thInteracao";
                this.thInteraction.Start();

            }
        }

        //Método responsávael por ficar monitorando as entradas e saidas;
        private void monitora()
        {
            try
            {
                this.acceptConnection();
                this.setMsg("## Conexão Aceita ...", true);

                do
                {
                    this.newWorkStream = this.tcpClient.GetStream();
                    if (this.newWorkStream.CanRead)
                    {
                        byte[] bytes = new byte[this.tcpClient.ReceiveBufferSize];
                        this.newWorkStream.Read(bytes, 0, Convert.ToInt32(this.tcpClient.ReceiveBufferSize));
                        //Dado do cliente
                        string clientData = Encoding.ASCII.GetString(bytes);

                        //Verifica se realmente tem uma mensagem

                        if (clientData.Replace("\0", "").Trim() != "")
                        {
                            this.getMsg(clientData);

                        }


                    }

                } while (this.tcpClient != null);

                this.desconecta();
                this.start();
            }
            catch
            {

            }

        }


        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            this.start();
            this.bt_iniciar.Enabled = false;
        }

        private void bt_desconecta_Click(object sender, EventArgs e)
        {
            this.setMsg("## Encerrando conexão com o servidor", true);
            this.desconecta();
            this.bt_iniciar.Enabled = true;
        }

        private void tx_enviaComando_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string mensagem = this.tx_enviaComando.Text;
                this.enviarMensagem(mensagem);
                this.setMsg(mensagem, false);

            }
        }

        private void tx_enviaComando_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.tx_enviaComando.Clear();
            }
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            this.tx_ip.Text = Convert.ToString(System.Net.IPAddress.Any);
        }



    }
}
