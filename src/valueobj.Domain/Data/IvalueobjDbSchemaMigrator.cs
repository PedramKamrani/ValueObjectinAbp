using System.Threading.Tasks;

namespace valueobj.Data;

public interface IvalueobjDbSchemaMigrator
{
    Task MigrateAsync();
}
