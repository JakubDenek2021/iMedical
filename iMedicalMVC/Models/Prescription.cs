//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iMedicalMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prescription
    {
        public int ID_Prescription { get; set; }
        public Nullable<int> ID_Visit { get; set; }
        public Nullable<int> ID_Patient { get; set; }
        public string NumberPrescription { get; set; }
        public string Medication_1 { get; set; }
        public string Medication_2 { get; set; }
        public string Medication_3 { get; set; }
        public string Medication_4 { get; set; }
        public string Medication_5 { get; set; }
        public string Medication_6 { get; set; }
        public string Medication_7 { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<int> PrescriptionCode { get; set; }
        public string Dose_1 { get; set; }
        public string Dose_2 { get; set; }
        public string Dose_3 { get; set; }
        public string Dose_4 { get; set; }
        public string Dose_5 { get; set; }
        public string Dose_6 { get; set; }
        public string Dose_7 { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
