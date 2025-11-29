using structa_front.Models;
using static Supabase.Postgrest.Constants;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace structa_front.Services
{
    public class NotificacoesService
    {
        private readonly DatabaseService? _db = ServiceProvider.Database;

        public NotificacoesService()
        {
            if (_db == null)
                throw new InvalidOperationException("DatabaseService not initialized");
        }
    }
}