﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.Web.Models
{
    public class Usuario 
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id, string nickname, string cpf, string email, string password)
        {
            Id = id;
            Nickname = nickname;
            Cpf = cpf;
            Email = email;
            Password = password;
        }


    }
}
