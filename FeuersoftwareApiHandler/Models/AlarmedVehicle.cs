namespace FeuersoftwareApiHandler.Models
{
    /// <summary>
    /// Ein Fahrzeug innerhalb der AAO
    /// </summary>
    public class AlarmedVehicle
    {
        /// <summary>
        /// Der Schlüssel des Fahrzeugs
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Der Funkrufname des Fahrzeugs
        /// </summary>
        public string RadioIdentifier { get; set; }
    }
}
