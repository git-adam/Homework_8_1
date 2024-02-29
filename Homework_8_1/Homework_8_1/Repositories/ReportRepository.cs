using Homework_8_1.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_1.Repositories
{
    public class ReportRepository
    {
        public Report GetLastNotSentReport()
        {
            //pobieranie z bazy danych ostatniego raportu

            return new Report()
            {
                Id = 1,
                Title = "",
                Date = new DateTime(2022, 1, 1, 12, 0, 0),
                Positions = new List<ReportPosition>()
                {
                    new ReportPosition()
                    {
                        Id = 1,
                        ReportId = 1,
                        Title = "Position 1",
                        Description = "Description 1",
                        Value = 43.01M
                    },
                    new ReportPosition()
                    {
                        Id = 2,
                        ReportId = 1,
                        Title = "Position 2",
                        Description = "Description 2",
                        Value = 143.01M
                    },
                    new ReportPosition()
                    {
                        Id = 3,
                        ReportId = 1,
                        Title = "Position 3",
                        Description = "Description 4",
                        Value = 454.01M
                    }

                }
            };
        }

        public void ReportSent(Report report)
        {
            report.IsSend = true;

            //zapis w bazie danych
        }
    }
}
