using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    internal class PieSeriesTask
    {
        
        public static PieSeriesData GetChineseCalendar(NameData[] names)
        {   
            var chineseYears = new string[] {"Год Обезьяны", "Год Петуха", "Год Собаки",
                                                        "Год Свиньи", "Год Крысы", "Год Быка", "Год Тигра",
                                                            "Год Кролика", "Год Дракона", "Год Змеи", "Год Лошади", "Год Козы", };

            var yearTypesAndCounts = new Dictionary<string, int>();


            foreach (var name in names)
            {   
                var year = name.BirthDate.Year;

                if (!yearTypesAndCounts.ContainsKey(chineseYears[year % 12]))
                    yearTypesAndCounts[chineseYears[year % 12]] = 1;
                else
                    yearTypesAndCounts[chineseYears[year % 12]] += 1;
            }

            yearTypesAndCounts = yearTypesAndCounts
                .OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return new PieSeriesData("Китайский календарь", yearTypesAndCounts);
        }
        

        
    }
}
