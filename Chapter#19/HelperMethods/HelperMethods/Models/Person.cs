﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelperMethods.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public bool IsApproved { get; set; }
        public Role Role { get; set; }
    }
}