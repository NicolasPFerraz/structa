using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace structa_front.Models
{
    [Table("tarefas")]
    public class Tarefa : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("id_projeto")]
        public int IdProjeto { get; set; }
        [Column("id_usuario")]
        public int IdUsuario{ get; set; }

        [Column("titulo")]
        public string Titulo { get; set; } = string.Empty;

        [Column("responsavel")]
        public string Responsavel { get; set; } = string.Empty;

        [Column("status")]
        public string Status { get; set; } = string.Empty;

        [Column("prazo_final_entrega")]
        public string PrazoFinalEntrega { get; set; }

        [Column("datahora_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("datahora_ultima_alteracao")]
        public DateTime DataUltimaAlteracao { get; set; }
    }
}