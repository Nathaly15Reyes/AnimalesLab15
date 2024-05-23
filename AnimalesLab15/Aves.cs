namespace AnimalesLab15
{
    public class Aves : Animales 
    {
        public string Volador { get; set; }

        public string PeriodoIncub {  get; set; }

        public Aves() 
        { 
            Volador = string.Empty;
            PeriodoIncub = string.Empty;    

        }
    }
}
