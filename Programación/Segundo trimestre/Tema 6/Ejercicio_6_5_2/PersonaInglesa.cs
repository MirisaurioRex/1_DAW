using System;

class PersonaInglesa : Persona
{
    public PersonaInglesa()
    {
        nombre = "Jhon";
    }
    public PersonaInglesa(string nom)
    {
        nombre = nom;
    }
    public void TomarTe()
    {
        Console.WriteLine("Estoy tomanto el té");
    }
    public new void Saludar()
    {
        Console.WriteLine("Hi, I'm {0} ", nombre);
    }
}