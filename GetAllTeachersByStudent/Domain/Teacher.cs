using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllTeachersByStudent.Domain
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? SubjectId { get; set; }
        public int? GenderId { get; set; }
        public List<Pupil>? Pupils { get; set; }
    }
}
