namespace Example1
{
    public class Animale : IAnimale
    {
        protected string name;
        private DateTime dataDiNascita;
        public string Habitat { get; set; }

        protected double velocitaAttuale = 0;

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = (int)((DateTime.Now - dataDiNascita).TotalDays / 365);
            }
        }

        public string GetName()
        {
            return name;
        }

        public double GetVelocitaAttuale()
        {
            return velocitaAttuale;
        }

        public string GetPippo()
        {
            throw new NotImplementedException();
        }

        public Animale()
        {
        }

        public Animale(string name, DateTime dataDiNascita)
        {
            this.name = name;
            this.dataDiNascita = dataDiNascita;
        }
    }
}
