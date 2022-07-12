using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllTeachersByStudent.Domain
{
    internal class Pupil
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? Class { get; set; }
        public int? GenderId { get; set; }
        public List<Teacher>? Teachers { get; set; }

    }
}
