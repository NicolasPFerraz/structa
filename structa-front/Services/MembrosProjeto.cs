using structa_front.Models;
using static Supabase.Postgrest.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structa_front.Services
{
    internal class MembrosProjetoService
    {
        private readonly DatabaseService? _db = ServiceProvider.Database;
        public MembrosProjetoService()
        {
            if (_db == null)
            {
                throw new InvalidOperationException("DatabaseService not initialized");
            }
        }
        public async Task<MembroProjetos> CriarMembroProjeto(int id, string funcao, int idProjeto)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var newProjectMember = await _db.Client
                .From<MembroProjetos>()
                .Insert(new MembroProjetos
                {
                    IdUsuario = id,
                    Funcao = funcao,
                    idProjeto = idProjeto
                });

            return newProjectMember.Models.FirstOrDefault();
        }

        // Buscar membros de um projeto
        public async Task<List<MembroProjetos>> BuscarMembrosAsync(int idProjeto)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<MembroProjetos>()
                .Select("*")
                .Filter("id_projeto", Operator.Equals, idProjeto)
                .Get();

            return response.Models;
        }

        // Buscar membros com dados do usuário (nome, email, etc)
        public async Task<List<(MembroProjetos, Usuario)>> BuscarMembrosComDadosAsync(int idProjeto)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var membros = await BuscarMembrosAsync(idProjeto);
            var usuariosService = new UsuariosService();
            var resultado = new List<(MembroProjetos, Usuario)>();

            foreach (var membro in membros)
            {
                var usuario = await usuariosService.BuscarUsuarioPorIdAsync(membro.IdUsuario);
                if (usuario != null)
                    resultado.Add((membro, usuario));
            }

            return resultado;
        }
    }
}
