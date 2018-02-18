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
}
