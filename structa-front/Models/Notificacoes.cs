using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;


namespace structa_front.Models
{
    [Table("notificacoes")]
    public class Notificacao : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("tipo_notificacao")]
        public string TipoNotificacao { get; set; } = string.Empty;

        [Column("conteudo_mensagem")]
        public string ConteudoMensagem { get; set; } = string.Empty;

        [Column("foi_lida")]
        public bool FoiLida { get; set; }

        [Column("datahora_criacao")]
        public DateTime DataCriacao { get; set; }
    }
}