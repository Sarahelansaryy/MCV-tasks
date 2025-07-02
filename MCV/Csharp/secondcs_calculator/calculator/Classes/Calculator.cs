class Calculator : ICalculator
{
    public float Add(float a, float b)
    {
        return a + b;
    }

    public float Subtract(float a, float b)
    {
        return a - b;
    }

    public float Multiply(float a, float b)
    {
        return a * b;
    }

    public float Divide(float a, float b)
    {
        return b != 0 ? a / b : 0; 
    }
}