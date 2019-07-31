using System;
using System.Collections.Generic;

namespace ExampleApi.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Guid RoleId { get; set; }
        public bool? Active { get; set; }
        public byte[] RowVersion { get; set; }

        public Role Role { get; set; }
    }
}
