```
 DataTable table = new DataTable();
 table.Columns.Add("ID", Type.GetType("System.Int32"));
 table.Columns.Add("Name", Type.GetType("System.String"));
 table.Rows.Add(new string[] { "1", "Sanya"});
 
 dataGridView1.DataSource = table;
```
этот код создает две колонки и выводит значения 1 и Sanya в них

- https://danimals.ru/i/datagridview-v-c-podrobnoe-rukovodstvo-i-primery-raboty-s-etim-moshhnym-instrumentom/ — примеры по работе с DataGridView
- https://metanit.com/sharp/tutorial/4.5.php — работа с List