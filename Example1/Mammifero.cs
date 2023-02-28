namespace Example1
{
    public abstract class Mammifero : Animale
    {
        public abstract string Tipologia { get; set; }

        public abstract void Cammina();

        public void Nuota()
        {
            velocitaAttuale += 3;
        }
    }
}
