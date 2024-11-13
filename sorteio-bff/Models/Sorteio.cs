namespace sorteio_bff.Models
{
    public class Sorteio
    {
        public string NumeroDoSorteio { get; set; }
        public string Status { get; set; }
        public List<NumeroDaSorte> NumerosDaSorte { get; set; }
        public string NumeroSorteado { get; set; }
        public string DataFinalResultado { get; set; }

        public static IList<Sorteio> GenerateFake()
        {
            var randow = new Random();

            return new List<Sorteio>
            {
                new Sorteio
                {
                    NumeroDoSorteio = "Sorteio n°1",
                    Status = "Não Foi dessa vez",
                    NumerosDaSorte = new List<NumeroDaSorte>
                    {
                        new NumeroDaSorte { Numero = "62091", DataRecebimento = "recebido em 18/06/2024"},
                        new NumeroDaSorte { Numero = "94920", DataRecebimento = "recebido em 25/06/2024"},
                        new NumeroDaSorte { Numero = "27171", DataRecebimento = "recebido em 26/06/2024"},
                        new NumeroDaSorte { Numero = "75947", DataRecebimento = "recebido em 26/06/2024"}
                    },
                    NumeroSorteado = randow.Next(0, 99999).ToString(),
                    DataFinalResultado = DateTime.Now.AddDays(-2).ToShortDateString()
                },
                new Sorteio
                {
                    NumeroDoSorteio = "Sorteio n°2",
                    Status = "Você esta concorrendo!",
                    NumerosDaSorte = new List<NumeroDaSorte>
                    {
                        new NumeroDaSorte { Numero = "67899", DataRecebimento = "recebido em 18/06/2024"},
                        new NumeroDaSorte { Numero = "12424", DataRecebimento = "recebido em 25/06/2024"},
                        new NumeroDaSorte { Numero = "56722", DataRecebimento = "recebido em 26/06/2024"},
                        new NumeroDaSorte { Numero = "74689", DataRecebimento = "recebido em 26/06/2024"},
                        new NumeroDaSorte { Numero = "46893", DataRecebimento = "recebido em 26/06/2024"}
                    },
                    NumeroSorteado = randow.Next(0, 99999).ToString(),
                    DataFinalResultado = DateTime.Now.AddDays(15).ToShortDateString()
                },
                new Sorteio
                {
                    NumeroDoSorteio = "Sorteio n°3",
                    Status = "Você esta concorrendo!",
                    NumerosDaSorte = new List<NumeroDaSorte>
                    {
                        new NumeroDaSorte { Numero = "10987", DataRecebimento = "recebido em 18/06/2024"},
                        new NumeroDaSorte { Numero = "24901", DataRecebimento = "recebido em 25/06/2024"},
                        new NumeroDaSorte { Numero = "37546", DataRecebimento = "recebido em 26/06/2024"},
                        new NumeroDaSorte { Numero = "84366", DataRecebimento = "recebido em 26/06/2024"},
                        new NumeroDaSorte { Numero = "12457", DataRecebimento = "recebido em 26/06/2024"}
                    },
                    NumeroSorteado = randow.Next(0, 99999).ToString(),
                    DataFinalResultado = DateTime.Now.AddDays(5).ToShortDateString()
                }
            };
        }
    }
}

