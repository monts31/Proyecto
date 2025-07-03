namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


           
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtQR.Text.Equals("hola"))
            {
                textBox1.Text = "OK";
            }
          

        }
    }
}
