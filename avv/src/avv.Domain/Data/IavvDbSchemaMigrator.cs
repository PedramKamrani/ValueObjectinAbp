using System.Threading.Tasks;

namespace avv.Data;

public interface IavvDbSchemaMigrator
{
    Task MigrateAsync();
}
