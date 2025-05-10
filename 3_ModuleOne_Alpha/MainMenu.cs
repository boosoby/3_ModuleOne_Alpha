namespace _3_ModuleOne_Alpha
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1Clients_Click(object sender, EventArgs e)
        {
            _1Clients formLogIn = new _1Clients(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();

        }

        private void button2Plan_Click(object sender, EventArgs e)
        {
            _2Plan formLogIn = new _2Plan(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button3Tasks_Click(object sender, EventArgs e)
        {

            _3Tasks formLogIn = new _3Tasks(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button4WorkTime_Click(object sender, EventArgs e)
        {
            _4Worktime formLogIn = new _4Worktime(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button5Projects_Click(object sender, EventArgs e)
        {
            _5Projects formLogIn = new _5Projects(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button6Deals_Click(object sender, EventArgs e)
        {
            _6Deals formLogIn = new _6Deals(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button7Efficiency_Click(object sender, EventArgs e)
        {
            _7Efficiency formLogIn = new _7Efficiency(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button8Images_Click(object sender, EventArgs e)
        {
            _8Images formLogIn = new _8Images(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button9Settings_Click(object sender, EventArgs e)
        {
            _9Settings formLogIn = new _9Settings(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button10PlanAnalysis_Click(object sender, EventArgs e)
        {
            _10PlanAnalysis formLogIn = new _10PlanAnalysis(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void button11DealAnalysis_Click(object sender, EventArgs e)
        {
            _11DealAnalysis formLogIn = new _11DealAnalysis(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _14Avg formLogIn = new _14Avg(); //FormLogIn — имя формы, которую хотим открыть
            formLogIn.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _EmailConfig _emailConfig = new _EmailConfig();
            _emailConfig.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _EmailSend _emailSend = new _EmailSend();
            _emailSend.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _Calendar_Config calendar_Config = new _Calendar_Config();
            calendar_Config.ShowDialog();
        }
    }
}
