using Supabase;
using Supabase.Postgrest;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace structa_front.Services
{
    public class DatabaseService
    {
        private readonly string _url = "https://fcgwnxbeytolkqovqgvo.supabase.co";
        private readonly string _key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImZjZ3dueGJleXRvbGtxb3ZxZ3ZvIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjI5NzIwODEsImV4cCI6MjA3ODU0ODA4MX0.fNV-sOX2eZVTIXtAFtzgLaiN88dytcR_pekE1SYE5xE";

        private Supabase.Client _client;

        public async Task InitializeAsync()
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = false,
            };

            _client = new Supabase.Client(_url, _key, options);
            await _client.InitializeAsync();
        }

        public async Task BuscarUsuariosAsync()
        {
            if (_client == null)
                throw new InvalidOperationException("O cliente Supabase ainda não foi inicializado.");

            var response = await _client
                .From("usuarios")
                .Select("*")
                .Get();

            var json = response.Content; // string JSON bruta
            Console.WriteLine(json);
        }
    }
}
