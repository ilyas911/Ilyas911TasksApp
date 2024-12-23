using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilyas911TasksApp.Models
{
    public class TaskItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; } // Что нужно сделать

        public string Description { get; set; } // Описание

        public DateTime CreatedAt { get; set; } // Дата создания

        public DateTime UpdatedAt { get; set; }

        public TaskStatus Status { get; set; } // Статус задачи

        public int ParentTaskId { get; set; } // ID родительской задачи (для подзадач)
    }

    public enum TaskStatus
    {
        Created,
        InProgress,
        Completed,
        Cancelled,
        Pending
    }
}
