using ProjectHerculesService.Data.Models;

namespace ProjectHerculesService.Repository.Interface
{
    public interface IContextContainer
    {
        HerculesContext GetHerculesServiceContextInstance();
    }
}