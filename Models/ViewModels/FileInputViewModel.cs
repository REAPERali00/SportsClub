﻿using A2.Models;
namespace A2.Models.ViewModels
{
    public class FileInputViewModel
    {
        public string SportClubId { get; set; }

        public string SportClubTitle { get; set; }
        public IFormFile File { get; set; }
    }

}
