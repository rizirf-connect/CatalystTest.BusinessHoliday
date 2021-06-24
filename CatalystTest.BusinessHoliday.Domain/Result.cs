using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain
{
    public class Result
    {
        private readonly List<string> _errors;
        public List<string> Errors => _errors;
        public bool HasErrors => _errors.Count > 0;

        public Result() =>
            _errors = new List<string>();

        public void AddError(string error) =>
            _errors.Add(error);

        public void AddErrors(IEnumerable<string> errors) =>
            _errors.AddRange(errors);
    }
}
