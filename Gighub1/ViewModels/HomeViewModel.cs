using System.Collections.Generic;
using Gighub1.Models;

namespace Gighub1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
    }
}