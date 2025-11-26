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

            var existingUserResponse = await _db.Client
                .From<Usuario>()
                .Select("*")
                .Where(u => u.Email == novoUsuario.Email || u.Nome == novoUsuario.Nome)
                .Single();

            if (existingUserResponse != null)
            {
                throw new InvalidOperationException("Usuário com o mesmo email ou nome já existe");
            }

            var newUserResponse = await _db.Client
                .From<Usuario>()
                .Insert(novoUsuario);

            return newUserResponse.Models.FirstOrDefault();
        }
    }
}
