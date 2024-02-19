using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_odev3_oyun
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1985 && gamer.FirstName=="ENGİN"
                &&gamer.LastName=="DEMİROĞ"&&gamer.Id==12562)
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
