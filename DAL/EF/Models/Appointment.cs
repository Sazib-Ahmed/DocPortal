using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models
{
    public enum AppointmentStatus
    {
        Pending,
        Confirmed,
        Suggested,
        Canceled
    }

    public class Appointment
    {
        [Key] // Specify the primary key
        public int AppointmentId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string AppointmentTime { get; set; }

        public string Department { get; set; }

        public string Description { get; set; }

        public AppointmentStatus Status { get; set; }

        public string CancellationReason { get; set; }

        public bool IsPaymentConfirmed { get; set; }

        public DateTime PaymentConfirmationDate { get; set; }
        
        // Navigation properties for related entities
        public virtual Patient Patient { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
