﻿using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwritetest_001.Pages
{
    public class LoginPage
    {
        private IPage _page;
        private readonly ILocator _lnkLogin;
        private readonly ILocator _txtUserName;   
        private readonly ILocator _txtPassword;
        private readonly ILocator _btnLogin;
        private readonly ILocator _lnkEmployeeDetails;   
        
        public LoginPage(IPage page) {
            _page = page;
            _lnkLogin = _page.Locator("txt=Login");
            _txtUserName = _page.Locator("#UserName");
            _txtPassword = _page.Locator("#Password");
            _btnLogin = _page.Locator("txt=Log in");
            _lnkEmployeeDetails= _page.Locator("text = Employee Details");
        }

        public async Task ClickLogin() => await _lnkLogin.ClickAsync();


        public async Task Login(String userName, String password)
        {

            await  _txtUserName.FillAsync(userName);
            await  _txtUserName.FillAsync(password);
            await  _btnLogin.ClickAsync();


        }
    }
}
