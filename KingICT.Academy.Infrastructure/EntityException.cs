using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingICT.Academy.Infrastructure
{
    public class EntityException : Exception
    {
        public List<string> BrokenRules { get; private set; }

        public EntityException(string message)
            : base(message)
        {

        }

        public EntityException(string message, List<string> brokenRules)
            : base(message)
        {
            this.BrokenRules = brokenRules;
        }
    }
}
