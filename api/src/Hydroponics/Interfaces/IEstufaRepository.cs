using System.Collections.Generic;
using System.Threading.Tasks;
using Hydroponics.Models;
using Hydroponics.ViewModel;

namespace Hydroponics.Interfaces
{
    public interface IEstufaRepository
    {
        Task<Estufa> Post(Estufa estufa);
        Task<List<EstufaListViewModel>> GetList();
        Task<EstufaViewModel> GetById(int id);
    }
}