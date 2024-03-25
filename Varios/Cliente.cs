using VariosEstados;

namespace Varios;

public class Cliente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Saldo { get; set; }
    public Cuenta Cuenta;
    internal IEstado Estado { get; set; } = null!;
    public Cliente(string Nombre, string Apellido, Cuenta cuenta)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Cuenta = cuenta;
        Estados.AsignarEstado(this);
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

    internal void Debitar(double monto)
    {
        if (NoAlcanzaDebito(monto))
            throw new InvalidOperationException("Saldo insuficiente.");

        Estado.Debitar(this, monto);
        Estados.AsignarEstado(this);

    }
    public bool NoAlcanzaDebito(double monto) => Saldo - monto < 0;


}
