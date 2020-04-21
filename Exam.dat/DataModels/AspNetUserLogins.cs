﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam.dat.DataModels
{
    public partial class AspNetUserLogins
    {
        [Key]
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
