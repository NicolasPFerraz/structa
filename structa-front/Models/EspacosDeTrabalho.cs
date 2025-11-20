using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;


namespace structa_front.Models
{
    [Table("espacos_de_trabalho")]
    public class EspacoDeTrabalho : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("nome_espaco")]
        public string NomeEspaco { get; set; } = string.Empty;

        [Column("descricao_espaco")]
        public string DescricaoEspaco { get; set; } = string.Empty;

        [Column("id_usuario")]
        public int? IdUsuario { get; set; }

        [Column("datahora_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("datahora_ultima_alteracao")]
        public DateTime DataUltimaAlteracao { get; set; }
    }

}