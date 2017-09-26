using System.Collections.Generic;
using Gighub1.Models;

namespace Gighub1.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public int Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public  IEnumerable<Genre> Genres { get; set; }
    }
}