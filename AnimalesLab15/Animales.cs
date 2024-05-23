namespace AnimalesLab15
{
    public class Animales
    {
        public string Nombre { get; set; }

        public string Especie { get; set; }

        public string Alimentacion { get; set; }   

        public string TdeVida {  get; set; }

        public Animales()
        {
            Nombre = string.Empty;
            Especie = string.Empty; 
            Alimentacion = string.Empty;
            TdeVida = string.Empty;
        }

    }
}
