using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_LAB5.Domain
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Group {  get; set; } = string.Empty;
        public string Speciality { get; set; } = String.Empty;
    }
}
