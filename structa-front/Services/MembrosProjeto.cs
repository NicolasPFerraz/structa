using structa_front.Models;
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
    }
}
