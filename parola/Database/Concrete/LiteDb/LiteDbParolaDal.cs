using LiteDB;
using parola.Database.Abstract;
using parola.Entities;
using parola.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace parola.Database.Concrete.LiteDb
{
    public class LiteDbParolaDal : IParolaDal
    {
        private string DatabaseConnectionString
        {
            get
            {
                


              
                string connectionString = Directory.GetCurrentDirectory()+ "\\connectionString.txt";
                if (!File.Exists(connectionString))
                {
                    FileStream fs = new FileStream(connectionString, FileMode.Create);
                    fs.Close();
                                      
                    File.WriteAllText(connectionString, $"{Directory.GetCurrentDirectory()}\\Passwords.db");
                    return File.ReadAllText(connectionString);

                }
                else
                {
                    var dbName=File.ReadAllText(connectionString);
                    if (string.IsNullOrEmpty(dbName))
                    {
                        File.WriteAllText(connectionString, $"{connectionString}\\Passwords.db");
                        dbName = File.ReadAllText(connectionString);
                    }

                    return dbName;
                }
   

               
            }
        }

        public int Add(Parola entity)
        {
            
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {
                var collection = db.GetCollection<Parola>();
                try
                {
                    entity.parolaid = 0;
                    var result = collection.Insert(entity);
                    return 1;
                }
                catch (Exception e)
                {
                    return -1;
                    throw new Exception(e.Message);
                }

            }
        }

        public int Delete(Parola entity)
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {

                var collection = db.GetCollection<Parola>();
                try
                {
                    collection.Delete(entity.parolaid);
                    return 1;
                }
                catch (Exception e)
                {
                    return -1;
                    throw new Exception(e.Message);

                }

            }
        }

        public Parola Get(Expression<Func<Parola, bool>> filter)
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {

                var collection = db.GetCollection<Parola>();

                return collection.Query().Where(filter).FirstOrDefault();

            }
        }



        public List<Parola> GetAll(Expression<Func<Parola, bool>> filter)
        {
            if (filter == null)
            {
                using (var db = new LiteDatabase(DatabaseConnectionString))
                {
                    var collection = db.GetCollection<Parola>();
                    return collection.FindAll().ToList();
                }
            }
            else
            {
                using (var db = new LiteDatabase(DatabaseConnectionString))
                {
                    var collection = db.GetCollection<Parola>();
                    return collection.Query().Where(filter).ToList();
                }
            }


        }



        public int Update(Parola entity)
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {
                var collection = db.GetCollection<Parola>();
                try
                {
                    collection.Update(entity);
                    return 1;

                }
                catch (Exception e)
                {
                    return -1;
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
