using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    class Program
    {
        static void Main(string[] args)
        {
            Component school = new School("Amit amal");
            Component shihva1 = new Shihva("Shihva yod");
            Component shihva2 = new Shihva("Shihva yod-alef");
            Component class1 = new ClassRoom("yod-1");
            Component class2 = new ClassRoom("yod-2");
            Component class3 = new ClassRoom("yod-alef-1");
            Component class4 = new ClassRoom("yod-alef-2");

            school.AddChild(shihva1);
            school.AddChild(shihva2);

            shihva1.AddChild(class1);
            shihva1.AddChild(class2);

            shihva2.AddChild(class3);
            shihva2.AddChild(class4);

            Random random = new Random();

            Student student1 = new Student("A", 51 + random.Next(50));
            Student student2 = new Student("B", 51 + random.Next(50));
            Student student3 = new Student("C", 51 + random.Next(50));
            Student student4 = new Student("D", 51 + random.Next(50));
            Student student5 = new Student("E", 51 + random.Next(50));
            Student student6 = new Student("F", 51 + random.Next(50));
            Student student7 = new Student("G", 51 + random.Next(50));
            Student student8 = new Student("H", 51 + random.Next(50));

            class1.AddChildRangle(new List<Component> { student1, student2 });
            class2.AddChildRangle(new List<Component> { student3, student4 });
            class3.AddChildRangle(new List<Component> { student5, student6 });
            class4.AddChildRangle(new List<Component> { student7, student8 });

            //school.GetGradeAndAverage("");
            shihva1.GetGradeAndAverage("");
        }
    }
}
