using EspacioCalculadora;

Calculadora calc = new Calculadora();

calc.Sumar(10);           // 0 + 10 = 10
calc.Restar(2);           // 10 - 2 = 8
calc.Multiplicar(3);      // 8 * 3 = 24
calc.Dividir(4);          // 24 / 4 = 6
calc.Limpiar();           // resultado = 0

Console.WriteLine("Historial de operaciones:");
foreach (var op in calc.Historial)
{
    Console.WriteLine($"{op.Tipo} → Resultado: {op.Resultado}");
}

Console.WriteLine($"Resultado final: {calc.getResultado()}");
