using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace structa_front.Models
{
    [Table("convites")]
    public class Convite : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("id_espaco_de_trabalho")]
        public int IdEspacoDeTrabalho { get; set; }

        [Column("email_convidado")]
        public string EmailConvidado { get; set; } = string.Empty;

        [Column("id_usuario")]
        public int? IdUsuario { get; set; }

        [Column("status")]
        public string Status { get; set; } = string.Empty;

        [Column("datahora_enviado_criacao")]
        public DateTime DataCriacao { get; set; }
    }
}