using System.ComponentModel.DataAnnotations;

namespace Padel.Core.Entities;

public class Lezione
{
	public int Id { get; set; }
	public DateTime DataOraInizio { get; set; }
	public DateTime DataOraFine { get; set; }
	[Required(ErrorMessage = "Il numero del campo è obbligatorio")]
	public string Campo { get; set; } = "";
	public int IstruttoreId { get; set; }
	public Istruttore? Istruttore { get; set; }
}
