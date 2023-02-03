﻿/**************************************\
 * Biblioteca C# para APIs do PIX     *
 * Autor: Rafael Estevam              *
 *        gh/SharpSistemas/SicoobAPI  *
\**************************************/
namespace CS.BCB.PIX.Models;

using Newtonsoft.Json;

[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public class NovaCobrancaVencimento
{
    public CalendarioVencimentoCriacao calendario { get; set; }
    public DadosDevedor devedor { get; set; }
    public DadosLocCriacao loc { get; set; }
    public ValorVencimento valor { get; set; }
    public string chave { get; set; }

    public string? solicitacaoPagador { get; set; }
    public NomeValor[] infoAdicionais { get; set; }

    public static NovaCobrancaImediata Padrao(string chave, decimal valor, int expiracaoSegundos = 3600, string? solicitacaoPagador = null)
    {
        return new NovaCobrancaImediata()
        {
            chave = chave,
            valor = new ValorModalidade()
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
public class RevisarCobrancaVencimento : NovaCobrancaVencimento
{
    public string status { get; set; } = "REMOVIDA_PELO_USUARIO_RECEBEDOR"; // REMOVIDA_PELO_USUARIO_RECEBEDOR 
}
