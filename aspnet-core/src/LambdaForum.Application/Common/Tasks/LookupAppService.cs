using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LambdaForum.Authorization.Users;
using LambdaForum.Common.Models;
using LambdaForum.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaForum.Common.Tasks
{
   public class LookupAppService : ApplicationService, ILookupAppService
    {
        private readonly IRepository<User, long> _repository;       
        private readonly IRepository<Person, Guid> _personRepository;
        public LookupAppService(IRepository<Person, Guid> personRepository,
            IRepository<User, long> repository)
        {
            _personRepository = personRepository;          
            _repository = repository;
        }


        //  Get all names of person from database.
        public async Task<List<ComboboxItemDto>> GetPeopleComboboxItems()
        {
            //To get the list of users registered.
            var people = await _personRepository.GetAllListAsync();
            return new List<ComboboxItemDto>(
                people.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)).ToList()
                );
        }
    }
}
