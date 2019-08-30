using System.Collections.Generic;
namespace Program
{
    class Program
    {
            static void Main()
            {
                List<DVD> dvds = new List<DVD>();
                List<string> actores = new List<string>();
                actores.Add("Marlon Brando");
                actores.Add("Al Pacino");
                DVD ElPadrino = new DVD("The Godfather","Accion",actores);
                DVD ElPadrino2 = new DVD("The Godfather", "Accion", actores);
                dvds.Add(ElPadrino);
                dvds.Add(ElPadrino2);
                
                List<Cd> discos = new List<Cd>();
                List<string> songs = new List<string>();
                songs.Add("Breathe");
                songs.Add("Time");
                Cd DarkSideOFTheMoon = new Cd("The Dark Side Of The Moon","Progressive Rock","Pink Floyd",songs,1972);
                List<string> songs2 = new List<string>();
                songs2.Add("jijiji");
                songs2.Add("Divina Tv Fuhrer");
                Cd Oktubre = new Cd("Oktubre","Rock","Patricio Rey y sus rendonditos de ricota",songs2,1986);
                discos.Add(Oktubre);
                discos.Add(DarkSideOFTheMoon);
                Stock catalogo = new Stock(dvds,discos);

                Cliente cliente = new Cliente("Gabriel","Peluffo","Av italia 3252","Gpeluffo@despuesdelauna.com");
                Empleado empleado = new Empleado("Felipe","Mestre","49209164","feli13mestre@gmail.com",19);
                Cliente cliente2 = new Cliente("David", "Guilmour", "Av Abbey Road 8942", "DGuilmour@outlook.com");
                Empleado empleado2 = new Empleado("Alfonso", "Mestre", "3924898", "alfonso.mestre4@gmail.com", 25);
                List<Empleado> empleados = new List<Empleado>();
                List<Cliente> clientes = new List<Cliente>();
                empleados.Add(empleado);
                empleados.Add(empleado2);
                clientes.Add(cliente2);
                clientes.Add(cliente);
                RecursosHumanos staff = new RecursosHumanos(empleados,clientes);
                //empleado2.EnviarMailEmpleado(Asunto,Contenido,mail remitente,Contraseña,Nombre del remitente);
                //cliente.EnviarMailCorporativo(Asunto, Contenido, Mailremitente, contraseña, nombreDeRemitente);

                List<string> actores2 = new List<string>();
                actores2.Add("Daniel Radcliff");
                actores2.Add("Emma Watson");
                DVD dvd3 = new DVD("Harry Potter & La Orden del Fenix","Aventuras",actores2);

                catalogo.AgregarDvd(dvd3);

                List<string> songs3 = new List<string>();
                songs3.Add("numeral");
                songs3.Add("desastre");
                Cd FuerzaNatural = new Cd("Fuerza Natural","Rock & Pop","Gustavo Cerati",songs3,2009);

                catalogo.AgregarCD(FuerzaNatural);
            }
    }
}