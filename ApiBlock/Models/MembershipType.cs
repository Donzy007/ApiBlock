﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiBlock.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public string Name { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscourtRate { get; set; }
    }
}