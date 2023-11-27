namespace Padel.Core.Entities;
public class GiocatorePadel:Persona 
{
    #region
    // private string Nome;
    //public string Nome { get; set; }
    //private string Cognome;
    //public string Nome { get; init; } //init può essere solo inizializzato e non più modificato
    //public string Cognome { get; init; }
    //public string NumeroTelefono { get; set; } //set può essere sempre modificato

    //public GiocatorePadel()
    //{

    //}
    //public GiocatorePadel(string nome, string cognome)
    //{
    //    Nome = nome;
    //    Cognome = cognome;
    //}

    //public GiocatorePadel(string nome, string cognome, string numeroTelefono)
    //    : this(nome,cognome)
    //{
    //    NumeroTelefono = numeroTelefono;
    //}
    #endregion

    public string NumeroTessera { get; set; }
    public DateTime DataScadenzaIscrizione { get; set; }
    public CircoloPadel Circolo { get; set; }
    public bool TesseraValida { get; set; }

    //public bool TesseraValida()
    //{
    //    return DataScadenzaIscrizione > DateTime.Now;
    //}
    //public int IdCircolo { get; set; }


    public string DammiNomeCompleto(string separatore)
    {
        return $"{Nome} {separatore} {Cognome}";
    }
}
