﻿using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context(); //baglamak icin
        DbSet<T> _object;

        public Repository()
        {
            //contexten gelen degeri tutmak icin 
            _object = c.Set<T>();
        }
        public int Delete(T p) // T tablo p parametreler
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);

        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();

        }

        public int Update(T p)
        {
            return c.SaveChanges();

        }
    }
}
