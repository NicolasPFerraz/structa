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
        // Buscar projetos de um usuário específico (CORRIGIDO E OTIMIZADO)
        public async Task<List<Projeto>> BuscarProjetosAsync(int usuarioId)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            // 1. buscar ids de projetos do usuário
            var membrosResponse = await _db.Client
                .From<MembroProjetos>()
                .Select("id_projeto")
                .Where(p => p.IdUsuario == usuarioId)
                .Get();

            var idsProjetos = membrosResponse.Models
                .Select(m => m.idProjeto)
                .Distinct()
                .ToList();

            if (!idsProjetos.Any())
                return new List<Projeto>();

            // 2. buscar todos (ou buscar por paginação/condição) e filtrar localmente
            var allProjectsResponse = await _db.Client
                .From<Projeto>()
                .Select("*")
                .Get();

            var allProjects = allProjectsResponse.Models;

            // 3. filtrar localmente
            var projetosDoUsuario = allProjects
                .Where(p => idsProjetos.Contains(p.Id))
                .ToList();

            return projetosDoUsuario;
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
