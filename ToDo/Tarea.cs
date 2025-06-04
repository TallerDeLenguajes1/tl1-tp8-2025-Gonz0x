namespace ManejoDetTarea{
    public enum EstadoTarea
    {
        Pendiente = 0,
        Realizada = 1,
    }

    public class Tarea{
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; } 
        EstadoTarea estado;
        public EstadoTarea Estado { get => estado; set => estado = value; }
        public Tarea(int tareaID, string descripcion, int duracion, EstadoTarea estado){
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
            this.estado = estado;
        }
    }
}


