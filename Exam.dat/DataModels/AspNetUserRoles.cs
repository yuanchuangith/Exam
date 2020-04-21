﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam.dat.DataModels
{
    public partial class AspNetUserRoles
    {
        [Key]
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRoles Role { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
