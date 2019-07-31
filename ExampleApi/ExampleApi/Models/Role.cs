using System;
using System.Collections.Generic;

namespace ExampleApi.Models
{
    public partial class Role
    {
        public Role()
        {
            User = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? Active { get; set; }
        public byte[] RowVersion { get; set; }

        public ICollection<User> User { get; set; }
    }
}
