using LambdaForum.Common.Tasks.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaForum.Web.Models.Tasks
{
    public class GetAllTaskViewModel
    {

        public IReadOnlyList<TaskListDto> Tasks { get; set; }

        public GetAllTaskViewModel(IReadOnlyList<TaskListDto> tasks)
        {
            Tasks = tasks;
        }
    }
}
