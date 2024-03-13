namespace Varios;

public class Cuenta
{
    public int Cbu { get; set; } = 0;
    public double Saldo { get; set; }
    public double Suma { get; set; }
    public double Resta { get; set; }


    public Cuenta(int Cbu)
    {
        this.Cbu = ++Cbu;
    }
    public bool Acreditar(double Monto)
    {
        if(Monto<=0)
        {
            return false;
            throw new ArgumentException("El monto del depósito debe ser mayor que cero.");
        }
        else
            return true;
            this.Saldo = Saldo + Monto;
        
    }
    public bool Debitar(double Monto)
    {
        if (Saldo < Monto)
        {
            return false;
                throw new InvalidOperationException("Saldo insuficiente.");
        }
        else
            return true;
                this.Saldo = Saldo - Monto;
    }
}
