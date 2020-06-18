﻿using dangquocbao_lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dangquocbao_lab456.Controllers
{
    [Authorize]
    public class AttendencesController : ApiController
    {
        private ApplicationDbContext _dbContext;
    }
    public IHttpActionResult Attend([FromBody] int courseId)
    {
        var attendance = new Attendance
        {
            CourseId = courseId,
            AttendeeId = User.Indentity.GetUserId()
        };
    }
}