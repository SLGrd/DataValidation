using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using static Common.Glb;

namespace Common.Models
{
    public class AmigoModel
    {
        [Required]
        [MinLength( 4, ErrorMessage = "Nome must have at least 4 chars")]
        [MaxLength(40, ErrorMessage = "Nome must have max 40 chars")]        
        public string Nome { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "CPF must have max 14 chars including pints and hifen")]
        [ValidChars(ValidChars: "-.0123456789", ErrorMessage = "Only .- and numbers are allowed")]    
        [ValidCpf( ErrorMessage = "Invalid CPF format")]
        public string Cpf { get; set; }

        [Required]
        [MinLength(4,  ErrorMessage = "Phone have at least 4 chars")]
        [MaxLength(24, ErrorMessage = "Phone must have max 24 chars")]
        [ValidChars(ValidChars: "()+- 0123456789", ErrorMessage = "Only ()- or numbers are allowed")]
        public string Phone { get; set; }

        [Editable(false)]
        public int RowId { get; set; }

        public AmigoModel()
        {
            Nome  = "";
            Cpf   = "";
            Phone = "";
            RowId = 0;
        }
        public AmigoModel(string nome, string cpf, string phone, int rowId)
        {
            Nome  = nome;
            Cpf   = cpf;
            Phone = phone;
            RowId = rowId;
        }
    }

    public class EmployeeModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public bool Status { get; set; }

        [Range(typeof(DateTime), "1/1/1950", "31/12/2005", ErrorMessage = "Value for Data de nascimento must be between {1:dd/MM/yyyy} and {2:dd/MM/yyyy}")]
        public DateTime DateOfBirth { get; set; } = new(1950, 1, 1);

        [Range( 1, 2, ErrorMessage = "Select Gender")]
        public Glb.Gender Gender{ get; set; }

        [Range(1, 2, ErrorMessage = "Select Department")]
        public int DepartmentID { get; set; }       

        public EmployeeModel() {}
        public EmployeeModel( string name, bool status, DateTime dateofbirth, Enum gender, int departmentID  )
        {
            Name = name;
            Status = status;
            DateOfBirth = dateofbirth;
            Gender = (Gender)gender;
            DepartmentID = departmentID;
        }
    }

    public class ValidChars : ValidationAttribute
    {
        private readonly string valChars;
        public ValidChars(string ValidChars)
        {
            this.valChars = ValidChars;
        }

        public override bool IsValid(object value)
        {
            if ( value == null) { return false; };

            string w = value.ToString();
            
            for (int i = 0; i < w.Length; i++)                              //  Checks for chars not contained in the permitted chars list
            { if (!valChars.Contains(w[i])) { return false; } }
            
            return true;                                                    //  No invalid chars have been found
        }
    }

	public class ValidCpf : ValidationAttribute
    {        
		public override bool IsValid(object value)
        {
            if (value == null) return false; 

            string w = value.ToString().Replace(".", "").Replace("-", "");  //  Clear points and hifens

            if (!w.All(char.IsDigit))   return false;                       //  Somente numeros ?
            if ( w.Length != 11)        return false;                       //  Numero de caracteres valido ?

            //--------------------- Primeiro digito de controle ------------------------------------------------------------
            if ( w[9] != CalculaDigito(w, 9)) return false;                 //  Primeiro digito de controle valido ?
                
            //--------------------- Segundo digito de controle --------------------------------------------------------------
            if ( w[10] != CalculaDigito( w, 10)) return false;              //  Segundo digito de controle valido ?  

            return true;                                                    //  Verification digits matched                                  
        }
        public char CalculaDigito( string w, int DigitNumber)
        {
            int Digit = 0;
            for (int i = 0; i < DigitNumber; i++)                           //  Transforma char em binario                                                                         
                { Digit += (w[i] - '0') * (DigitNumber + 1 - i); }          //  w[i] - '0' =  Convert.ToInt32(w[i].ToString()) 

            Digit =  (11 - (Digit %= 11) ) > 9 ? 0 : (11 - (Digit %= 11));  //  11 - Resto da divisão por 11. Se for maior que 9 ==> digito = 0

            return (char)( Digit + '0');                                    //  Transforma em Ascii : ex 0 em Ascii é 48 binario
        }
    }
}