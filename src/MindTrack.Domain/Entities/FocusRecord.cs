namespace MindTrack.Models
{
    public class FocusRecord
    {
        public int Id { get; set; }
        public DateTime Inicio { get; set; } = DateTime.Now;
        public DateTime Fim { get; set; } = DateTime.Now.AddMinutes(25);
        public string Humor { get; set; } = "Neutro";

        public int? UsuarioId { get; set; }
        public int DuracaoMinutos => (int)(Fim - Inicio).TotalMinutes;
    }
}
