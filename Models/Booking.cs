using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace a.Models
{
    public class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ClientId { get; set; }

        public int AppointmentID { get; set; }

        public int VaccineID { get; set; }

        public Client Client { get; set; }

        public Appointment Appointment { get; set; }

        public Vaccine Vaccine { get; set; }

    }
}
