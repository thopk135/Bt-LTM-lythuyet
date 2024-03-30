using System.Text;
using SuperSimpleTcp;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;


        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1", 8080);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btnSend.Enabled = false;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfocl.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfocl.Text += $"Server disconnected.{Environment.NewLine}";
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfocl.Text += $"Server connected.{Environment.NewLine}";
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    client.Connect();
                    btnSend.Enabled = true;
                    btnConnect.Enabled = false;
                }
                else MessageBox.Show("Client is null");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(txtMessage.Text);
                    txtInfocl.Text += $"Me:{txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = string.Empty;
                }
            }
            else MessageBox.Show("Nhap message");
        }
    }
}