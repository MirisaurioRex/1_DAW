using System;
internal class PersonaItaliana : Persona
{
    public new void Saludar()
    {
        Console.WriteLine("Ciao, {0} ", nombre);
    }
}
