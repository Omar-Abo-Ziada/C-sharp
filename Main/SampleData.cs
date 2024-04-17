using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkDay_1
{
   public static class SampleData
    {

        public static Department[] Depart =
        {
            new Department{Name="CS",Address="Assit"},
            new Department{Name="IS",Address="Cairo"},
            new Department{Name="MM",Address="Alex"},
            new Department{Name="IT",Address="Assit"},
            new Department{Name="BIO",Address="Mansoura"},
            new Department{Name="Soft",Address="Cairo"}
        };

        public static Course[] Courses =
        {
            new Course{Name="c++",Hours=3},
            new Course{Name="Python",Hours=2},
            new Course{Name="PM",Hours=3},
            new Course{Name="Data Mining",Hours=4},
            new Course{Name="DataBase",Hours=3},
            new Course{Name="Java",Hours=2},
            new Course{Name="OOP",Hours=6},

        };

        public static Student[] Students =
            {
            new Student{Id=1,Name="Abdallah",Course=Courses[0],Dep=Depart[0]},
            new Student{Id=2,Name="Mohamed",Course=Courses[1],Dep=Depart[1]},
            new Student{Id=3,Name="Maha",Course=Courses[2],Dep=Depart[2]},
            new Student{Id=4,Name="Ali",Course=Courses[0],Dep=Depart[3]},
            new Student{Id=5,Name="Rania",Course=Courses[4],Dep=Depart[1]},
            new Student{Id=6,Name="Shimaa",Course=Courses[1],Dep=Depart[2]},
            new Student{Id=7,Name="Samir",Course=Courses[0],Dep=Depart[4]},

        };




    }
}
