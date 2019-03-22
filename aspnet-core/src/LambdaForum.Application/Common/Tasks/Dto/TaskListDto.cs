using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LambdaForum.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaForum.Common.Tasks.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TaskListDto : EntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }

        public string TaskType { get; set; }
        public string DueDate { get; set; }
        public TaskState State { get; set; }
    }

    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }
}
