using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwritetest_001.Pages
{
    public class LoginPageUpgraded
    {
        private IPage _page;

        public LoginPageUpgraded(IPage page) => _page = page; 
        private  ILocator _lnkLogin  => _page.Locator("txt=Login");
        private  ILocator _txtUserName => _page.Locator("#UserName");   
        private  ILocator _txtPassword => _page.Locator("#Password");
        private  ILocator _btnLogin => _page.Locator("txt=Log in");
        private  ILocator _lnkEmployeeDetails => _page.Locator("text = Employee Details");   
        
         
        public async Task ClickLogin() => await _lnkLogin.ClickAsync();


        public async Task Login(String userName, String password)
        {

            await  _txtUserName.FillAsync(userName);
            await  _txtUserName.FillAsync(password);
            await  _btnLogin.ClickAsync();


        }

        public async Task <bool> IsEmployeeDetalsExist() => await _lnkEmployeeDetails.IsVisibleAsync();
    }
}
