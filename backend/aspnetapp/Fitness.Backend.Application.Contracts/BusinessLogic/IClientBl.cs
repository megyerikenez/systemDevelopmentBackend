﻿using Fitness.Backend.Application.DataContracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Backend.Application.Contracts.BusinessLogic
{
    public interface IClientBl
    {
        Task<IEnumerable<Lesson>> GetLessonListByInstructorAsync(string instructorId);

    }
}
