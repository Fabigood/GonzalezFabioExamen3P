using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using GonzalezFabioExamen3P.Models;

namespace GonzalezFabioExamen3P.Services
{
    public class DatabaseService
    {
        readonly SQLiteAsyncConnection db;

        public DatabaseService(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Contacto>().Wait();
        }

        public Task<int> AddContacto(Contacto contacto)
        {
            return db.InsertAsync(contacto);
        }

        public Task<List<Contacto>> GetContactos()
        {
            return db.Table<Contacto>().ToListAsync();
        }
    }
}