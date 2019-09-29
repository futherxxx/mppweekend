using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicropensionWeekend.Models
{
    public class TempRemittanceModel
    {
        public string surname { get; set; }
        public string firstname { get; set; }
        public string othername { get; set; }
        public string pin { get; set; }
        public string nin { get; set; }
        public decimal amount { get; set; }
        public string phone { get; set; }
        public string remarks { get; set; }
        public TempRemittanceModel()
        {

        }
        public TempRemittanceModel(string _surname, string _firstname, string _othernames, string _pin, string _phone, decimal _amount, string _nin)
        {
            surname = _surname;
            firstname = _firstname;
            othername = _othernames;
            pin = _pin;
            phone = _phone;
            amount = _amount;
            nin = _nin;

        }

    }
}