﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WebpagesOauthMembership
    {
        public string Provider { get; set; } = null!;
        public string ProviderUserId { get; set; } = null!;
        public int UserId { get; set; }
    }
}
