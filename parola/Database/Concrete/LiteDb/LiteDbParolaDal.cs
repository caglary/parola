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
                string currentDirectory = Directory.GetCurrentDirectory();
                return $"{currentDirectory}\\Passwords.db";
            }
        }

        public void Add(Parola entity)
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {
                var collection = db.GetCollection<Parola>();
                try
                {
                    var result = collection.Insert(entity);

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public void Delete(Parola entity)
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {

                var collection = db.GetCollection<Parola>();
                try
                {
                    collection.Delete(entity.parolaid);

                }
                catch (Exception e)
                {
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



        public void Update(Parola entity)
        {
            using (var db = new LiteDatabase(DatabaseConnectionString))
            {
                var collection = db.GetCollection<Parola>();
                try
                {
                    collection.Update(entity);

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
