using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==2001 && gamer.Id==13 && gamer.IdentityNumber==12345 && gamer.FirstName=="Ömer" && gamer.LastName=="Didin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
