﻿using RsMotores.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.Web.Services
{
    public class UsuarioService
    {
        private Usuario _usuario = new Usuario();

        public static ICollection<Usuario> ListUsers = new List<Usuario>();
        
        public UsuarioService(Usuario usuario)
        {
            _usuario = usuario;
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

    }
}
