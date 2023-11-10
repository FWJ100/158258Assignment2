// UniversityCampus.cs
using System.Collections.Generic;

public class UniversityCampus
{
    public int ID { get; set; }
    public string Name { get; set; }

    public ICollection<Student> Students { get; set; } // 导航属性
}