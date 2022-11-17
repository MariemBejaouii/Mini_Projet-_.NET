using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger


    {
        public int PassengerId { get; set; }

        [Display(Name = "DateOfBirth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        [DataType(DataType.EmailAddress)]
        public String? EmailAdresse { get; set; }

        [Key]
        [StringLength(7)]
        public string? PassportNumber { get; set; }

        public FullName? FullName { get; set;}

        public virtual ICollection<Ticket>? Tickets { get; set; }



        [RegularExpression(@"^[0-9]{8}$")]
        public String? TelNumber { get; set; }

        public virtual ICollection<Passenger>? PassengerList { get; set; }

        public List<Flight>? Flights { get; set; }

        public override string ToString()

        {
            return "First Name : " + FullName.FirstName + "  Last Name : " + FullName.LastName + "  Email Adresse : " + EmailAdresse;

        }
      /*  public bool CheckProfile(string firstname, string lastname)
        {
            return FirstName == firstname && LastName == lastname ;
        }
        public bool CheckProfile(string firstname , string lastname , string emailadresse)
        {
            return FirstName == firstname && LastName == lastname && EmailAdresse== emailadresse;
        }
      */
     /*   public bool CheckProfile(string firstname, string lastname, string emailadresse=null)

            
        {

            if (emailadresse != null)
                return FirstName == firstname && LastName == lastname && EmailAdresse == emailadresse;

            else

                return FirstName == firstname && LastName == lastname;
        }
     */
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");  
        }


    }

   
}
