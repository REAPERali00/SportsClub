﻿using A2.Models;

namespace A2.Models.ViewModels
{
    public class SportClubViewModel
    {
        public IEnumerable<Fan> Fans { get; set; }
        public IEnumerable<SportClub> SportClubs { get; set; }
        public IEnumerable<Subscription> Subscription { get; set; }
    }
}
