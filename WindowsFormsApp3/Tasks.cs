using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Tasks : ITasks
    {
        Dictionary<IBorders, ITasks> TaskMap;
        public int TaskID { get; set; }

        public Tasks()
        {
            TaskMap = new Dictionary<IBorders, ITasks>();
        }
        public void AddTask(IBorders border,ITasks tasks)
        {
            TaskMap.Add(border, tasks);
        }

        public void RemoveTask(IBorders border, ITasks tasks)
        {
            TaskMap.Remove(border);
        }

        public void UpdateTask(IBorders border, ITasks tasks)
        {
            
        }
    }
}
