using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Models;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SignalRClient
{
    public partial class SignalRClient : Form
    {
        Connection PersistentConnection;
        bool loggedIn;
        public SignalRClient()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {            
            try
            {
                PersistentConnection = new Connection("http://localhost:40476/raw-connection");

                PersistentConnection.Received += ReceivedMessage;
                PersistentConnection.Start().Wait();

                //connection.On("NickNameBusy", () =>
                //{
                //    Invoke((MethodInvoker)async delegate {
                //        MessageBox.Show("Данный ник занят.");
                //        loggedIn = false;
                //        await connection.DisposeAsync();
                //        txtBoxUser.Enabled = true;
                //        txtBoxUser.Text = string.Empty;
                //        btnSendMessage.Enabled = false;
                //        listBoxChat.Items.Add("Connection closed");
                //    });
                //});

                PersistentConnection.Send(new { type = 4, value = "guest" }).Wait();
                listBoxChat.Items.Add("Connection started");
                loggedIn = true;
                txtBoxUser.Enabled = false;
                btnConnect.Enabled = false;
                btnSendMessage.Enabled = !string.IsNullOrWhiteSpace(txtBoxMessage.Text);
            }
            catch (Exception ex)
            {
                listBoxChat.Items.Add(ex.Message);
            }            
        }

        private void ReceivedMessage(string data)
        {
            var message = JsonConvert.DeserializeObject<MessageDTO>(data);
            if (message.Type == MessageType.DisconnectUser)
            {
                Application.Exit();
            }
            listBoxChat.BeginInvoke((MethodInvoker)(() => listBoxChat.Items.Add(message.Data)));
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                PersistentConnection.Send(new { type = 1, value = txtBoxMessage.Text }).Wait();
                listBoxChat.Items.Add(txtBoxMessage.Text);
                txtBoxMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {
                listBoxChat.Items.Add(ex.Message);
            }
        }

        private void listBoxChat_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            var color = Color.Black;
            string itemText = listBoxChat.Items[e.Index].ToString();
            if (itemText.EndsWith(" присоединился к чату."))
            {
                color = Color.Green;
            }
            else if (itemText.EndsWith(" покинул чат."))
            {
                color = Color.Red;
            }
            e.Graphics.DrawString(itemText, new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), new SolidBrush(color), e.Bounds);
        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = !loggedIn && !string.IsNullOrEmpty(txtBoxUser.Text);
        }
        
        private void txtBoxMessage_TextChanged(object sender, EventArgs e)
        {
            btnSendMessage.Enabled = loggedIn && !string.IsNullOrEmpty(txtBoxUser.Text) && !string.IsNullOrWhiteSpace(txtBoxMessage.Text);
        }
    }
}