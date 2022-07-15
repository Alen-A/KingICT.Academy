using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingICT.Academy.Infrastructure
{
    public abstract class ValueObjectBase
    {
        private List<string> _brokenRules = new List<string>();

        protected List<string> BrokenRules
        {
            get
            {
                if (_brokenRules == null)
                {
                    _brokenRules = new List<string>();
                }

                return _brokenRules;
            }
        }

        protected abstract void Validate();

        public string GetBrokenRulesAsString()
        {
            StringBuilder issues = new StringBuilder();

            Validate();

            if (BrokenRules != null && BrokenRules.Count > 0)
            {
                foreach (var rule in BrokenRules)
                {
                    issues.AppendLine(rule);
                    issues.AppendLine(", ");
                }
            }

            return issues.ToString();
        }

        public void ThrowExceptionIfInvalid()
        {
            string issues = GetBrokenRulesAsString();

            if (!string.IsNullOrWhiteSpace(issues))
            {
                throw new EntityException(issues, BrokenRules);
            }

        }

        protected void AddBrokenRule(string rule)
        {
            BrokenRules.Add(rule);
        }

        public List<string> GetBrokenRules()
        {
            BrokenRules.Clear();

            Validate();

            return BrokenRules;
        }
    }
}
