using System.ComponentModel.DataAnnotations.Schema;
using Models.Repository;

namespace Models
{
    public partial class DefaultSettings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DefaultSettings UnderOfDepartment =>
            new UnitOfWork().DefaultSettingsRepo.Find(m => m.Department == UnderOf);
    }
}