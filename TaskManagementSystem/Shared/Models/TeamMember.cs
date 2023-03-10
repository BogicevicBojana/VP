using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PersonalNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateEmployed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public int CompletedTasks { get; set; }
        public int NotCompletedTasks { get; set; }
        public double HoursSpent { get; set; }

        public override string ToString() {
            return $"{FirstName} {LastName}";
        }
    }
}
