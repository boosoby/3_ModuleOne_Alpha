namespace DemoTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string text;
        string IDmanagers;
        private void Form1_Load(object sender, EventArgs e)
        {
            DB dbSelect = new DB();
            dbSelect.Select();

            dataGridView1.DataSource = dbSelect.Select();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                if (Rows.Selected)
                {


                    text = Rows.Cells[0].Value.ToString();
                    DB dBSelect = new DB();
                    int select_ID = Convert.ToInt32(text);
                    textBox2.Text = dBSelect.Count(select_ID);




                }

            }
        }
    }
}
