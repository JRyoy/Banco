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
    internal void Acreditar(double Monto)
    {

        cliente.Saldo += Monto * 0.8;
        SaldoCuenta += Monto * 0.2;
    }
    internal void Debitar(double Monto)
    {
        if (validarDebito(Monto))
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
        else
        {
            SaldoCuenta -= Monto * 0.8;
            cliente.Saldo -= Monto * 0.2;
        }
    }
    public bool validarDebito(double monto) => SaldoCuenta - monto < 0;


}
