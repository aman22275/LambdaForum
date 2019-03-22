using LambdaForum.Common.Models;
using LambdaForum.Common.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = LambdaForum.Common.Models.Task;
namespace LambdaForum.Web.Models.Tasks
{
    public class GetTaskByIdModel
    {
        public Task Tasks { get; set;  }
        public GetTaskByIdModel(Task tasks)
        {
            Tasks = tasks;
        }

        public string GetTaskLabel(TaskListDto task)
        {
            switch (task.State)
            {
                case TaskState.Open:
                    return "label-success";
                default:
                    return "label-default";
            }
        }
    }
}
