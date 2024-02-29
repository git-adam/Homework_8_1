using Homework_8_1.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_1.Repositories
{
    public class ErrorRepository
    {
        public List<Error> GetLastErrors(int intervalInMinutes)
        {
            //pobieranie z bazy danych

            return new List<Error>()
            {
                new Error() {Message = "Błąd testowy 1", Date = DateTime.Now},
                new Error() {Message = "Błąd testowy 2", Date = DateTime.Now},
            };
        }
    }
}
