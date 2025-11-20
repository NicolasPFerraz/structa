using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace structa_front.Models
{
    [Table("membros_espaco")]
    public class MembroEspaco : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("id_espaco_de_trabalho")]
        public int IdEspacoDeTrabalho { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("funcao")]
        public string Funcao { get; set; } = string.Empty;

        [Column("datahora_entrada")]
        public DateTime DataEntrada { get; set; }
    }
}