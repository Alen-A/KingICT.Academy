using KingICT.Academy.Infrastructure;

namespace KingICT.Academy.Client.Model
{
    public class ClientRoot : EntityBase<int>, IAggregateRoot
    {

        #region Properties

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public ClientOrganization Organization { get; private set; }

        #endregion

        #region Constructors

        public ClientRoot
            (
                int id, 
                string firstName, 
                string lastName,
                ClientOrganization organization
            )
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Organization = organization;

            this.ThrowExceptionIfInvalid();
        }

        #endregion

        #region Public Methods

        public void SetClientOrganization(ClientOrganization clientOrganization)
        {
            Organization = clientOrganization;
        }

        #endregion

        #region Protected Methods

        protected override void Validate()
        {
            if (this.Id == default(int))
            {
                this.BrokenRules.Add("Id je obavezan!");
            }

            if (string.IsNullOrWhiteSpace(this.FirstName))
            {
                this.BrokenRules.Add("Ime je obavezno!");
            }

            if (string.IsNullOrWhiteSpace(this.LastName))
            {
                this.BrokenRules.Add("Prezime je obavezno!");
            }

            if (Organization != null)
            {
                this.BrokenRules.AddRange(this.Organization.GetBrokenRules());
            }
            else
            {
                this.BrokenRules.Add("Klijent mora pripadati nekoj organizaciji");
            }
        }

        #endregion
    }
}