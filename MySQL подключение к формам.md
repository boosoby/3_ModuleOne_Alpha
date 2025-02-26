это класс для подключения бд. просто создаем кнопкой Add
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Demo
{
     public class DBCon
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;

        
public void Connect()
{
            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=10106;database=first";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                MessageBox.Show("Succeed");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

```

это форма. нужно в проект скачать MySQL.Data через NuGet 
```

namespace _1_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBCon dBCon = new DBCon();
            dBCon.Connect();
        }
    }
}

```

https://www.nuget.org/packages/MySql.Data/9.1.0#show-readme-container — официальный пример

https://www.codeproject.com/Articles/43438/Connect-Csharp-to-MySQL — тут за нас сделаны все CRUD операции