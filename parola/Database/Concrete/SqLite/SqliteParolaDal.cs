using parola.Database.Abstract;
using parola.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq.Expressions;

namespace parola.Database
{
    public class SqliteParolaDal : IParolaDal
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
        public string WhatIsTheConnectionString()
        {
            return "MyDatabase.sqlite";
        }

        public List<Parola> GetAll(Expression<Func<Parola, bool>> filter=null)
        {
            List<Parola> ParolaListesi = new List<Parola>();
            cmd = new SQLiteCommand("Select * From Parola", con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Parola _parola = new Parola();
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

        public Parola Get(Expression<Func<Parola, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public int Add(Parola entity)
        {
            string query = "INSERT INTO Parola (Name,UserName,Password,Note,CreationDate,SeleniumMethod) VALUES (@Name,@UserName, @Password,@Note,@CreationDate,@SeleniumMethod ); ";
            con.Open();
            cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", entity.isim);
            cmd.Parameters.AddWithValue("@UserName", entity.kullaniciadi);
            cmd.Parameters.AddWithValue("@Password", entity.parola_);
            cmd.Parameters.AddWithValue("@Note", entity.aciklama);
            cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@SeleniumMethod", string.IsNullOrEmpty(entity.SeleniumMethod) ? "" : entity.SeleniumMethod);
            int result=cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }

        public int Update(Parola entity)
        {
            string query = "UPDATE Parola SET Name=@Name,UserName=@UserName,Password=@Password,Note=@Note,CreationDate=@CreationDate,SeleniumMethod=@SeleniumMethod WHERE Id=@Id ";
            con.Open();
            cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", entity.isim);
            cmd.Parameters.AddWithValue("@UserName", entity.kullaniciadi);
            cmd.Parameters.AddWithValue("@Password", entity.parola_);
            cmd.Parameters.AddWithValue("@Note", entity.aciklama);
            cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@SeleniumMethod", string.IsNullOrEmpty(entity.SeleniumMethod) ? "" : entity.SeleniumMethod);
            cmd.Parameters.AddWithValue("@Id", entity.parolaid);
            int result=cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public int Delete(Parola entity)
        {
            string query = "DELETE FROM Parola WHERE Id=@Id ";
            con.Open();
            cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", entity.parolaid);
            cmd.ExecuteReader();
            con.Close();
            //kodlanması gerek . şimdilik operasyonda hata almadığıı varsayoyorum.
            //ve geri dönüş değeri olarak 1 gönderiyorum.
            return 1;
        }
    }
}
