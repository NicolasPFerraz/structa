using Supabase;
using structa_front.Models;

namespace structa_front.Services
{
    public class DatabaseService
    {
        // URL do seu projeto Supabase
        private readonly string _url = "https://fcgwnxbeytolkqovqgvo.supabase.co";

        // Chave ANON pública do Supabase (nunca coloque a service_role)
        private readonly string _key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImZjZ3dueGJleXRvbGtxb3ZxZ3ZvIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjI5NzIwODEsImV4cCI6MjA3ODU0ODA4MX0.fNV-sOX2eZVTIXtAFtzgLaiN88dytcR_pekE1SYE5xE";

        // Indica se o cliente já foi inicializado
        public bool IsReady => _client != null;

        // Instância principal do cliente Supabase
        private Supabase.Client _client;

        public async Task InicializarAsync()
        {
            // Configurações básicas (realtime desligado)
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = false,
            };

            // Inicializa o client com URL + key + opções
            _client = new Supabase.Client(_url, _key, options);

            // Conecta ao Supabase e carrega as configs internas
            await _client.InitializeAsync();

            // Teste rápido para verificar se está acessando a tabela
            var teste = await _client.From<Usuario>().Limit(1).Get();

            // Exibe quantas linhas conseguiu pegar (0 ou 1)
            MessageBox.Show("Rows na tabela usuario: " + teste.Models.Count);
        }

        // Busca todos os usuários da tabela "usuarios"
        public async Task<List<Usuario>> BuscarUsuariosAsync()
        {
            // Evita tentativa de uso antes da inicialização
            if (_client == null)
                throw new InvalidOperationException("O cliente Supabase ainda não foi inicializado.");

            // Executa SELECT * FROM usuarios
            var response = await _client
                .From<Usuario>()
                .Select("*")
                .Get();

            // Retorna os objetos convertidos no formato List<Usuario>
            return response.Models;
        }
    }
}
