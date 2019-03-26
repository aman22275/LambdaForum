using LambdaForum.Common.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = LambdaForum.Common.Models.Task;

namespace LambdaForum.Web.Models.Tasks
{
    public class EditTaskViewModel
    {
        public Task Tasks { get; set; }
        public EditTaskViewModel(Task tasks)
        {
            Tasks = tasks;
        }
    }
}
