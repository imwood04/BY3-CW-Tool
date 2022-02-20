using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BY3_CW_Tool
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Trainer.BackColor = Color.FromArgb(17, 25, 30);
            Aim.BackColor = Color.FromArgb(17, 25, 30);
            Visual.BackColor = Color.FromArgb(50, 50, 50);
            Misc.BackColor = Color.FromArgb(17, 25, 30);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Main_Click_1(object sender, EventArgs e)
        {
            Trainer.BackColor = Color.FromArgb(17, 25, 30);
            Aim.BackColor = Color.FromArgb(50, 50, 50);
            Visual.BackColor = Color.FromArgb(17, 25, 30);
            Misc.BackColor = Color.FromArgb(17, 25, 30);
        }

        private void Misc_Click(object sender, EventArgs e)
        {
            Trainer.BackColor = Color.FromArgb(17, 25, 30);
            Aim.BackColor = Color.FromArgb(17, 25, 30);
            Visual.BackColor = Color.FromArgb(17, 25, 30);
            Misc.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void Trainer_Click(object sender, EventArgs e)
        {
            Trainer.BackColor = Color.FromArgb(50, 50, 50);
            Aim.BackColor = Color.FromArgb(17, 25, 30);
            Visual.BackColor = Color.FromArgb(17, 25, 30);
            Misc.BackColor = Color.FromArgb(17, 25, 30);
        }

        private void CloseMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}