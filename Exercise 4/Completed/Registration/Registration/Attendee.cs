using System;

namespace Registration
{
    public class Attendee : Registrant
    {
        public Attendee(string email)
        {
            Email = email;
        }

        public string Email { get; private set; }
    }
}
