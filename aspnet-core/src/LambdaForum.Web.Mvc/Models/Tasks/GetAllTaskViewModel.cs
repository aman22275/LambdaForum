using LambdaForum.Common.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaForum.Web.Models.Tasks
{
    public class GetAllTaskViewModel
    {
        private Task<List<TaskListDto>> output;

        public IReadOnlyList<TaskListDto> Tasks { get; set; }

        public GetAllTaskViewModel(IReadOnlyList<TaskListDto> tasks)
        {
            Tasks = tasks;
        }

        public GetAllTaskViewModel(Task<List<TaskListDto>> output)
        {
            this.output = output;
        }
    }
}
