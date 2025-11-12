
Carro chevrolet = new Carro("sedan", "chevrolet", "onix", 2016, 110);
Carro ford = new Carro("suv", "ford", "ecosport", 2018, 120);

Console.WriteLine(chevrolet.ToString());
chevrolet.Acelerar("chevrolet");

public class Carro
{
    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public void Acelerar(string? marca)
    {
        Console.WriteLine($"Acelerando meu {marca}");
    }

    public override string ToString()
    {
        return "Modelo " + this.Modelo +
        "\nMontadora " + this.Montadora +
        "\nMarca " + this.Marca +
        "\nAno " + this.Ano +
        "\nPotência " + this.Potencia;
    }


}