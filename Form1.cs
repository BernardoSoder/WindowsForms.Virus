using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsForms.Virus
{
    public partial class Form1 : Form
    {
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll",
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(
            int dwFlags,
            int dx,
            int dy,
            int cButtons,
            int dwExtraInfo);

        // cria um número aleatório
        private Random random = new();

        private void MoverCursorMouse()
        {
            int comprimento = Screen.PrimaryScreen.Bounds.Width;
            int altura = Screen.PrimaryScreen.Bounds.Height;
            int posicaoX = random.Next(comprimento);
            int posicaoY = random.Next(altura);
            Cursor.Position = new Point(posicaoX, posicaoY);
        }

        public Form1()
        {
            InitializeComponent();
            linkGithub.Links.Add(0, 100, "https://github.com/BernardoSoder");
        }

        async private void btnBaixar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                pbDownload.Value = i;
                Thread.Sleep(30);
            }
            lblDownloadConcluido.Visible = true;

            await Task.Delay(3000); // Usando Task.Delay para não bloquear o thread da UI, permitindo atualizar a interface gráfica

            for (int i = 1; i <= 100; i++)
            {
                MoverCursorMouse();
                Click();
                Thread.Sleep(10); //executa cada click em um intervalo de 10 microssegundos
            }
        }

        private void Click()
        {
            // Pressiona e solta o botão esquerdo assim executando o click duplo
            mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }
    }
}
