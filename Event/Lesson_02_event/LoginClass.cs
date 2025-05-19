using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02_event
{
    class LoginClass
    {
        // my data base
        string email = "yusif@gmail.com", pass = "1234";
        
        // success event
        public event EmailIsloggedInEventHandler EmailIsloggedIn;
        public delegate void EmailIsloggedInEventHandler(string email, string pass);

        // wrong pass event
        public event wrongPassEventHandler WrongPass;
        public delegate void wrongPassEventHandler(string email);        

        // wrong pass event
        public event EmailNotFoundEventHandler EmailNotFound;
        public delegate void EmailNotFoundEventHandler();

        public bool loginProcess(string _email, string _pass)
        {
            // success
            if (_email == email && _pass == pass)
            {
                if(EmailIsloggedIn != null) EmailIsloggedIn(_email, _pass);
                return true;
            }
            // wrong pass
            else if (email == _email)
            {
                // event
                if (WrongPass != null) WrongPass(_email);

                return false;
            }
            // wrong email
            else
            {
                // event
                if (EmailNotFound != null) EmailNotFound();

                return false;
            }
        }
    }
}
