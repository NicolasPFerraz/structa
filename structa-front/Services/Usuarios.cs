using structa_front.Models;
using static Supabase.Postgrest.Constants;

namespace structa_front.Services
{
    public class UsuariosService
    {
        private readonly DatabaseService? _db = ServiceProvider.Database;

        public UsuariosService()
        {
            if (_db == null)
            {
                throw new InvalidOperationException("DatabaseService not initialized");
            }
        }

        public async Task<List<Usuario>> BuscarUsuariosAsync()
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Usuario>()
                .Select("*")
                .Get();
                
            return response.Models;
        }

        public async Task<Usuario?> BuscarUsuarioPorIdAsync(int id)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Usuario>()
                .Select("*")
                .Filter("id", Operator.Equals, id)
                .Single();

            return response;
        }

        public async Task<Usuario> CriarUsuarioAsync(Usuario novoUsuario)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Usuario>()
                .Insert(novoUsuario);

            return response.Models.FirstOrDefault();
        }
    }
}
