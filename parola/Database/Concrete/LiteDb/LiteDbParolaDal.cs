﻿using LiteDB;
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
                //The database has been moved out of the program folder so that it does not appear in github.
                string currentDirectory = Directory.GetCurrentDirectory();
                var bin = Directory.GetParent(currentDirectory);
                var parola = Directory.GetParent(bin.FullName);
                var directoryParola = Directory.GetParent(parola.FullName);
                var pathDatabase = Directory.GetParent(directoryParola.FullName);

                string directoryDatabase = pathDatabase + @"\Database";
                if (!Directory.Exists(directoryDatabase))
                {
                    Directory.CreateDirectory(directoryDatabase);
                }

                var fileOfDatabase = $"{directoryDatabase}\\Passwords.db";
                return fileOfDatabase;
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
