namespace EspacioCalculadora
{
   public class Operacion
   {
   private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
   private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
   private TipoOperacion operacion;// El tipo de operación realizada
   public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
   {
      this.resultadoAnterior = resultadoAnterior;
      this.nuevoValor = nuevoValor;
      this.operacion = operacion;
   }

   public double Resultado
   {
      get
      {
         if (operacion == TipoOperacion.Suma)
            return resultadoAnterior + nuevoValor;
         else if (operacion == TipoOperacion.Resta)
            return resultadoAnterior - nuevoValor;
         else if (operacion == TipoOperacion.Multiplicacion)
            return resultadoAnterior * nuevoValor;
         else if (operacion == TipoOperacion.Division)
         {
            if (nuevoValor != 0)
               return resultadoAnterior / nuevoValor;
            else
               throw new DivideByZeroException("No se puede dividir por cero.");
         }
         else if (operacion == TipoOperacion.Limpiar)
            return 0;
         else
            return resultadoAnterior;
      }
   }

/*    public double Resultado{
   
      get
      {
         switch(operacion){
            case TipoOperacion.Suma:
               return resultadoAnterior + nuevoValor;
            case TipoOperacion.Resta:
               return resultadoAnterior - nuevoValor;
            case TipoOperacion.Multiplicacion:
               return resultadoAnterior * nuevoValor;
            case TipoOperacion.Division:
               if (nuevoValor != 0){
                  return resultadoAnterior / nuevoValor;
               }
            case TipoOperacion.Limpiar:
               return 0;
            default:
               return resultadoAnterior;
         }
      }
   } */
   // Propiedad pública para acceder al nuevo valor utilizado en la operación
   public double NuevoValor{
      get => nuevoValor;
   } 
   public TipoOperacion Tipo
   {
      get => operacion;
   }

   // Constructor u otros métodos necesarios para inicializar y gestionar la operación
   // ...
   }
   public enum TipoOperacion{
   Suma,
   Resta,
   Multiplicacion,
   Division,
   Limpiar // Representa la acción de borrar el resultado actual o el historial
   }
}
