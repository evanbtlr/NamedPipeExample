using System.IO.Pipes;

namespace WinFormsApp1
{
    public partial class ServerForm : Form
    {
        NamedPipeServerStream? server;
        string text = string.Empty;

        public ServerForm()
        {
            InitializeComponent();
            //button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (server == null) { return; }

            //try
            //{
            //    // Read user input and send that to the client process.
            //    using (StreamWriter sw = new StreamWriter(server))
            //    {
            //        sw.AutoFlush = true;
            //        sw.Write(textBox1.Text);
            //    }

            //    Label.Text = "Server send";
            //}
            //// Catch the IOException that is raised if the pipe is broken
            //// or disconnected.
            //catch (IOException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Read_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            var pipeServer = new NamedPipeServerStream("testpipe", PipeDirection.InOut);
            pipeServer.BeginWaitForConnection(BeginWaitForConnection, pipeServer);

            //await pipeServer.WaitForConnectionAsync();
            server = pipeServer;



            Label.Text = "Server created";
            button1.Enabled = true;
        }

        private void BeginWaitForConnection(IAsyncResult? result)
        {
            if (result == null) { return; }

            //var server = result.AsyncState as NamedPipeServerStream;

            if (server == null) { return; }


            server.EndWaitForConnection(result);
            


            using (StreamReader sr = new StreamReader(server))
            {
                text = sr.ReadToEnd();
            }

            Invoke(UpdateText);

            server.Close();
            server.Dispose();

            var pipeServer = new NamedPipeServerStream("testpipe", PipeDirection.InOut);
            pipeServer.BeginWaitForConnection(BeginWaitForConnection, pipeServer);
            server = pipeServer;
            //server.BeginWaitForConnection(BeginWaitForConnection, server);
        }

        private void UpdateText()
        {
            textBox1.Text = text;
        }
    }
}
