namespace CthulhuLab{
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
