# Felipe-Mestre
Repositorio de código de FelipeMestre

# Ejercicios de DIP, ISP, SRP
## Ejercicio 1 

**DIP:** El patrón de inversión de dependencias enuncia que las clases de alto nivel no deben depender de las de bajo nivel.
         En este caso la clase de alto nivel sería AnalizadorDatos que depende de BaseDeDatos (que es la clase de bajo nivel) para                cumplir con sus responsabilidades. El patrón no se cumple, ya que en lugar de depender de la clase BaseDeDatos la clase                  AnalizadorDatos debería depender de una abstracción. Una interfaz IDataBase por ejemplo que implemente los métodos                      pertinentes al uso que se le da (ListarDatos por ejemplo).

**ISP:** El principio de segregación de interfaces enuncia que una clase no debe depender de un tipo que no usa. En este caso                    AnalizadorDatos depende de la clase BaseDeDatos, pero en este caso la clase AnalizadorDatos no implementa ningún tipo de otra            clase y BaseDeDatos tampoco. Por ende se cumple el patrón. Ya que si hay algun cambio en agun tipo de alguna clase del programa          no deberia provocar la necesidad de cambios en otra clase, excepto las cosas que se están usando.

**SRP:** El patrón de responsabilidad unica enuncia que una clase debería tener una sola razón para cambiar. En este caso el estado de            la clase BaseDeDatos solo debría cambiar si se le agrega un dato y la clase AnalizarDatos solo tiene una responsabilidad que es          la de analizar los datos de la base de datos. La clase DataObject tiene como proposito unico conocer una descripción. Por ende           si se cumple.

***Ejerciocios 2y3***
```cs
{
public interface ICondition
         {
                string MensajeUno;
                
                string MensajeDos;
                
                bool validar(DataBaseObject objeto);
                //Devuelve True si el objeto cumple la condicion
        }
        public interface IDataBase
        {
             DataBaseObject[] ListarDatos();             
                                
        }
//Objeto que representa un dato de la base de datos.
class DataBaseObject
{
    public string Descripcion { get; }
}

//Base de datos.
class BaseDeDatos : IDataBase
{
    public DataBaseObject ObtenerDato(string clave)
    {
        //Devuelve el dato correspondiente a la clave
    }
    public void GrabarDato(string clave, DataBaseObject dato)
    {
        //Graba el dato en la base de datos, bajo la clave dada
    }
    public String[] ListarClaves()
    {
        //Devuelve un String[] con todas las claves
    }
    public String[] ListarDescripcionDatos()
    {
        //Devuelve un String[] con la descripción de todas los 
        //datos almacenados en  la base
    }
    public DataBaseObject[] ListarDatos()
    {
        //Devuelve un DataBaseObject[] con todos los datos almacenados en la base
    }
}
class AnlizadorDatos
{
        private ICondition condicion{get;set;}
    private IDataBase baseDatos{get; set;}
    public void Analizar()
    {
        foreach (DataBaseObject DBObj in baseDatos.ListarDatos())
        {
            if (condicion.CumpleCondicion(DBObj))
            {
                MensajeUno(condicion.MensajeUno);
            }
            else
            {
                MensajeDos(condicion.MensajeDos);
            }
        }
    }
    public class Condicion : Icondition
    {
         public string mensaje1
         public string mensaje2
         public bool Cumplecondicion(DataBaseObject DBobj)
         {
         return condicion.validar(DBobj);
         }
    }
    public void MensajeUno(string MensajeUno)
    { /*Mensaje indicado*/ }
    public void MensajeDos(string MensajeDos)
    { /*Mensaje indicado*/ }
}
```
