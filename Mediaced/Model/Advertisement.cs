using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediaced.Model
{
    public class Advertisement
    {
        public int id { get; set;}
        public String name { get; set; }
        public String phonenumber { get; set; }
        public float salaryusd { get; set; }
        public float course { get; set; }
        public float salarybyn { get; set; }


        public Advertisement(int id, String name, String phonenumber, float salaryusd, float course, float salarbyn)
        {
            this.id = id;
            this.name = name;
            this.phonenumber = phonenumber;
            this.salaryusd = salaryusd;
            this.course = course;
            this.salarybyn = salarbyn;


                }


        public Advertisement()
        {
            this.id = 0;
            this.name = "";
            this.phonenumber = "";
            this.salaryusd =0.0f;
            this.course = 0.0f;
            this.salarybyn = 0.0f;


        }

    }
}
