//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDM.iOS.Business.BusinessLogics.MDM_Profile.BankIslamEn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MDM_Profile
    {
        [Key]
        public Guid Profile_ID { get; set; }
        public string Profile_Name { get; set; }
        public string Profile_Desc { get; set; }
        public Nullable<int> Profile_GroupID { get; set; }
        public Nullable<int> Profile_Status { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string PlistContent { get; set; }
        public string Profile_APNS_Path { get; set; }
        public string Profile_Enroll_Path { get; set; }
    }
}
