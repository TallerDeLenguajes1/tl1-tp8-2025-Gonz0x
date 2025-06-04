using ManejoDetTarea;
class progama
{
    static List<Tarea> tareasPendientes = new List<Tarea>();
    static List<Tarea> tareasRealizadas = new List<Tarea>();
    static Random random = new Random();

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1. Crear tarea");
            Console.WriteLine("2. Mover tarea a realizadas");
            Console.WriteLine("3. Buscar tarea por descripción");
            Console.WriteLine("4. Mostrar todas las tareas");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        CrearTarea();
                        break;
                    case 2:
                        MoverTarea();
                        break;
                    case 3:
                        BuscarTarea();
                        break;
                    case 4:
                        MostrarTareas();
                        break;
                    case 0:
                        Console.WriteLine("FIN");
                        break;
                    default:
                        Console.WriteLine("SELECCIONE UNA OPCION VALIDA.");
                        break;
                }
            }
        } while (opcion != 0);
    }


    static void CrearTarea()
    {
        Console.Write("Ingrese cantidad de tareas que quiera crear: ");
        if (int.TryParse(Console.ReadLine(), out int cantTareas))
        {
            for (int i = 0; i < cantTareas; i++)
            {
                int id = tareasPendientes.Count + tareasRealizadas.Count + 1;
                string descripcion = $"Tarea {id}";
                int duracion = random.Next(10, 101);
                Tarea nuevaTarea = new Tarea(id, descripcion, duracion, EstadoTarea.Pendiente);
                tareasPendientes.Add(nuevaTarea);
            }
            Console.WriteLine("Tareas creadas con exito!");
        }
    }

    static void MoverTarea()
    {
        Console.Write("Ingrese el ID de la tarea a mover: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Tarea tareaEncontrada = null;
            foreach (Tarea t in tareasPendientes)
            {
                if (t.TareaID == id)
                {
                    tareaEncontrada = t;
                }
            }

            if (tareaEncontrada != null)
            {
                tareaEncontrada.Estado = EstadoTarea.Realizada;
                tareasPendientes.Remove(tareaEncontrada);
                tareasRealizadas.Add(tareaEncontrada);
                Console.WriteLine("Tarea movida a realizadas.");
            }
            else
            {
                Console.WriteLine("Tarea no encontrada en pendientes.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }
    }

    static void BuscarTarea()
    {
        Console.Write("Ingrese texto a buscar en la descripción: ");
        string busqueda = Console.ReadLine().Trim().ToLower();

        bool encontrada = false;
        foreach (Tarea t in tareasPendientes)
        {
            if (t.Descripcion.ToLower().Contains(busqueda))
            {
                Console.WriteLine($"ID: {t.TareaID}, Descripción: {t.Descripcion}, Estado: {t.Estado}");
                encontrada = true;
            }
        }

        if (!encontrada)
        {
            Console.WriteLine("No se encontro tarea.");
        }
    }

    static void MostrarTareas()
    {
        Console.WriteLine("\n--- TAREAS PENDIENTES ---");
        if (tareasPendientes.Count == 0)
            Console.WriteLine("No hay tareas pendientes.");
        else
        {
            foreach (Tarea t in tareasPendientes)
            {
                Console.WriteLine($"{t.TareaID} | {t.Descripcion} | {t.Duracion} | {t.Estado}");
            }
        }

        Console.WriteLine("\n--- TAREAS REALIZADAS ---");
        if (tareasRealizadas.Count == 0)
            Console.WriteLine("No hay tareas realizadas.");
        else
        {
            foreach (Tarea t in tareasRealizadas)
            {
                Console.WriteLine($"{t.TareaID} | {t.Descripcion} | {t.Duracion} | {t.Estado}");
            }
        }
    }
}

/*     
    
    Console.WriteLine("Ingrese descripcion de la tarea:");
    string DescTarea = Console.ReadLine();

    Tarea Ntarea = new Tarea();
    Ntarea.Descripcion = DescTarea;
    Ntarea.TareaID = id++;
    Ntarea.Estado = EstadoTarea.Pendiente;

    tareasPendientes.Add(Ntarea);

    Console.WriteLine("Desea Ingresar una nueva tarea?");
    Console.WriteLine("Seleccione: s.si no.n");
    salida = Console.ReadLine();
 */