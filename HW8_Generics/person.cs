using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_Generics
{
    class person: IComparable
    {
        public string name { get; set; }
        public string sname { get; set; }
        public int age { get; set; }

        public person(): this("noname","no surename"){ }
        public person(string name,string sureName,int age=0) {
            this.name = name; this.sname = sureName;this.age = age;
        }

        public int CompareTo(object obj)
        {
            if (obj is person)
            {
                //return this.age.CompareTo(((person)(obj)).age);
                return this.age.CompareTo((obj as person).age);
            }
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Name:{name} SureName:{sname} Age:{age}";
        }
    }
}
