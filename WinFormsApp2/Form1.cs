using System.IO.Pipes;

namespace WinFormsApp2
{
    public partial class ClientForm : Form
    {
        //NamedPipeClientStream? client;

        public ClientForm()
        {
            InitializeComponent();
            //Read.Enabled = false;

        }

        ~ClientForm()
        {
            //if (client == null) { return; }
            //client.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //NamedPipeServerStream
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (client == null) { return; }
            using (var client = new NamedPipeClientStream(".", "testpipe", PipeDirection.InOut))
            {
                client.Connect();

                try
                {
                    // Read user input and send that to the client process.
                    using (StreamWriter sw = new StreamWriter(client))
                    {
                        sw.AutoFlush = true;
                        sw.Write(textBox1.Text);
                    }

                    Label.Text = "Server send";
                }
                // Catch the IOException that is raised if the pipe is broken
                // or disconnected.
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void Read_Click(object sender, EventArgs e)
        {
            //if (client == null) { return; }

            //using (StreamReader sr = new StreamReader(client))
            //{
            //    textBox1.Text = sr.ReadToEnd();
            //}

            //Label.Text = "Server read";
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            //Read.Enabled = false;

            //var pipeClient = new NamedPipeClientStream(".", "testpipe", PipeDirection.InOut);
            //await pipeClient.ConnectAsync();
            //client = pipeClient;

            //Label.Text = "Server connected";
            //Read.Enabled = true;
        }
    }
}
