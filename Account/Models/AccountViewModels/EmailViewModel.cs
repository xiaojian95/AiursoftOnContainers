﻿using Aiursoft.Pylon.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Account.Models.AccountViewModels
{
    public class EmailViewModel : AccountViewModel
    {
        [Obsolete(error: true, message: "This method is only for framework!")]
        public EmailViewModel() { }
        public EmailViewModel(AccountUser user) : base(user, 1, "Avatar") { }

        public IEnumerable<IUserEmail> Emails { get; set; }
        public string PrimaryEmail { get; set; }
        public void Recover(AccountUser user)
        {
            base.Recover(user, 1, "Avatar");
        }
    }
}
