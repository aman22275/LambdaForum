using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LambdaForum.Common.Models
{
        public class Task : Entity, IHasCreationTime
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime CreationTime { get; set; }

            public string TaskType { get; set; }
            public string DueDate { get; set; }

            public TaskState State { get; set; }

            [ForeignKey(nameof(AssignedPersonId))]
            public Person AssignedPerson { get; set; }
            public Guid? AssignedPersonId { get; set; }

            public Task(Guid? assignedPersonId = null)
            {
                AssignedPersonId = assignedPersonId;
            }
      }

      

        public enum TaskState : byte
        {
            Open = 0,
            Completed = 1
        }
   
}
