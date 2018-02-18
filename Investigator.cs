namespace CthulhuLab{
    class Investigator{
        public readonly int Sanity;
        public readonly int Stamina;
        public readonly int Focus;
        public readonly string Name;

        public Investigator(string Name,int Sanity, int Stamina, int Focus)
        {
            this.Name = Name;
            this.Sanity = Sanity;
            this.Stamina = Stamina;
            this.Focus = Focus;
        }

        public override string ToString() => string.Format("{0} - Sanity:{1} Stamina:{2} Focus:{3}", Name, Sanity, Stamina, Focus);
    }
    interface IInvestigatorBuilderWithName{
        IInvestigatorBuilderWithStamina WithName(string Name);
    }

    interface IInvestigatorBuilderWithStamina{
        IInvestigatorBuilderWithSanity WithStamina(int Stamina);
    }

    interface IInvestigatorBuilderWithSanity{
        IInvestigatorBuilderWithFocus WithSanity(int Sanity);
    }

    interface IInvestigatorBuilderWithFocus{
        IInvestigatorBuilder WithFocus(int Focus);
    }
    interface IInvestigatorBuilder{
        Investigator build();
    }
    class InvestigatorBuilder : IInvestigatorBuilderWithName,IInvestigatorBuilderWithStamina,IInvestigatorBuilderWithSanity,IInvestigatorBuilderWithFocus,IInvestigatorBuilder
    {
        private string Name;
        private  int Sanity;
        private int Stamina;
        private int Focus;

        private InvestigatorBuilder(){}
        public static IInvestigatorBuilderWithName CreateInvestigator(){
            return new InvestigatorBuilder();
        }

        public IInvestigatorBuilderWithStamina WithName(string Name){
            this.Name = Name;
            return this;
        }

         public IInvestigatorBuilderWithSanity WithStamina(int Stamina){
            this.Stamina = Stamina;
            return this;
        }
        public IInvestigatorBuilderWithFocus WithSanity(int Sanity){
            this.Sanity = Sanity;
            return this;
        }

        public IInvestigatorBuilder WithFocus(int Focus){
            this.Focus = Focus;
            return this;
        }

        public Investigator build()
        {
            return new Investigator(Name,Sanity,Stamina,Focus);
        }
    }
}
