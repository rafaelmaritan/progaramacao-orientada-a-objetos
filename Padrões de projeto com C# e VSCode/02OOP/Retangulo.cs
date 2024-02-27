public struct Retangulo
{
    // propriedades
    public double ladoX;
    public double ladoY;

    // Constructor
    public Retangulo(double ladoX, double ladoY)
    {

        this.ladoX = ladoX;
        this.ladoY = ladoY;
    }

    // metodos
    public double CalcularArea()
    {
        return ladoX * ladoY;
    }

}
