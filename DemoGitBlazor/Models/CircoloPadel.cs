using System.Collections;

namespace Padel.Core.Entities;


public class CircoloPadelGenerico<T,U>
{
    public string Nome { get; set; } = "";//con set inizializzare sempre
    public Indirizzo? Indirizzo { get; set; }
    public List<T>? Persone { get; set; }
    public List<U>? AltrePersone { get; set; }

    public CircoloPadelGenerico()
    {
            Persone = new List<T>();    
            AltrePersone = new List<U>();
    }

    public void AggiungiPersona (T persona)
    {
        Persone?.Add(persona);
    }

    public void AggiungiAltraPersona(U persona)
    {
        AltrePersone?.Add(persona);
    }
}


    
       

	


public class CircoloPadel
{
    public string Nome { get; set; } = "";//con set inizializzare sempre
    public Indirizzo? Indirizzo { get; set; }
    public int Id { get; set; }


    //public GiocatorePadel[] Giocatori { get; set; } = new GiocatorePadel[1000];
    //public Istruttore[] Istruttori { get; set; } = new Istruttore[1000];
    public List<GiocatorePadel>? Giocatori { get; set; } 
    public List<Istruttore>? Istruttori { get; set; }    
}

