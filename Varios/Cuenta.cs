namespace Varios;

public class Cuenta
{
    public int Cbu { get; set; }
    private static int _cbu = 0;
    public double SaldoCuenta { get; set; }

    public Cuenta(double SaldoCuenta = 0)
    {
        this.Cbu = ++_cbu;
        this.SaldoCuenta=SaldoCuenta;        
    }
    internal void Acreditar(double monto)
    {
        SaldoCuenta+=monto;
    }
    internal void Debitar(double monto)
    {
        SaldoCuenta-=monto;
    }
    public bool NoAlcanzaDebito(double monto) => SaldoCuenta - monto < 0;


}
