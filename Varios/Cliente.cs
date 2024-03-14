namespace Varios;

public class Cliente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Saldo { get; set; }
    public Cuenta cuenta;

    public Cliente(string Nombre, string Apellido, Cuenta cuenta)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.cuenta=cuenta;
    }

    public void Acreditar(double Monto)
    {
        
        Saldo += Monto * 0.8;
        cuenta.SaldoCuenta += Monto * 0.2;
    }
    public void Debitar(double Monto)
    {
        if (NoAlcanzaDebito(Monto))
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
        else
        {
            Saldo -= Monto * 0.8;
            cuenta.SaldoCuenta -= Monto * 0.2;
        }
    }
    public bool NoAlcanzaDebito(double monto) => Saldo - monto < 0;

}
