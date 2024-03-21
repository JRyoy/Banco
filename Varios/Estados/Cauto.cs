namespace Varios.Estados;

internal class Cauto : IEstado
{
    bool IEstado.ValidarUso(Cliente cliente)=>cliente.Saldo >10000 && cliente.Saldo<50000;
    public void Acreditar(Cliente cliente, double Monto)
    {
        cliente.Saldo += Monto*0.8;
        cliente.cuenta.SaldoCuenta += Monto * 0.2;
    }

    public void Debitar(Cliente cliente, double Monto)
    {
        if(cliente.cuenta.SaldoCuenta > Monto)
        {
            cliente.Saldo -= Monto*0.8 ;
            cliente.cuenta.SaldoCuenta-=Monto*0.8;
        }
    }

}
