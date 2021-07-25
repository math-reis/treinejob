using System;
using System.Collections.Generic;
using System.Text;
using Bergs.Pxc.Pxcoiexn;

namespace Bergs.Pxc.Pxcsclxn
{
    /// <summary>Tipos de falha para a RN de Cliente</summary>
    public enum TipoFalha
    {
        CampoInvalido,
        CPFInvalido,
        CNPJInvalido,
        TipoPessoaInvalido,
        NomeInvalido
    }

    /// <summary>Classe de mensagens para a RN de Cliente</summary>
    public class MensagemCliente : Mensagem
    {
        public MensagemCliente(TipoFalha tipoFalha, params string[] parametro)
        {
            switch (tipoFalha)
            {
                case TipoFalha.CampoInvalido:
                    this.mensagem = string.Format("Campo {0} inválido.", parametro[0]);
                    break;
                case TipoFalha.CPFInvalido:
                    this.mensagem = "CPF inválido.";
                    break;
                case TipoFalha.CNPJInvalido:
                    this.mensagem = "CNPJ inválido.";
                    break;
                case TipoFalha.TipoPessoaInvalido:
                    this.mensagem = "Tipo pessoa deve ser 'F' ou 'J'.";
                    break;
                case TipoFalha.NomeInvalido:
                    this.mensagem = "Nome deve ter 2 (dois) nomes e no mínimo 2 (duas) letras no primeiro nome.";
                    break;
                default:
                    break;
            }
        }
    }
}