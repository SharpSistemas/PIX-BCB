﻿/**************************************\
 * Biblioteca C# para APIs do PIX     *
 * Autor: Rafael Estevam              *
 *        gh/SharpSistemas/SicoobAPI  *
\**************************************/
using Newtonsoft.Json;

namespace CS.BCB.PIX.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class NovaCobrancaImediata
    {
        public CalendarioImadiataCriacao calendario { get; set; }
        public NomeCpfCnpj devedor { get; set; }
        public DadosLocCriacao loc { get; set; }
        public Valor valor { get; set; }
        public string chave { get; set; }

        public string? solicitacaoPagador { get; set; }
        public NomeValor[] infoAdicionais { get; set; }

        public static NovaCobrancaImediata Padrao(string chave, decimal valor, int expiracaoSegundos = 3600, string? solicitacaoPagador = null)
        {
            return new NovaCobrancaImediata()
            {
                chave = chave,
                valor = new Valor()
                {
                    original = valor,
                    modalidadeAlteracao = 0 // não pode mudar
                },
                calendario = new CalendarioImadiataCriacao()
                {
                    expiracao = expiracaoSegundos,
                },
                solicitacaoPagador = solicitacaoPagador,
            };
        }
    }
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RevisarCobrancaImediata : NovaCobrancaImediata
    {
        public string status { get; set; } = "REMOVIDA_PELO_USUARIO_RECEBEDOR"; // REMOVIDA_PELO_USUARIO_RECEBEDOR 
    }
}
