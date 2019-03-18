using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaForum.Common.Models
{
    public class Forum : Entity, IHasCreationTime
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationTime { get; set; }

        //Collection Of Posts on forum
        public virtual IEnumerable<Post> Posts { get; set; }
        public Forum()
        {
            CreationTime = DateTime.Now;
        }
    }
}
