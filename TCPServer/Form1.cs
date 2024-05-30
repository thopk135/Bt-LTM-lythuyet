using System.Net.Sockets;
using System.Net;
using System.Text;
using SuperSimpleTcp;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        SimpleTcpServer? server;



        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
            if (server != null)
            {
                server.Start();
                txtInfo.Text += $"Starting...{Environment.NewLine}";
                txtInfo.Refresh();
                btnStart.Enabled = false;
                btnSend.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;

        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private bool isImageData(ArraySegment<byte> data)
        {
            throw new NotImplementedException();
        }

        // Hàm kiểm tra xem dữ liệu có phải là hình ảnh hay không
        private bool isImageData(byte[] data)
        {
            // Thực hiện kiểm tra dữ liệu ở đây, ví dụ:
            // Nếu dữ liệu có định danh IMAGE, có thể giả sử đây là dữ liệu hình ảnh
            return Encoding.UTF8.GetString(data).StartsWith("IMAGE");
        }

        // Hàm hiển thị hình ảnh trên RichTextBox
        private void DisplayImageOnRichTextBox(byte[] imageData)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Chuyển đổi dữ liệu hình ảnh thành dạng Base64
                    string base64Image = Convert.ToBase64String(ms.ToArray());

                    // Tạo chuỗi RTF chứa hình ảnh
                    string rtfWithImage = "{\\rtf1\\pict\\picw500\\pich500\\pngblip\\picwgoal500\\pichgoal500 " +
                                           $"{base64Image}\\par}}";

                    // Thêm chuỗi RTF vào RichTextBox
                    txtInfo.Text += rtfWithImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                listClientIP.Items.Add(e.IpPort);
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                listClientIP.Items.Remove(e.IpPort);
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                var selectedClient = listClientIP.SelectedItem;
                if (selectedClient != null)
                {
                    string clientIp = selectedClient.ToString();
                    server.Send(clientIp, txtMessage.Text);
                    txtInfo.Text += $"Server: {txtMessage.Text}.{Environment.NewLine}";
                    txtMessage.Text = string.Empty;
                }
            }
        }

    }

}