using System;

namespace CthulhuLab
{
    class ArkhamHorror
    {
        static void Main(string[] args)
        {
            Investigator hank = InvestigatorBuilder.CreateInvestigator()
                            .WithName("Hank Samson")
                            .WithStamina(6)
                            .WithSanity(5)
                            .WithFocus(2)
                            .build();
            Console.WriteLine(hank);
        }
    }
}
