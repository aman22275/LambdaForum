using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaForum.Common.Tasks;
using LambdaForum.Common.Tasks.Dto;
using LambdaForum.Controllers;
using LambdaForum.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForum.Web.Mvc.Controllers
{
    public class TaskController : LambdaForumControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TaskController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new GetAllTaskViewModel(output);

            return View(model);
        }

        public IActionResult TaskDetail(int id)
        {
            var output = _taskAppService.GetTaskById(id);
            var model = new GetTaskByIdModel(output);
            return View(model);
        }
    }
}