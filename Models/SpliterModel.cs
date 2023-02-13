namespace spliter.Models;
using System.Text.RegularExpressions;


public class Spliter
{
    public string contenido { get; set; }


    public string[] splitear( string separador ){

        this.contenido = Regex.Replace(this.contenido, @"\s+"," ").Trim();

        this.contenido = Regex.Replace(this.contenido, @"\n+","\n").Trim();
        
        return contenido.Split( separador );
    }
}
