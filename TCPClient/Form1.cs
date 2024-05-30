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

        private void sendimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] imageData = File.ReadAllBytes(ofd.FileName);
                    client.Send(imageData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gửi hình ảnh ");
                }
            }
        }

       

        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Đổi định dạng hình ảnh tùy vào định dạng của hình ảnh bạn đang sử dụng
                return ms.ToArray();
            }
        }
    }
}