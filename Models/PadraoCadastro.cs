﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Drinkr.Models
{
    public abstract class PadraoCadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Data de nascimento")]
        public DateTime Idade { get; set; }
        public string Password { get; set; }
        protected PadraoCadastro()
        {
        }

        protected PadraoCadastro(int id, string nome, string email, int cpf, int telefone, DateTime idade, string password)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
            Idade = idade;
            Password = password;
        }
    }
}
