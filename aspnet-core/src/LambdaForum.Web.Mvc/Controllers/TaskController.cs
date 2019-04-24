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
        //This service is used to get data in dropdown list.
        private readonly ILookupAppService _lookupAppService;

        public TaskController(ITaskAppService taskAppService,
            ILookupAppService lookupAppService)
        {
            _taskAppService = taskAppService;
            _lookupAppService = lookupAppService;    
        }

        //Controller used to list all Tasks.
        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new GetAllTaskViewModel(output);           
            return View(model);
        }

        //Controller is used to get Tasks using ID
        public IActionResult TaskDetail(int id)
        {
            var output = _taskAppService.GetTaskById(id);
            var model = new GetTaskByIdModel(output);
            return View(model);
        }

        //Controller is used to create new Tasks . 
        //Also called through JQuerry
        public async Task<ActionResult> Create()
        {
            var peopleSelectListItems = (await _lookupAppService.GetPeopleComboboxItems())
                 .Select(p => p.ToSelectListItem())
                 .ToList();

            peopleSelectListItems.Insert(0, new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = string.Empty, Text = L("unassigned"), Selected = true });

            return View(new CreateTaskViewModel(peopleSelectListItems));

        }

        public async Task<ActionResult> CreateTaskModal()
        {
            var peopleSelectListItems = (await _lookupAppService.GetPeopleComboboxItems())
                 .Select(p => p.ToSelectListItem())
                 .ToList();

          peopleSelectListItems.Insert(0, new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Value = string.Empty, Text = L("unassigned"), Selected = true });
            return View("_TaskCreateModal", new CreateTaskViewModel(peopleSelectListItems));
        }

        //Controller is used to get data on the update form. 
        //Call through JQuerry.
        public IActionResult EditTaskModal(int userId)
        {
            var user = _taskAppService.GetTaskById(userId);
            var model = new EditTaskViewModel(user);
            return View("_TaskEditModal",model);

        }
    }
}