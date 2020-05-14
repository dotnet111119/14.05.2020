using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    public abstract class Component
    {
        protected string name;

        protected double grade_or_average = double.NaN;

        public Component(string name, double grade_or_average)
        {
            this.name = name;
            this.grade_or_average = grade_or_average;
        }

        public abstract void AddChild(Component c);

        public abstract void AddChildRangle(List<Component> c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract double GetGradeAndAverage(string space);

        public string GetName()
        {
            return this.name;
        }

        public double GradeOrAverage
        {
            get
            {
                return this.grade_or_average;
            }
            set
            {
                this.grade_or_average = value;
            }
        }
    }
}
