using System.Security.Cryptography.X509Certificates;

namespace UserMangement.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { set; get; }
        public DateTime CreatedAt { set; get; }
        public List<Department> Departments { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public int SessionId { get; set; }
        //public Session Session{ get; set; }
    }

    public class SessionPostDto
    {
        public string Name { get; set; }
    }
    public class DepartmentPostDto
    {
        public string Name { get; set; }
        public int SessionId { set; get; }
    }
    public class SessionRequestDto
    {
        public string Name { get; set; }
        public List<DepartmentRequestDto> Departments { set; get; }
    }
    public class DepartmentRequestDto
    {
        public string Name { get; set; }
    }

    public class SessionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<DepartmentDto> Departments { get; set; }
    }

    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SessionId { get; set; }
    }
}

