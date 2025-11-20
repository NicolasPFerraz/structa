using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace structa_front.Models
{

    [Table("usuarios")]
    public class Usuario : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("senha")]
        public string Senha { get; set; } = string.Empty;

        [Column("data_nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Column("localizacao")]
        public string Localizacao { get; set; } = string.Empty;

        [Column("telefone")]
        public string Telefone { get; set; } = string.Empty;

        [Column("link_rede_social")]
        public string LinkRedeSocial { get; set; } = string.Empty;

        [Column("fuso_horario")]
        public string FusoHorario { get; set; } = string.Empty;

        [Column("capacidade_horas_semanal")]
        public int? CapacidadeHorasSemanal { get; set; }

        [Column("status")]
        public string Status { get; set; } = string.Empty;

        [Column("datahora_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("datahora_ultima_alteracao")]
        public DateTime DataUltimaAlteracao { get; set; }
    }
}