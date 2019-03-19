using Abp.Application.Services;
using LambdaForum.Common.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LambdaForum.Common.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        Task<List<TaskListDto>> GetAll(GetAllTasksInput input);


    }
}
