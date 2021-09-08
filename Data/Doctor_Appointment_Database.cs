using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Doctor_Appointment_WebAPI_Xamarin_Backend.Models;

namespace Doctor_Appointment_WebAPI_Xamarin_Backend.Data
{
    public class Doctor_Appointment_Database : DbContext
    {
        public Doctor_Appointment_Database (DbContextOptions<Doctor_Appointment_Database> options)
            : base(options)
        {
        }

        public DbSet<Doctor_Appointment_WebAPI_Xamarin_Backend.Models.Doctor_Details> Doctor_Details { get; set; }

        public DbSet<Doctor_Appointment_WebAPI_Xamarin_Backend.Models.Patient_Details> Patient_Details { get; set; }

        public DbSet<Doctor_Appointment_WebAPI_Xamarin_Backend.Models.Appointment_Details> Appointment_Details { get; set; }
    }
}
