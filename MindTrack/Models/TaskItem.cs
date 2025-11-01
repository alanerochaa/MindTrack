using MindTrack.Models.Enums;
// 👇 Corrigido: cria o alias certo
using TaskStatusEnum = MindTrack.Models.Enums.TaskStatus;

namespace MindTrack.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Priority Prioridade { get; set; } = Priority.Media;
        public TaskStatusEnum Status { get; set; } = TaskStatusEnum.Pendente;
        public int? UsuarioId { get; set; }
    }
}
