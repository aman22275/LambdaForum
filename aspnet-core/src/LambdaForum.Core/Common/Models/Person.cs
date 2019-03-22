using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LambdaForum.Common.Models
{
    //This class is to add Person functionality to the Task Services.
    //AuditedEntity (which has CreationTime, CreaterUserId, LastModificationTime and LastModifierUserId properties)
    public class Person : AuditedEntity<Guid>
    {
        [Required]
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

    }
}
