using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_Test.Domain.Words_Contoller
{
    public class WordView
    {
        public string Word { get; set; }
        public WordStatus Status { get; set; }
    }
    public enum WordStatus{ Active, Right, Wrong }
}
