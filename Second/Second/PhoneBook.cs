namespace Second
{
    class Contact
    {
        private string fullName;
        private string personalPN;
        private string mobilePN;
        private string about;

        public void Deconstruct(out string fullName,
            out string personalPN,
            out string mobilePN,out string about)
        {
            fullName = this.FullName;
            personalPN = this.PersonalPN;
            mobilePN = this.MobilePN;
            about = this.About;
        }

        public Contact(string fullName, 
            string personalPN, string about)
        {
            FullName = fullName;
            PersonalPN = personalPN;
            About = about;
        }

        public Contact(string fullName,
            string personalPN,
            string mobilePN, string about)
        {
            FullName = fullName;
            PersonalPN = personalPN;
            MobilePN = mobilePN;
            About = about;
        }

        public string FullName { get => fullName; set => fullName = value; } 

        public string PersonalPN { get => personalPN; set => personalPN = value; }

        public string MobilePN { get => mobilePN; set => mobilePN = value; }

        public string About { get => about; set => about = value; }

    }
}
