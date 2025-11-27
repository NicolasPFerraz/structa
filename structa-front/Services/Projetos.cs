using structa_front.Models;
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
        public async Task<Projeto> CriarProjetoAsync(int id)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var newProjectResponse = await _db.Client
                .From<Projeto>()
                .Insert(new Projeto
                {
                    Nome = "Meu novo projeto",
                    DescricaoProjeto = "Descrição do novo projeto",
                });

            var projectMembersService = new MembrosProjetoService();
            var newProjectMember = await 
                projectMembersService.CriarMembroProjeto(id, "Administrador", newProjectResponse.Models.FirstOrDefault().Id);
             
            return newProjectResponse.Models.FirstOrDefault();
        }
    }
}
