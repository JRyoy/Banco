namespace Varios;

public class Cuenta
{
    public int Cbu { get; set; } = 0;
    public double SaldoCuenta { get; set; }
    public Cliente cliente { get; set; }

    public Cuenta(int Cbu, Cliente cliente)
    {
        this.Cbu = ++Cbu;
        this.cliente = cliente;
    }
    internal void Acreditar(double monto)
    {

        cliente.Saldo += monto * 0.8;
        SaldoCuenta += monto * 0.2;
    }
    internal void Debitar(double monto)
    {
        if (validarDebito(monto))
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
        else
        {
            SaldoCuenta -= monto * 0.8;
            cliente.Saldo -= monto * 0.2;
        }
    }
    public bool validarDebito(double monto) => SaldoCuenta - monto < 0;


}
