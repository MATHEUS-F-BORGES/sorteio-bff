namespace sorteio_bff.Models
{
    public class RegraDetalhada
    {
        public string Titulo { get; set; }
        public IList<string> Paragrafo { get; set; }

        public static IList<RegraDetalhada> GenerateFake()
        {
            return new List<RegraDetalhada>
                {
                    new RegraDetalhada
                    {
                        Titulo = "Resgate 30 vibes para participar",
                        Paragrafo = new List<string>{ "A cada 30 vibes resgatados, seja em um unico beneficio ou a soma de varios voce ganha um numero da sorte!" }
                    },
                    new RegraDetalhada
                    {
                        Titulo = "No mês seguinte você sabera se foi premiado!",
                        Paragrafo = new List<string>{
                            "• Com o seu numero da sorte em mãos, você estará automaticamente inscrito para participar do sorteio do mes seguinte....",
                            "• Dentro de um mesmo mês, você pode ganhar ate 5 numeros da sorte. Isso signigica até 5 chances de ganhar o grande premio de R$10.000...",
                            " ",
                            "Promoção comercial valida a titulo de Capitalização de modalidade incentivo emitidos pela ICATU CAPITALIZAÇÃO, CNPJ nº 74.898.170/0001-73 e processo e SUSEP.."
                    }        
                    },
                 
                };
        }
    }
}

