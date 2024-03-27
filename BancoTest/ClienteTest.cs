using Varios;

namespace BancoTest;

public class ClienteTest
{
    [Fact]
    public void AltaCliente()
    {
        var cuanta=new Cuenta();
        var  Hijitus= new Cliente(" Hijitus", "Sacaca",cuanta,0);
    }
}