using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllTeachersByStudent.Domain
{
    internal class Gender
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Pupil>? Pupils { get; set; }
        public List<Teacher>? Teachers { get; set; }
    }
}
