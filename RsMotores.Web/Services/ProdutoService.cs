using RsMotores.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.Web.Services
{
    public class ProdutoService
    {
        private Product _produto = new Product();

        public static ICollection<Product> ListProducts = new List<Product>();
        
        public ProdutoService(Product produto)
        {
            _produto = produto;
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
