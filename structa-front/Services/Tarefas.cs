using structa_front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structa_front.Services
{
    internal class TarefasService
    {
        private readonly DatabaseService? _db = ServiceProvider.Database;

        public TarefasService()
        {
            if (_db == null)
            {
                throw new InvalidOperationException("DatabaseService not initialized");
            }
        }
        public async Task<Tarefa> CriarTarefaAsync(Tarefa novaTarefa)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");


            var newUserResponse = await _db.Client
                .From<Tarefa>()
                .Insert(novaTarefa);

            var projetosService = new ProjetosService();
            var newProjectResponse = await projetosService.CriarProjetoAsync(newUserResponse.Models.FirstOrDefault().Id);

            return newUserResponse.Models.FirstOrDefault();
        }
    }
}
