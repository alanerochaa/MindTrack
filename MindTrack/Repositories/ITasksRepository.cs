using MindTrack.Models;
using MindTrack.Models.Enums;
// 👇 adiciona alias
using TaskStatusEnum = MindTrack.Models.Enums.TaskStatus;

namespace MindTrack.Repositories
{
    public interface ITasksRepository
    {
        IEnumerable<TaskItem> GetAll(string? termo, Priority? prioridade, TaskStatusEnum? status);
        TaskItem? GetById(int id);
        void Add(TaskItem item);
        void Update(TaskItem item);
        void Delete(int id);
        bool Exists(int id);
    }
}
