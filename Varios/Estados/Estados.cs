using VariosEstados;

namespace Varios;

public static class Estados
{
    private static List<IEstado> _estados= new(){
        new Emergencia(),
        new Cauto(),
        new Ahorrista()
    };
    public static void AsignarEstado(Cliente cliente)
        =>  cliente.Estado =
            _estados.FirstOrDefault(x=>x.ValidarUso(cliente));



}
