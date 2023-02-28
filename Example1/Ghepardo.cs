namespace Example1
{
    internal class Ghepardo : Mammifero
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

        public Ghepardo(string nome)
        {
            name = nome;
        }

        public override void Cammina()
        {
            velocitaAttuale += 55;
        }
    }
}
