using MindTrack.Models;
using MindTrack.Models.Enums;
using TaskStatusEnum = MindTrack.Models.Enums.TaskStatus;

namespace MindTrack.Repositories
{
    /// <summary>
    /// Repositório em memória para armazenar tarefas do sistema MindTrack.
    /// Usado apenas para simulação (sem banco de dados real).
    /// </summary>
    public class InMemoryTasksRepository : ITasksRepository
    {
        // Dados simulados (mock)
        private static readonly List<TaskItem> _data = new()
        {
            new TaskItem
            {
                Id = 1,
                Titulo = "Estudar .NET MVC",
                Descricao = "Revisar Controllers, Views, Models e TagHelpers.",
                Prioridade = Priority.Alta,
                Status = TaskStatusEnum.Pendente
            },
            new TaskItem
            {
                Id = 2,
                Titulo = "Montar README",
                Descricao = "Adicionar prints, explicações e links do projeto MindTrack (CodeGirls).",
                Prioridade = Priority.Media,
                Status = TaskStatusEnum.Concluida
            },
            new TaskItem
            {
                Id = 3,
                Titulo = "Implementar FocusController",
                Descricao = "Criar controle de sessões de foco e integrar com as Views.",
                Prioridade = Priority.Alta,
                Status = TaskStatusEnum.EmProgresso
            },
            new TaskItem
            {
                Id = 4,
                Titulo = "Ajustar layout do TaskHub",
                Descricao = "Aplicar o tema lavanda CodeGirls e padronizar botões e tabelas.",
                Prioridade = Priority.Media,
                Status = TaskStatusEnum.EmProgresso
            },
            new TaskItem
            {
                Id = 5,
                Titulo = "Criar Dockerfile",
                Descricao = "Gerar imagem Docker do MindTrack em .NET 8 com boas práticas.",
                Prioridade = Priority.Alta,
                Status = TaskStatusEnum.Pendente
            },
            new TaskItem
            {
                Id = 6,
                Titulo = "Testar API de Foco",
                Descricao = "Executar testes no Postman e validar rotas e respostas JSON.",
                Prioridade = Priority.Media,
                Status = TaskStatusEnum.EmProgresso
            },
            new TaskItem
            {
                Id = 7,
                Titulo = "Publicar no GitHub",
                Descricao = "Enviar código final, atualizar README e configurar repositório público.",
                Prioridade = Priority.Media,
                Status = TaskStatusEnum.Concluida
            },
            new TaskItem
            {
                Id = 8,
                Titulo = "Gravar vídeo de apresentação",
                Descricao = "Demonstrar o funcionamento do MindTrack e narrar as etapas do projeto.",
                Prioridade = Priority.Alta,
                Status = TaskStatusEnum.Pendente
            },
            new TaskItem
            {
                Id = 9,
                Titulo = "Adicionar validações nas Views",
                Descricao = "Garantir que campos obrigatórios estejam validados no front-end.",
                Prioridade = Priority.Media,
                Status = TaskStatusEnum.EmProgresso
            },
            new TaskItem
            {
                Id = 10,
                Titulo = "Gerar PDF de evidências",
                Descricao = "Exportar prints, comandos e links para o documento final de entrega.",
                Prioridade = Priority.Alta,
                Status = TaskStatusEnum.Pendente
            }
        };

        // Controle do ID incremental
        private static int _idSeed = _data.Max(x => x.Id);

        // Retorna todas as tarefas com filtros opcionais
        public IEnumerable<TaskItem> GetAll(string? termo, Priority? prioridade, TaskStatusEnum? status)
        {
            IEnumerable<TaskItem> query = _data;

            if (!string.IsNullOrWhiteSpace(termo))
                query = query.Where(t =>
                    t.Titulo.Contains(termo, StringComparison.OrdinalIgnoreCase) ||
                    t.Descricao.Contains(termo, StringComparison.OrdinalIgnoreCase));

            if (prioridade.HasValue)
                query = query.Where(t => t.Prioridade == prioridade.Value);

            if (status.HasValue)
                query = query.Where(t => t.Status == status.Value);

            return query.OrderByDescending(t => t.Prioridade).ThenBy(t => t.Status);
        }

        // Retorna uma tarefa pelo ID
        public TaskItem? GetById(int id) => _data.FirstOrDefault(x => x.Id == id);

        // Adiciona nova tarefa
        public void Add(TaskItem item)
        {
            item.Id = ++_idSeed;
            _data.Add(item);
        }

        // Atualiza uma tarefa existente
        public void Update(TaskItem item)
        {
            var existing = GetById(item.Id);
            if (existing == null) return;

            existing.Titulo = item.Titulo;
            existing.Descricao = item.Descricao;
            existing.Prioridade = item.Prioridade;
            existing.Status = item.Status;
        }

        // Remove uma tarefa
        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null)
                _data.Remove(existing);
        }

        // Verifica se uma tarefa existe
        public bool Exists(int id) => _data.Any(x => x.Id == id);
    }
}
