// Student.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Student
{

    public int ID { get; set; }

    [Display(Name = "User")]
    public string Name { get; set; }

    [Display(Name = "Number")]
    public string Address { get; set; }
    public int CampusID { get; set; } // 外键
    public UniversityCampus Campus { get; set; } // 导航属性
}

