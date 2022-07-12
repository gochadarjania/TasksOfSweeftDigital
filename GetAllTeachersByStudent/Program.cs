// See https://aka.ms/new-console-template for more information
using GetAllTeachersByStudent.Data;
using GetAllTeachersByStudent.Domain;


foreach (var item in GetAllTeachersByStudent("გიორგი"))
{
    Console.WriteLine(item.Name);
}


List<Teacher> GetAllTeachersByStudent(string studentName)
{
    SchoolDbContext _db = new SchoolDbContext();

    return (from t in _db.Teachers
            where t.Pupils.Any(p => p.Name == studentName)
            select t).ToList();
};