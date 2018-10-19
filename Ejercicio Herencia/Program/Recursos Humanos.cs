using System.Collections.Generic;
namespace Program
{
        class RecursosHumanos
        {
                public RecursosHumanos(List <Empleado> empleados, List <Cliente> clientes)
                {
                        this.Empleados = empleados;
                        this.Clientes = clientes;
                }

                public List<Empleado> Empleados { get; }
                public List<Cliente> Clientes { get; }

                public void AgregarCliente(Cliente cliente)
                {
                        this.Clientes.Add(cliente);

                }
                public void AgregarEmpleado(Empleado empleado)
                {
                        this.Empleados.Add(empleado);
                }
        }
}