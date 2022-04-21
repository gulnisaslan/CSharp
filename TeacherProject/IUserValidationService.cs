using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
