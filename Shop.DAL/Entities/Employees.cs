﻿

using ShopApp.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.DAL.Entities
{
    public class Employees : Person
    {
        [Key]
        public int empid { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string title { get; set; }
        public string titleofcourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }
        public int? mgrid { get; set; }
    }
}
