using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Repository
{
    public interface IDealerRepository
    {
        List<DealerVM> getAllDealer();
        DealerVM getDealerById(int Id);
        string updateDealer(DealerVM model);
        string createDealer(DealerVM model);
        string deleteDealer(int Id);
    }
}
