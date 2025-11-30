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
            // Configure o Supabase com sua URL e chave de API
            var options = new Supabase.SupabaseOptions
            {
                AutoRefreshToken = true
                // Removido: AutoConnectRealtime = true
            };

            Client = new Supabase.Client("SUA_SUPABASE_URL", "SUA_SUPABASE_API_KEY", options);

        }
    }
}
