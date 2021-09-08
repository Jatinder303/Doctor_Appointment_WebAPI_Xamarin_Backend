using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doctor_Appointment_WebAPI_Xamarin_Backend.Models
{
    public class Patient_Details
    {
        public int Id { get; set; }
        public string Patient_Name { get; set; }
        public string Patient_Mobile { get; set; }
        public string Pateint_Email { get; set; }
        public string Patient_Address { get; set; }
    }
}
