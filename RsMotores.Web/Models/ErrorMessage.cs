using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.Web.Models
{
    public class ErrorMessage
    {
        public string Msg { get; set; }
        /// <summary>
        /// Retorna uma mensagem de erro na propriedade Msg.
        /// 1 => Erro de Login,
        /// 2 => Erro de CPF,
        /// 3 => Erro de campos vazios
        /// </summary>
        /// <param name="_type"></param>
        public ErrorMessage(int _type)
        {
            switch (_type)
            {
                case 1:
                    Msg = "Login inválido. E-mail ou senha não encotrado";
                    break;
                case 2:
                    Msg = "CPF inválido. O CPF informado está inválido";
                    break;
                case 3:
                    Msg = "Os campos E-mail e senha estão vazios! ";
                    break;
                default:
                    Msg = "Erro não reconhecido. Entrar em contato com o suporte@admin.com";
                    break;
            }
        }
    }
}
