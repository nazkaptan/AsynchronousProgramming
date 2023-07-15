﻿using AsynchronousProgramming.Models.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsynchronousProgramming.Models.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public decimal UnitPrice { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile UploadImage { get; set; }


        //FK for Category
        public int CategoryId { get; set; }

        //Nav. props
        public virtual Category Category { get; set; }
    }
}
