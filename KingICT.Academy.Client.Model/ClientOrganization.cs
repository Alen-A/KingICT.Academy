using KingICT.Academy.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingICT.Academy.Client.Model
{
    public class ClientOrganization : ValueObjectBase
    {
        #region Properties

        public string Caption { get; private set; }
        public string Address { get; private set; }

        #endregion

        #region Protected Methods
        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Caption))
            {
                this.BrokenRules.Add("Naziv organizacije je obavezan!");
            }

            if (string.IsNullOrWhiteSpace(this.Address))
            {
                this.BrokenRules.Add("Adresa organizacije je obavezna");
            }
        }

        #endregion
    }
}
