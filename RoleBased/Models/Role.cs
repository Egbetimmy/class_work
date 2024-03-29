﻿namespace RoleBased.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }

    public class RoleDTO
    {
        public string RoleName { get; set; }
    }
}
