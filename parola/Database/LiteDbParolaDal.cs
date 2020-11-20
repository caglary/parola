using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace parola.Database
{
    public class LiteDbParolaDal : IParolaDAL
    {
        public string DatabaseConnectionString
        {
            get
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                return $"{currentDirectory}\\Passwords.db";
            }
        }
        public int Delete(parola _parola)
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {

                var collection = db.GetCollection<parola>();
                try
                {
                    collection.Delete(_parola.parolaid);
                    return 1;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);

                }

            }
        }

        public List<parola> GetAll()
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {
                var collection = db.GetCollection<parola>();
                return collection.FindAll().ToList();
            }
        }

        public int Save(parola _parola)
        {



            using (var db = new LiteDatabase(DatabaseConnectionString))
            {
                var collection = db.GetCollection<parola>();
                try
                { 
                    var result= collection.Insert(_parola);
                    return 1;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public int Update(parola _parola)
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {
                var collection = db.GetCollection<parola>();
                try
                {
                    collection.Update(_parola);
                    return 1;
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }

            }
        }

        public string WhatIsTheConnectionString()
        {
            return DatabaseConnectionString;
        }
    }
}
