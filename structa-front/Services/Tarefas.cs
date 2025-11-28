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

            var newResponse = await _db.Client
                .From<Tarefa>()
                .Insert(novaTarefa);

            return newResponse.Models.FirstOrDefault();
        }
        public async Task<List<Tarefa>> ObterTarefasAsync(int idUsuario, int idProjeto)
        {
            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = await _db.Client
                .From<Tarefa>()
                .Select("*")
                .Where(t => t.IdUsuario == idUsuario && t.IdProjeto == idProjeto)
                .Get();

            return response.Models;
        }
        public async Task<List<Tarefa>> AtualizarTarefas(Tarefa tarefaAtualizada)
        {
            if (tarefaAtualizada == null)
                throw new ArgumentNullException(nameof(tarefaAtualizada));

            if (!_db.IsReady)
                throw new InvalidOperationException("Supabase não inicializado");

            var response = (object)null;

            if (tarefaAtualizada.Id > 0)
            {
                response = await _db.Client
                    .From<Tarefa>()
                    .Where(t => t.Id == tarefaAtualizada.Id)
                    .Update(tarefaAtualizada);
            }
            else
            {
                response = await _db.Client
                    .From<Tarefa>()
                    .Where(t => t.IdUsuario == tarefaAtualizada.IdUsuario && t.IdProjeto == tarefaAtualizada.IdProjeto)
                    .Update(tarefaAtualizada);
            }

            // response has Models property
            var modelsProp = response.GetType().GetProperty("Models");
            if (modelsProp != null)
            {
                return (List<Tarefa>)modelsProp.GetValue(response);
            }

            return new List<Tarefa>();
        }
    }
}
