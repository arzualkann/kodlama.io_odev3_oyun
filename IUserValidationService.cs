using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_odev3_oyun
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
