using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace DesktopShower
{    
    public partial class Form1 : Form
    {
        string port; //порт        
        Socket socket;
        Socket handler;
        Thread streamThread;
        int xM, yM, eventM = 0;

        public Form1()
        {           
            InitializeComponent();            
            port = "8080";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strHostName = "";
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                IpInfo.Text = addr[i].ToString();
            }    
        }

        private void startServerBtn_Click(object sender, EventArgs e)
        {
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, System.Convert.ToInt32(port)));
            streamThread = new Thread(new ParameterizedThreadStart(serverStart));
            streamThread.IsBackground = true;
            streamThread.Start(port);     

        }

        private void serverStart(object port)
        {
            byte[] buffer = new byte[500000];
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    labelStatus.Text = "Сервер запущен." + Environment.NewLine + "Ожидается подключение.";
                }));
            }
            
            
            socket.Listen(10);
            handler = socket.Accept();

            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    labelStatus.Visible = false;
                }));
            }
            
            using (MemoryStream ms = new MemoryStream(new byte[512 * 1000], 0, 512 * 1000, true, true))
            {
                while(true)
                {
                    BinaryReader reader = new BinaryReader(ms);
                    BinaryWriter writer = new BinaryWriter(ms);
                    ms.Position = 0;
                    handler.Receive(ms.GetBuffer());
                    pictureBox1.Image = byteArrayToImage(reader.ReadBytes(512 * 1000));
                }
                
            }
                
            
        }

        

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                using (var ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            catch { }
            return null;
        }

        private void buttonPortFix_Click(object sender, EventArgs e)
        {
            port = portTextBox.Text;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (handler != null)
            {
                xM = e.X;
                yM = e.Y;
                eventM = 0;
                using (MemoryStream ms = new MemoryStream(new byte[512], 0, 512, true, true))
                {
                    BinaryWriter writer = new BinaryWriter(ms);
                    BinaryReader reader = new BinaryReader(ms);
                    ms.Position = 0;
                    writer.Write(xM);
                    writer.Write(yM);
                    writer.Write(eventM);
                    writer.Write(pictureBox1.Size.Height);
                    writer.Write(pictureBox1.Size.Width);
                    handler.Send(ms.GetBuffer());
                    
                }

                //Thread comandThread = new Thread(new ParameterizedThreadStart(commandServer));
                //comandThread.Start(handler);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (groupBoxSetting.Visible == true)
                {
                    groupBoxSetting.Visible = false;
                }
                else
                {
                    groupBoxSetting.Visible = true;
                }
            }
        }
    }
}
