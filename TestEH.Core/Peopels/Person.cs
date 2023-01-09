using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestEH.Peopels
{
    [Table("Person")]
    public class Person : FullAuditedEntity
    {
        [MaxLength(10)]
        public string Code { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }
        public PersonType PersonType { get; set; }
    }

    public enum PersonType
    {
        Real = 1,
        Legal = 2
    }
}
