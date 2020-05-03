﻿using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace STOnline.DAL.Models
{
    public class Order : BaseEntity
    {
        [NotMapped]
        public Client Client { get; set; }
        public int ClientId { get; set; }
        [NotMapped]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string ModelAuto { get; set; }
        public string AutoNumber { get; set; }
        public DateTime Data { get; set; }
        [ForeignKey("OrderId")]
        [NotMapped]
        public ICollection<Repair> Repairs { get; set; }

    }
}
