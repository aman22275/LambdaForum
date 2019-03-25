using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaForum.Common.Tasks.Dto
{
    public class UpdateTaskDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }

        public string TaskType { get; set; }
        public string DueDate { get; set; }
    }
}
