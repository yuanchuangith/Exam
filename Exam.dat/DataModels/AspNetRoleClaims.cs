﻿
using System.ComponentModel.DataAnnotations;

namespace Exam.dat.DataModels
{
    public partial class AspNetRoleClaims
    {
        [Key]
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetRoles Role { get; set; }
    }
}
