namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DateTime timp = DateTime.Now;
            this.CreateGraphics().DrawString(timp.ToString(), this.Font, new SolidBrush(Color.Black), 10.0f, 10.0f);
        }
    }
}