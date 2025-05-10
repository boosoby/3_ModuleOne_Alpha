namespace DemoTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DateTime dateStart;
        public DateTime dateEnd;
        private void button2_Click(object sender, EventArgs e)
        {
            labelEnd.Text = DateTime.Now.ToString();
            dateEnd = DateTime.Now;
            var hours = (dateEnd - dateStart).Hours;
            var minutes = (dateEnd - dateStart).Minutes;
           
            labelQH.Text = hours.ToString();
            labelQM.Text = minutes.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelStart.Text = DateTime.Now.ToString();
            dateStart = DateTime.Now;
        }
    }
}
