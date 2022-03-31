using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Ngamer added");
            }
            else
            {
                Console.WriteLine("Dogrulama başarısız. Kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("gamer deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("gamer updated");

        }
    }
}
