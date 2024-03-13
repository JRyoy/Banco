namespace Varios;

public class Cliente
{
    public static int Id;
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double SaldoEf { get; set; }
    public double Saldo { get; set; }
    public double Monto { get; set; }
    public Cuenta cuenta;

    public Cliente(string Nombre, string Apellido, int SaldoEf ,Cuenta cuenta)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.SaldoEf = SaldoEf;
        this.cuenta=cuenta;
    }

    public void Acreditar(double SaldoEf)
    {
        
        this.SaldoEf = SaldoEf + Monto*80/100;
        this.Saldo= Saldo+Monto*20/100;
    }
    public void Debitar(double SaldoEf)
    {
        if (validarDebito(SaldoEf))
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
    }
    public bool validarDebito(double monto) => Saldo - monto < 0;

}
