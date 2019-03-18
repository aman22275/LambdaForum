using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaForum.Common.Models
{
    public class Post : Entity, IHasCreationTime
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }

        //Navigation Properties
        //Posted By user
        public virtual ApplicationUser User { get; set; }
        public virtual Forum Forum { get; set; }

        //To retreive the replies.
        public virtual IEnumerable<PostReply> Replies { get; set; }
        public Post()
        {
            CreationTime = DateTime.Now;
        }
    }
}
