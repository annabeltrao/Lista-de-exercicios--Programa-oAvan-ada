//Classe "Círculo": Crie uma classe "Círculo" que tenha um atributo de raio e métodos para
//calcular a área e o perímetro do círculo. Implemente também um método para exibir as
//informações do círculo (raio, área e perímetro).

class Circulo
{
    public double raio { get; set; }

    public double CalcularArea()
    {
        // Fórmula da área do círculo:
        // Área = π * raio²
        //
        // Math.PI representa o valor de π (3,14159...)
        // Math.Pow(Raio, 2) eleva o valor do raio ao quadrado.
        //
        // O resultado do cálculo é retornado pelo "return".

        return Math.PI * Math.Pow(raio, 2); 
    }

    public double CalcularPerimetro()
    {
        // Fórmula do perímetro:
        // Perímetro = 2 * π * raio
        //
        // Math.PI representa o valor de π.
        // Raio representa o valor armazenado na propriedade Raio.
        //
        // O resultado é retornado pelo "return".

        return 2 * Math.PI * raio;
    }

    public void ExibirInformações()
    {
        Console.WriteLine("Informações do circulo:");
        Console.WriteLine($"Raio:{raio}");
        Console.WriteLine($"Area:{CalcularArea():F2}");
        Console.WriteLine($"Perimetro:{CalcularPerimetro():F2}");
    }
}

class program 
{
    static void Main()
    {
        Circulo circulo = new Circulo();

        circulo.raio = 5;

        circulo.ExibirInformações();
    }
}