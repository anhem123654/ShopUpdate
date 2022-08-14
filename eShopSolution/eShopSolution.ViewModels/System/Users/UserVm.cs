using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.System.Users
{
    public class UserVm
    {
        public Guid Id { get; set; }

        [Display(Name = "Tên")]
        public string FirstName { get; set; }
        [Display(Name = "Họ")]
        public string LastName { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Tài khoản")]
        public string UserName { get; set; }
        [Display(Name = "Địa chỉ email")]
        public string Email { get; set; }
        [Display(Name = "Năm sinh")]
        public DateTime Dob { get; set; }

        public IList<string> Roles { get; set; }
    }
}
