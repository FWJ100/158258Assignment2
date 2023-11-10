using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static System.Web.Razor.Parser.SyntaxConstants;

public class Person
{
    public string CName { get; set; } // 角色
    public string RealName { get; set; } // 真名
    public string Gender { get; set; } // 性别
    public string ImageUrl { get; set; } // 图片的URL

    public string Else { get; set; } // 性别
}