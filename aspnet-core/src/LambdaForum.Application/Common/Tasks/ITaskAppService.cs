using Abp.Application.Services;
using LambdaForum.Common.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using  Task = LambdaForum.Common.Models.Task;

namespace LambdaForum.Common.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        Task<List<TaskListDto>> GetAll(GetAllTasksInput input);
        Task GetTaskById(int id);
        System.Threading.Tasks.Task Create(CreateTaskDto input);


    }
}
