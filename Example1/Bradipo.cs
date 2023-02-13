namespace Example1
{
    internal class Bradipo : Mammifero
    {
        private string _tipologia;

        public override string Tipologia
        {
            get
            {
                return _tipologia;
            }
            set
            {
                _tipologia = value;
            }
        }

        public Bradipo(string nome)
        {
            name = nome;
        }

        public override void Cammina()
        {
            velocitaAttuale += 0.5;
        }
    }
}
