namespace ReservaTalleres
{
    public class Taller
    {
        public string Nombre { get; set; } = "";
        public int CupoMaximo { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
