using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace _3_ModuleOne_Alpha
{
    class DB_6Deals
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DB_6Deals()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {


            server = "127.0.0.1";
            database = "firstmodule2";
            uid = "root";
            password = "106106";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string date, int amount, int iddeal_status, int idclients, string deals_name, string pay_date)
        {
            
           
            var testList = new List<string>();
            testList = Select_client_managers(idclients);
            string idclient_managers = testList[0];
            string query = $"insert into deals (date, amount, iddeal_status, idclient_managers, deals_name, pay_date, idpay_status)\r\nvalues ('{date}','{amount}','{iddeal_status}','{idclient_managers}', '{deals_name}', '{pay_date}', 2);";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                //
                //close connection
                this.CloseConnection();
            }
        }

        public void Insert_payment_deal(string pay_date, int pay_status)
        {


            int iddeals = Select_last_deal();
            
            string query = $"insert into payment (pay_date, pay_status, iddeals) values ('{pay_date}','{pay_status}','{iddeals}');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public int Select_last_deal()
        {

            string query = "SELECT iddeals FROM deals ORDER BY iddeals desc limit 1";
            List<string> list = new List<string>();
            list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["iddeals"] + "");


                }

               
                
                int iddeals = Convert.ToInt32(list[0]);
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return iddeals;
            }
            else
            {
                int iddeals = 0;
                return iddeals ;
            }
        }


        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public BindingSource Select()
        {
            string query =
@"select 
deals.iddeals as 'ID', clients.full_name as 'Имя клиента',
 managers.full_name as 'Имя менеджера', goods.good_name as 'Товар/услуга',
deals.amount as 'Сумма сделки',
deals.pay_date as 'Срок оплаты',
pay_status.status_name as 'Статус оплаты',
deals.deals_percent as 'Процент оплаты',
deals.deals_name as 'Название сделки',
clients.idclients as 'ID клиента'
 from deals
left join pay_status on pay_status.idpay_status = deals.idpay_status
join client_managers on deals.idclient_managers = client_managers.idclient_managers
join clients on client_managers.idclients = clients.idclients
join managers on client_managers.idmanagers = managers.idmanagers
join goods_in_deals on deals.iddeals = goods_in_deals.iddeals
join goods on goods.idgoods = goods_in_deals.idgoods
order by deals.iddeals;";



            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;


                //close Connection
                this.CloseConnection();


                return bindingSource;
            }
            else
            {
                // return list;
                return null;
            }
        }

        public List<string> Select_client_managers(int idclients)
        {
            string query = $"select idclient_managers from client_managers\r\nwhere idclients = {idclients};";

            List<string> list = new List<string>();
            list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["idclient_managers"] + "");


                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }



        public string Select_pay_date(int iddeals)
        {

            string query = $"SELECT pay_date FROM deals where iddeals = {iddeals}";
            List<string> list = new List<string>();
            list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["pay_date"] + "");
                }

                try
                {
                string pay_date = Convert.ToString(list[0]);
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return pay_date;
                    //blah
                }
                catch { }
                return null;
            }
            else
            {
                string pay_date = "";
                return pay_date;
            }
        }



        public string Select_pay_status(int iddeals)
        {

            string query = $"SELECT idpay_status FROM deals where iddeals = {iddeals}";
            List<string> list = new List<string>();
            list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(dataReader["idpay_status"] + "");
                }

                try
                {
                    string pay_status = Convert.ToString(list[0]);
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return pay_status;
                    //blah
                }
                catch { }
                return null;
            }
            else
            {
                string pay_status = "";
                return pay_status;
            }
        }
        public BindingSource Select_goods_in_d(int iddeals)
        {
            string query =
@$"select deals.iddeals as 'ID', 
deals.date as 'Дата сделки',
 quantity as 'Количество',
 good_name as 'Название товара', 
 price as 'Цена товара',
 amount as 'Итоговая сумма' from goods_in_deals
join goods on goods.idgoods = goods_in_deals.idgoods
join deals on deals.iddeals = goods_in_deals.iddeals
where deals.iddeals = {iddeals}
order by deals.amount;";



            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;


                //close Connection
                this.CloseConnection();


                return bindingSource;
            }
            else
            {
                // return list;
                return null;
            }
        }


        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM deals";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
