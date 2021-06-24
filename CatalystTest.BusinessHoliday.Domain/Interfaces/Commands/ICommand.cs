using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain.Interfaces.Commands
{
    public interface ICommand
    {
        bool IsValid();
    }
}
