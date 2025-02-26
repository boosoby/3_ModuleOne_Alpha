```
dateTimePicker1.Format = DateTimePickerFormat.Custom;
dateTimePicker1.CustomFormat = "yyyy'-'MM'-'dd hh':'mm':'ss";
string demoddate = dateTimePicker1.CustomFormat.ToString();
MessageBox.Show(demoddate);
```
