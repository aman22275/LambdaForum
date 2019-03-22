using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LambdaForum.Common.Tasks
{
    //To present the data in dropdown, we ll list the user identity to represnt it on form as drop down.
    public interface ILookupAppService : IApplicationService
    {
        Task<List<ComboboxItemDto>> GetPeopleComboboxItems();
    }
}
