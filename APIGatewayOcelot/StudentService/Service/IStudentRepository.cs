using StudentService.Model;

namespace StudentService.Service
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student Get(int id);
    }
}
