namespace ihcux_racha_ai_blazor.Models
{
    public class Grupo
    {
        public string Nome { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;

        public decimal Valor { get; set; }

        public bool UsuarioDeve { get; set; }
    }
}