using Supabase;
using Supabase.Gotrue;
using System.Threading.Tasks;

namespace structa_front.Config
{
    public static class SupabaseConfig
    {
        public static Supabase.Client Client { get; private set; }

        static SupabaseConfig()
        {
            // Corrigido: use SupabaseOptions em vez de ClientOptions
            var options = new Supabase.SupabaseOptions
            {
                AutoRefreshToken = true
                // Removido: AutoConnectRealtime = true
            };

            Client = new Supabase.Client(
                "https://fcgwnxbeytolkqovqgvo.supabase.co",
                "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImZjZ3dueGJleXRvbGtxb3ZxZ3ZvIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjI5NzIwODEsImV4cCI6MjA3ODU0ODA4MX0.fNV-sOX2eZVTIXtAFtzgLaiN88dytcR_pekE1SYE5xE",
                options
            );
        }
    }
}
