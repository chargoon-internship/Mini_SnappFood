namespace SnappFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BusinessLogicLayer.CustomerValidation customerValidation=new BusinessLogicLayer.CustomerValidation();


        }
    }
}