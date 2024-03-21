namespace Varios.Estados;

internal class Emergencia : IEstado
{
    public bool ValidarUso(Cliente cliente) => cliente.Saldo < 10000;
    public void Acreditar(Cliente cliente, double Monto)
    {
        cliente.Saldo += Monto*0.8;
        cliente.cuenta.SaldoCuenta += Monto;
    }

    public void Debitar(Cliente cliente, double Monto)
    {
        if(cliente.cuenta.SaldoCuenta > Monto)
        {
            cliente.cuenta.SaldoCuenta -= Monto;
        }
        else
            cliente.Saldo-=Monto;
    }
        
        

    
}
