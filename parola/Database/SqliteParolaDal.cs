using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
namespace parola.Database
{
    public class SqliteParolaDal : IParolaDAL
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        public SqliteParolaDal()
        {
            con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            DatabaseExist();
        }
        void DatabaseExist()
        {
            if (!File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");
                string sql = @"create TABLE Parola (
                          Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                          Name     TEXT   NOT NULL,
                          UserName TEXT   DEFAULT 'UNKNOWN',
                          Password TEXT    DEFAULT 'UNKNOWN',
                          Note     TEXT    DEFAULT '',
                          CreationDate TEXT DEFAULT 'UNKNOWN',
                          SeleniumMethod	TEXT DEFAULT 'UNKNOWN',
                          UNIQUE ( Name));";
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
     
        public int Delete(parola parola)
        {
            string query = "DELETE FROM Parola WHERE Id=@Id ";
            con.Open();
            cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", parola.parolaid);
            cmd.ExecuteReader();
            con.Close();
            return 1;
        }
        public List<parola> GetAll()
        {
            List<parola> ParolaListesi = new List<parola>();
            cmd = new SQLiteCommand("Select * From Parola", con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                parola _parola = new parola();
                _parola.parolaid = reader.GetInt32(0);
                _parola.isim = reader.GetString(1) == null ? "" : reader.GetString(1);
                _parola.kullaniciadi = reader.GetString(2) == null ? "" : reader.GetString(2);
                _parola.parola_ = reader.GetString(3) == null ? "" : reader.GetString(3);
                _parola.aciklama = reader.GetString(4) == null ? "" : reader.GetString(4);
                _parola.SeleniumMethod = reader.GetString(6) == null ? "" : reader.GetString(6);
                ParolaListesi.Add(_parola);
            }
            con.Close();
            return ParolaListesi;
        }
        public int Save(parola parola)
        {
            string query = "INSERT INTO Parola (Name,UserName,Password,Note,CreationDate,SeleniumMethod) VALUES (@Name,@UserName, @Password,@Note,@CreationDate,@SeleniumMethod ); ";
            con.Open();
            cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", parola.isim);
            cmd.Parameters.AddWithValue("@UserName", parola.kullaniciadi);
            cmd.Parameters.AddWithValue("@Password", parola.parola_);
            cmd.Parameters.AddWithValue("@Note", parola.aciklama);
            cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@SeleniumMethod", string.IsNullOrEmpty(parola.SeleniumMethod) ? "":parola.SeleniumMethod) ;
            int Result = cmd.ExecuteNonQuery();
            con.Close();
            return Result;
        }
        public int Update(parola _parola)
        {
            string query = "UPDATE Parola SET Name=@Name,UserName=@UserName,Password=@Password,Note=@Note,CreationDate=@CreationDate,SeleniumMethod=@SeleniumMethod WHERE Id=@Id ";
            con.Open();
            cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", _parola.isim);
            cmd.Parameters.AddWithValue("@UserName", _parola.kullaniciadi);
            cmd.Parameters.AddWithValue("@Password", _parola.parola_);
            cmd.Parameters.AddWithValue("@Note", _parola.aciklama);
            cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@SeleniumMethod",string.IsNullOrEmpty(_parola.SeleniumMethod)?"":_parola.SeleniumMethod);
            cmd.Parameters.AddWithValue("@Id", _parola.parolaid);
            int Result = cmd.ExecuteNonQuery();
            con.Close();
            return Result;
        }
        public string WhatIsTheConnectionString()
        {
            return "MyDatabase.sqlite";
        }
    }
}
