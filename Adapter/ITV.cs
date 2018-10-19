namespace Adapter
{
    public interface ITV
    {
        /// <summary>
        /// Prende la TV
        /// </summary>
        void TurnOn();
        /// <summary>
        /// Apaga la TV
        /// </summary>
        void TurnOff();
        /// <summary>
        /// Devuelve el estado de la TV
        /// </summary>
        /// <returns>True si la TV está encendida</returns>
        bool Status {get;}
    }
}