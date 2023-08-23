using BLL.DTOs;
using DAL.EF.Models;
using System;
using System.Collections.Generic;

namespace DAL.EF.DTOs
{
    public class AppointmentDTO
    {
        public int AppointmentId { get; set; }

        public int? PatientId { get; set; }

        public int? DoctorId { get; set; }

        public DateTime? AppointmentDate { get; set; }

        public string AppointmentTime { get; set; }

        public string Department { get; set; }

        public string Description { get; set; }

        public AppointmentStatus? Status { get; set; }

        public string CancellationReason { get; set; }

        public bool? IsPaymentConfirmed { get; set; }

        public DateTime? PaymentConfirmationDate { get; set; }
    }
}
