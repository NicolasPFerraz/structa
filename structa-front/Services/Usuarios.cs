using structa_front.Models;
using static Supabase.Postgrest.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            var usuarioCriado = newUserResponse.Models.FirstOrDefault();

            //  CORREÇÃO: chamada ajustada 
            var projetosService = new ProjetosService();
            var newProjectResponse = await projetosService
                .CriarProjetoAsync("Projeto Inicial", usuarioCriado.Nome);

            return usuarioCriado;
        }

        public async Task<Usuario> LogarUsuarioAsync(Usuario usuario)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Usuario>()
                .Select("*")
                .Where(u => u.Email == usuario.Email && u.Senha == usuario.Senha)
                .Single();

            if (response == null)
            {
                throw new InvalidOperationException("Credenciais inválidas");
            }

            return response;
        }

        // Método para atualizar usuário existente
        public async Task<Usuario?> AtualizarUsuarioAsync(Usuario usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Usuario>()
                .Where(u => u.Id == usuario.Id)
                .Update(usuario);

            return response.Models?.FirstOrDefault();
        }

        public async Task<Usuario?> VerificarSenhaAsync(int idUsuario, string senha)
        {
            if (idUsuario == null)
                throw new ArgumentNullException(nameof(idUsuario));

            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Usuario>()
                .Select("*")
                .Where(u => u.Id == idUsuario && u.Senha == senha)
                .Single();

            return response;
        }
        public async Task<Usuario?> BuscarUsuarioPorEmailAsync(string email)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Usuario>()
                .Select("*")
                .Filter("email", Operator.Equals, email)
                .Single();

            return response;
        }
    }
}