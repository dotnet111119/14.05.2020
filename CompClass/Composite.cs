using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    /// <summary>
    /// Container which has children
    /// </summary>
    public class Composite : Component
    {

        private List<Component> childs = new List<Component>();

        public Composite(string name) : base(name, Double.NaN)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override double GetGradeAndAverage(string space)
        {
            double sum = 0.0;
            foreach (Component c in childs)
            {
                sum += c.GetGradeAndAverage(space + "    ");
            }
            double avg = childs.Count > 0 ? sum / childs.Count : 0;
            Console.WriteLine(space + this.name + " " + avg);

            this.GradeOrAverage = avg;

            return avg;
        }

        public override void AddChildRangle(List<Component> c)
        {
            this.childs.AddRange(c);
        }
    }

    public class ClassRoom : Composite {
        public ClassRoom(string name) : base(name)
        {
        }
    }

    public class Shihva : Composite
    {
        public Shihva(string name) : base(name)
        {
        }
    }

    public class School : Composite
    {
        public School(string name) : base(name)
        {
        }
    }
}
