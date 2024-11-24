namespace WinOpenFileDialog
{
    public partial class Form1 : Form
    {
        OpenFileDialog abrir = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif";
            abrir.Multiselect = true;

            if(abrir.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(abrir.FileNames[0].ToString());
                pictureBox2.Image = System.Drawing.Image.FromFile(abrir.FileNames[1].ToString());
                pictureBox3.Image = System.Drawing.Image.FromFile(abrir.FileNames[2].ToString());
                pictureBox4.Image = System.Drawing.Image.FromFile(abrir.FileNames[3].ToString());
                pictureBox5.Image = System.Drawing.Image.FromFile(abrir.FileNames[4].ToString());
                pictureBox6.Image = System.Drawing.Image.FromFile(abrir.FileNames[5].ToString());
            }

        }
    }
}
