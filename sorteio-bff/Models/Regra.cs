using sorteio_bff.Models.BaseModel;
using sorteio_bff.Utils;

namespace sorteio_bff.Models
{
    public class Regra : BaseCabecalho
    {
        public string SubTituloInfo { get; set; }
        public decimal ValorPremio { get; set; }
        public int VibesAcumuladas { get; set; }
        public int VibesFaltantes { get; set; }
        public int TotalVibesNecessarias { get; set; }
        public IList<RegraDetalhada> TextoDetalhado { get; set; }


        public static Regra GenerateFake()
        {
            var regra = new Regra
            {
                Titulo = Constants.TITLE_REGRA,
                SubTitulo = Constants.SUBTITLE_REGRA,
                SubTituloInfo = Constants.SUBTITLE_REGRA_INFO,
                ValorPremio = 10000,
                VibesAcumuladas = 7,
                TotalVibesNecessarias = 30,
                TextoDetalhado = RegraDetalhada.GenerateFake()
            };

            regra.VibesFaltantes = regra.TotalVibesNecessarias - regra.VibesAcumuladas;

            return regra;
        }
    }
}


