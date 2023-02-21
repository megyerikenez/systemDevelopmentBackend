using Fitness.Backend.Application.Contracts.BusinessLogic;
using Fitness.Backend.Application.Contracts.Repositories;
using Fitness.Backend.Application.DataContracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Backend.Application.BusinessLogic
{
    public class ClientBl : IClientBl
    {
        private readonly ILessonRepository lessonRepository;

        public ClientBl(ILessonRepository lessonRepository)
        {
            this.lessonRepository = lessonRepository;
        }

        public async Task<IEnumerable<Lesson>> GetLessonListByInstructorAsync(string instructorId)
        {
            return await lessonRepository.GetLessonListByInstructorAsync(instructorId);
        }
    }
}
