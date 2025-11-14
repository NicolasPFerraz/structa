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
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("data_nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Column("localizacao")]
        public string Localizacao { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("link_rede_social")]
        public string LinkRedeSocial { get; set; }

        [Column("fuso_horario")]
        public string FusoHorario { get; set; }

        [Column("capacidade_horas_semanal")]
        public int? CapacidadeHorasSemanal { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("datahora_criacao")]
        public DateTime DataCriacao { get; set; }

        [Column("datahora_ultima_alteracao")]
        public DateTime DataUltimaAlteracao { get; set; }
    }
}