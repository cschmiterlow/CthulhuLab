using System;
using System.Collections.Generic;

namespace CthulhuLab
{
    class ArkhamHorror
    {
        static void Main(string[] args)
        {
            List<Investigator> investigators = new List<Investigator>();
            
            // Create Object using contructor
            investigators.Add(new Investigator("Wendy Adams",
                                                4,
                                                4,
                                                3));
            
            // Create Object using Builder
            investigators.Add(InvestigatorBuilder.CreateInvestigator()
                            .WithName("Hank Samson")
                            .WithStamina(6)
                            .WithSanity(5)
                            .WithFocus(2)
                            .build());

            investigators.ForEach(i => Console.WriteLine(i));
        }
    }
}
