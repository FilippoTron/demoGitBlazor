namespace Padel.Core.Entities;

public abstract class Animale
{
    public abstract string SuonoEmesso();

}

public class Gatto:Animale //non si possono contenere più classi base
{
    public override string SuonoEmesso() //override quando si implementa un metodo abstract
    {
        return "Miao";
    }
}

public sealed class Cane:Animale //sealed non si può derivare ulteriormente
{
    public override string SuonoEmesso()
    {
        return "Bau";
    }
}
