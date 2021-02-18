    class DataTable
    {
        static public DataTable vhod(string a)
        {
            DataTable dt = new DataTable();
            MySqlConnectionStringBuilder X = new MySqlConnectionStringBuilder();
            X.Server = "IP you DataBase"; //Данные для подключения к БД
            X.Port = 3306;
            X.Database = "DataBase Name";
            X.UserID = "User Name";
            X.Password = "You password";
            X.CharacterSet = "utf8";
            MySqlConnection connect = new MySqlConnection(X.ToString());
            string queryString = @a;
            MySqlCommand command = new MySqlCommand(queryString, connect);
            try
            {
                connect.Open(); //Открываем соединение с БД
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Equals(dr);
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Выводим ошибки которые могут возникнуть при подключении
            }
            return dt; //Возврщаем значение dt
        }
    }
}