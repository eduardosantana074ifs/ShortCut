﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class Aluno //: Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [StringLength(500)]
        [Required(ErrorMessage = "Nome é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [StringLength(11)]
        [Required(ErrorMessage = "CPF é obrigatório", AllowEmptyStrings = false)]
        public string CPF { get; set; }

        [Display(Name = "Email")]
        [StringLength(500)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Matricula")]
        [Required(ErrorMessage = "Matricula é obrigatória")]
        public int Matricula { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Display(Name = "Endereço")]
        [StringLength(500)]
        public string Endereco { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Data de nascimento é obrigatória")]
        public DateTime DtNasc { get; set; }

        [Display(Name = "Data de Matricula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Data de matricula é obrigatória")]
        public DateTime DtMatricula { get; set; }

        public Instituicao Instituicao { get; set; }
        public int InstituicaoId { get; set; }

        //public virtual ICollection<SugestaoMatricula> SugestaoMatriculas { get; set; }
        public virtual ICollection<MatriculaDisciplina> MatriculaDisciplinas { get; set; }
        public virtual ICollection<Restricao> Restricoes { get; set; }

    }
}
