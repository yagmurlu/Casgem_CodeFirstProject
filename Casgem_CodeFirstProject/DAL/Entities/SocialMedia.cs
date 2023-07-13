﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string SocialMediaName { get;set; }
        public string SocialMediaURL { get;set; }
        public int GuideId { get; set; }
        public virtual Guide Guide { get; set; }
    }  
}