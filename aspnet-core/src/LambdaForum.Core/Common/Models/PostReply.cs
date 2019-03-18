using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaForum.Common.Models
{
    public class PostReply : Entity, IHasCreationTime
    {
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }

        //User Navigation Property , the user who reply.
        public virtual ApplicationUser User { get; set; }
        //Correspond to individual post.
        public virtual Post Post { get; set; }
        public PostReply()
        {
            CreationTime = DateTime.Now;
        }
    }
}
