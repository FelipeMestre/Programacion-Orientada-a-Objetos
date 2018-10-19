namespace Adapter
{
    interface IRemote
    {
        /// <summary>
        /// Enciende la TV
        /// </summary>
        /// <param name="tv">TV a encender</param>
        void TurnOnTV(ITV tv);
        /// <summary>
        /// Apaga la TV
        /// </summary>
        /// <param name="tv">TV a apagar</param>
        void TurnOffTV(ITV tv);


    }
}