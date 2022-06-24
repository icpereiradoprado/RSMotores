using RsMotores.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.Web.Services
{
    public class UsuarioService<Usuario> 
    {
        public static ICollection<Usuario> _usuarios { get; set; }
        
        public UsuarioService()
        {
            _usuarios = new List<Usuario>();
        }

        //public bool CpfValidate()
        //{
        //    if(_usuario != null || string.IsNullOrEmpty(_usuario.Cpf))
        //    {
        //        string cpfAux = _usuario.Cpf.Replace("-", "");
        //        cpfAux = _usuario.Cpf.Replace(".", "");
        //        cpfAux = _usuario.Cpf.Replace(" ", "");
        //        return cpfAux.Length == 11;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //
        //
        //}
        //
        
        public ICollection<Usuario> GetListUsuarios()
        {
            return _usuarios;
        }

    }
}
