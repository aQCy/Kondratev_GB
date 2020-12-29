using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_4
{
    public class ToDo
    {
        public string Title { get; set; }

        public bool IsDone { get; set; }
        public int Index { get; set; }
        public ToDo()
        {
            Title = "0";
            IsDone = true;
            Index = 0;
        }
        public ToDo(string Title, bool IsDone, int Index)
        {
            this.Title = Title;
            this.IsDone = IsDone;
            this.Index = Index;
        }
    }
}
