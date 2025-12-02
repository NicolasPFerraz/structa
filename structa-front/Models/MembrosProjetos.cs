using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace structa_front.Models
{
    [Table("membros_projetos")]
    public class MembroProjetos : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("id_projeto")]
        public int idProjeto { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("funcao")]
        public string Funcao { get; set; } = string.Empty;

        [Column("datahora_entrada")]
        public DateTime DataEntrada { get; set; }
    }
}