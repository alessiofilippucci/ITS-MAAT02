namespace Example1
{
    internal sealed class Uomo : Mammifero
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

        public Uomo(string nome)
        {
            name = nome;
        }

        public override void Cammina()
        {
            velocitaAttuale += 5;
        }
    }
}
