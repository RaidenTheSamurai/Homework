using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__4.Part_1
{
    public class Worker
    {
        public float Salary { get; set; }
        public Worker() { }
        public Worker(float salary) => this.Salary = salary;
        public static Worker operator +(Worker worker, float valueOfIncrese) { return new Worker { Salary = worker.Salary + valueOfIncrese }; }
        public static Worker operator -(Worker worker, float valueofDecrese) { return new Worker { Salary = worker.Salary - valueofDecrese }; }
        public static bool operator <(Worker worker1, Worker worker2) { return worker1.Salary < worker2.Salary; }
        public static bool operator >(Worker worker1, Worker worker2) { return worker1.Salary > worker2.Salary; }
        public static bool operator ==(Worker worker1, Worker worker2) { return worker1.Salary == worker2.Salary; }
        public static bool operator !=(Worker worker1, Worker worker2) { return worker1.Salary != worker2.Salary; }
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType != obj.GetType) return false; 
            Worker worker = (Worker)obj;
            return worker.Salary == Salary;
        }


    }
}
