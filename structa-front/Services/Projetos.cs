using structa_front.Models;
using static Supabase.Postgrest.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structa_front.Services
{
    internal class ProjetosService
    {
        private readonly DatabaseService? _db = ServiceProvider.Database;

        public ProjetosService()
        {
            if (_db == null)
            {
                throw new InvalidOperationException("DatabaseService not initialized");
            }
        }

        public async Task<Projeto> CriarProjetoAsync(string nomeProjeto, string nomeResponsavel)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var novoProjeto = new Projeto
            {
                Nome = nomeProjeto,
                DescricaoProjeto = "",
                DataCriacao = DateTime.UtcNow,
                DataUltimaAtualizacao = DateTime.UtcNow,
                Responsavel = nomeResponsavel
            };

            var response = await _db.Client
                .From<Projeto>()
                .Insert(novoProjeto);

            return response.Models.FirstOrDefault();
        }



        // Buscar todos os projetos
        public async Task<List<Projeto>> BuscarProjetosAsync()
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Projeto>()
                .Select("*")
                .Get();

            return response.Models;
        }

        // Buscar projetos de um usuário específico
        public async Task<List<Projeto>> BuscarProjetosAsync(int usuarioId)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            // Buscar primeiro os membros_projetos que pertencem ao usuário
            var membrosResponse = await _db.Client
                .From<MembroProjetos>()
                .Select("*")
                .Filter("id_usuario", Operator.Equals, usuarioId)
                .Get();

            var idsProjetosDoUsuario = membrosResponse.Models.Select(m => m.idProjeto).ToList();

            if (idsProjetosDoUsuario.Count == 0)
                return new List<Projeto>();

            // Buscar projetos pelos IDs
            var projetos = new List<Projeto>();
            foreach (var idProjeto in idsProjetosDoUsuario)
            {
                var projeto = await _db.Client
                    .From<Projeto>()
                    .Select("*")
                    .Filter("id", Operator.Equals, idProjeto)
                    .Single();

                if (projeto != null)
                    projetos.Add(projeto);
            }

            return projetos;
        }

        // Buscar projeto por ID
        public async Task<Projeto?> BuscarProjetoPorIdAsync(int id)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Projeto>()
                .Select("*")
                .Filter("id", Operator.Equals, id)
                .Single();

            return response;
        }
    }
}
