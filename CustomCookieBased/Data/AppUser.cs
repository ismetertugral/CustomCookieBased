﻿namespace CustomCookieBased.Data
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<AppUserRole> UserRoles { get; set; }
    }

    public class AppRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<AppUserRole> UserRoles { get; set; }
    }

    public class AppUserRole
    {
        public int UserId { get; set; }

        public AppUser AppUser { get; set; }
        public int RoleId { get; set; }
        public AppRole AppRole { get; set; }
    }
}
