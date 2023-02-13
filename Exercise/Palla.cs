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
            double coeff = 1;

            if (materiale == "Pietra")
            {
                coeff = 0.01;
            }
            else if (materiale == "Stoffa")
            {
                coeff = 2;
            }

            coordinate[0] += forza * coeff;
            coordinate[1] += forza * coeff;
        }

    }
}
