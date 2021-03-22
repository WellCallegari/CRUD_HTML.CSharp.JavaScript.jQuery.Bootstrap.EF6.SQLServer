using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerStore.Models
{
    public class cadastro
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string TelCasa { get; set; }
        public string RuaCasa { get; set; }
        public int NumeroCasa { get; set; }
        public string ComplementoCasa { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string RuaEmp { get; set; }
        public int NumeroEmp { get; set; }
        public string ComplementoEmp { get; set; }
    }
}