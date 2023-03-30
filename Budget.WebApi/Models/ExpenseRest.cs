﻿using Budget.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Budget.Models
{
    public class ExpenseRest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PersonRest Person { get; set; }
        public CategoryRest Category { get; set; }
        //public Guid PersonId { get; set; }
        //public string PersonUsername { get; set; }
        //public Guid CategoryId { get; set; }
        //public string CategoryName { get; set; }
        public DateTime Date { get; set; }
        public Decimal Cost { get; set; }
    }
}