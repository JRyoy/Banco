using VariosEstados;

namespace Varios;

public class Cliente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Saldo { get; set; }
    public Cuenta Cuenta;
    internal IEstado Estado { get; set; }

    public Cliente(string Nombre, string Apellido, Cuenta cuenta)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Cuenta = cuenta;
    }

    public void Acreditar(double Monto)
    {
        Estado.Acreditar(this, Monto);
        Estados.AsignarEstado(this);
    }
    
    internal void AcreditarEfectivo(double monto)
        => Saldo += monto;
    
    internal void DebitarEfectivo(double monto)
        => Saldo -= monto;
    
    internal void Debitar(double Monto)
    {
        if (NoAlcanzaDebito(Monto))
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
        else
        {
            Saldo -= Monto * 0.8;
            Cuenta.SaldoCuenta -= Monto * 0.2;
            Estados.AsignarEstado(this);
        }
    }
    public bool NoAlcanzaDebito(double monto) => Saldo - monto < 0;


}
