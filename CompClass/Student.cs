using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    public class Student : Component
    {
        public Student(string name, double grade) : base(name, grade)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override double GetGradeAndAverage(string space)
        {
            Console.WriteLine(space + this.name + " " + this.GradeOrAverage);
            return this.GradeOrAverage;
        }

        public override void AddChildRangle(List<Component> c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }
    }
}
