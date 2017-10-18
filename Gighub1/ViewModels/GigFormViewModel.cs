using Gighub1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gighub1.ViewModels
{
    public class GigFormViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public string Heading { get; set; }

        public string Action
        {
            get
            {
                return (Id != 0) ? "Update" : "Create";
            }
        }

        public DateTime DateTime => DateTime.Parse($"{Date} {Time}");
    }
}