using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace structa_front.Models
{
    [Table("projetos")]
    public class Projeto : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("descricao_projeto")]
        public string DescricaoProjeto { get; set; } = string.Empty;

        [Column("datahora_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("datahora_ultima_atualizacao")]
        public DateTime DataUltimaAtualizacao { get; set; }

        [Column("responsavel")]
        public string Responsavel { get; set; } = string.Empty;  
    }
}
