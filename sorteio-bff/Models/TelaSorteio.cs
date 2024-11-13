using System.Text.Json.Serialization;
using sorteio_bff.Utils;

namespace sorteio_bff.Models
{
    public class TelaSorteio
    {
        [JsonPropertyOrder(1)]
        public string Titulo { get; set; }

        [JsonPropertyOrder(2)]
        public string SubTitulo { get; set; }
        
        [JsonPropertyOrder(3)]
        public Regra Regra { get; set; }

        [JsonPropertyOrder(4)]
        public IList<Sorteio> UltimosSorteios { get; set; }
        

        public static TelaSorteio GenerateFake()
        {
            return new TelaSorteio
            {
                Titulo = Constants.TITLE_SORTEIO,
                SubTitulo = Constants.SUBTITLE_SORTEIO,
                Regra = Regra.GenerateFake(),
                UltimosSorteios = Sorteio.GenerateFake()
            };
        }
    }
}

