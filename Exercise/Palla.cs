namespace Exercise
{
    internal class Palla
    {
        string materiale;
        int diametro;

        double[] coordinate = new double[2];

        public Palla(string _materiale = "", int _diametro = 0)
        {
            materiale = _materiale;
            diametro = _diametro;

            coordinate = new double[2] { 5, 10 };
        }

        public double[] GetCoordinate()
        {
            return coordinate;
        }

        public void Rotola(double forza)
        {
            int pippo;

            coordinate[0] += forza * 0.50;
            coordinate[1] += forza * 0.50;
        }

    }
}
