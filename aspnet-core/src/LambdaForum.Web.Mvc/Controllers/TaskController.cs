using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using LambdaForum.Common.Tasks;
using LambdaForum.Common.Tasks.Dto;
using LambdaForum.Controllers;
using LambdaForum.Users;
using LambdaForum.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForum.Web.Mvc.Controllers
{
    public class TaskController : LambdaForumControllerBase
    {
       
        private readonly ITaskAppService _taskAppService;
        private readonly ILookupAppService _lookupAppService;

        public TaskController(ITaskAppService taskAppService,
            ILookupAppService lookupAppService)
        {
            _taskAppService = taskAppService;
            _lookupAppService = lookupAppService;
    
        }

        //Get all tasks.
        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new GetAllTaskViewModel(output);
            

            return View(model);
        }

        //Get Results By id.
        public IActionResult TaskDetail(int id)
        {
            var output = _taskAppService.GetTaskById(id);
            var model = new GetTaskByIdModel(output);
            return View(model);
        }

        //Create or assign tasks.
        public async Task<ActionResult> Create()
        {
            var peopleSelectListItems = (await _lookupAppService.GetPeopleComboboxItems())
                 .Select(p => p.ToSelectListItem())
                 .ToList();

            peopleSelectListItems.Insert(0, new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = string.Empty, Text = L("unassigned"), Selected = true });

            return View(new CreateTaskViewModel(peopleSelectListItems));


        }
    }
}