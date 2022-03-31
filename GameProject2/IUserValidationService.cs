using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2
{
     public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
