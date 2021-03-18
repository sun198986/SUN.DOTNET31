using System;
using System.Collections.Generic;
using System.Text;

namespace System.Model
{
    public class UserDto
    {
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime CreateDate { get; set; }

        public string Creator { get; set; }

        public DateTime UpdateDate { get; set; }

        public string Updator { get; set; }
    }
}
