using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Demo.Entities
{
    // EF Core Support 4 Ways For Mapping Classes in Database: [Table, View, Function]
    // 1. By Convention [Default Behaviour]
    // 2. Data Annotation [Set Of Attributes Used For Data Validation]
    // 3. Fluent APIs
    // 4. Class Configuration



    //// Entity
    //// POCO:
    //// Plain Old CLR Object
    //internal class Employee // Table
    //{
    //    public int Id { get; set; } // Public Numeric Property Named "Id" || EmployeeId  --> PK - Identity(1, 1)
    //    public string Name { get; set; } // Reference Type: Requried [Not Allow Null] - nvarchar(max)
    //    public int? Age { get; set; } // Nullable Value Type : int[Age] - Optional - [Allow Null]
    //    public double Salary { get; set; } //Value Type : float[Salary] - Required
    //    public string? Email { get; set; } // nvarchar(max) - Optional
    //    public DateTime DateOfCreation { get; set; } // datetime2 - Required
    //}


    // 2. Data Annotation:
    //[Table("Hamada", Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Range(20, 60)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string Phone { get; set; }

    //    [Column(TypeName = "money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }

    //    public string Password { get; set; }
    //}


    // 3. Fluent APIs
    internal class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfCreation { get; set; }
    }

}
