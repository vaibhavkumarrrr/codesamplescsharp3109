using Microsoft.EntityFrameworkCore.ValueGeneration;
using System.ComponentModel.DataAnnotations;

namespace csharp.training.congruent.classes
{
    public class Accounts
    {
        [Key]
        public string AccountNumber { get; set; } = string.Empty;// Primary Key
        public string AccountType { get; set; } = string.Empty;
    }
}
