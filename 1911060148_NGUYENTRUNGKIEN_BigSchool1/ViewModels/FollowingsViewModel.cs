using _1911060148_NGUYENTRUNGKIEN_BigSchool1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911060148_NGUYENTRUNGKIEN_BigSchool1.ViewModels
{
    public class FollowingsViewModel
    {
        public IEnumerable<ApplicationUser> FollowingLecturers { get; set; }
        public bool ShowAction { get; set; }
    }
}