﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Refazer.WebAPI.Models
{
    /// <summary>
    /// THis class represents the input json for the controller api/Refazer/Start
    /// </summary>
    public class StartInput
    {
        //list of submisssions 
        public IEnumerable<Submission> Submissions { set; get; }

        //question id
        public int QuestionId { set; get; }
    }
}