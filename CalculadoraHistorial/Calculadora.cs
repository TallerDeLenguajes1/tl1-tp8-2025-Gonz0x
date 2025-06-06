namespace EspacioCalculadora{
    public class Calculadora{
        private double dato; 
        private List<Operacion> historial;

        public Calculadora()
        {
            dato = 0;
            historial = new List<Operacion>();
        }
    
        public void Sumar(double termino){
            var op = new Operacion(dato, termino, TipoOperacion.Suma);
            dato = op.Resultado;
            historial.Add(op);
        }
        public double getResultado(){
            return dato;
        }
        public void Restar(double termino){
            var op = new Operacion(dato, termino, TipoOperacion.Resta);
            dato = op.Resultado;
            historial.Add(op);
        }
        public void Multiplicar(double termino){
            var op = new Operacion(dato, termino, TipoOperacion.Multiplicacion);
            dato = op.Resultado;
            historial.Add(op);
        }
        public void Dividir(double termino){
            if (termino != 0)
            {
                var op = new Operacion(dato, termino, TipoOperacion.Division);
                dato = op.Resultado;
                historial.Add(op);
            }else
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR EN 0.");
            }
        }
        public void Limpiar(){
            var op = new Operacion(dato, 0, TipoOperacion.Limpiar);
            dato = 0;
            historial.Add(op);
        }

        public List<Operacion> Historial{
            get => historial;
        }
    
        /* public double resultado{
            get=>dato;
        } */

    }
}

