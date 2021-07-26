using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleAppTests
{
    public static class InssConfigFactory
    {
        public static InssConfig Config()
        {
            return new InssConfig()
            {
                Years = new List<InssYear>()
                {
                    new InssYear()
                    {
                        Year = 2011,
                        Celling = 405.85m,
                        Aliquots = new List<Aliquot>()
                        {
                            new Aliquot()
                            {
                                MinWage = 0,
                                MaxWage = 1106.90m,
                                Value = 8.00m
                            },
                            new Aliquot()
                            {
                                MinWage = 1106.90m,
                                MaxWage = 1844.83m,
                                Value = 9.00m
                            },
                            new Aliquot()
                            {
                                MinWage = 1844.84m,
                                MaxWage = 3689.66m,
                                Value = 11.00m
                            }
                        }
                    },
                    new InssYear()
                    {
                        Year = 2012,
                        Celling = 500m,
                        Aliquots = new List<Aliquot>()
                        {
                            new Aliquot()
                            {
                                MinWage = 0,
                                MaxWage = 1000.00m,
                                Value = 7.00m
                            },
                            new Aliquot()
                            {
                                MinWage = 1000.01m,
                                MaxWage = 1500.00m,
                                Value = 8.00m
                            },
                            new Aliquot()
                            {
                                MinWage = 1500.01m,
                                MaxWage = 3000.00m,
                                Value = 9.00m
                            },
                            new Aliquot()
                            {
                                MinWage = 3000.01m,
                                MaxWage = 4000.00m,
                                Value = 11.00m
                            }
                        }
                    }
                }
            };
        }
    }
}
