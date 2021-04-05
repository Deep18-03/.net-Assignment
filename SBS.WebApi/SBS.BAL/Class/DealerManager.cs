using SBS.BAL.Interface;
using SBS.DAL.Repository;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.BAL.Class
{
    public class DealerManager : IDealerManager
    {
        private readonly IDealerRepository _dealerRepository;
        public DealerManager(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }
        public string createDealer(DealerVM model)
        {
            return _dealerRepository.createDealer(model);
        }

        public string deleteDealer(int Id)
        {
            return _dealerRepository.deleteDealer(Id);
        }

        public List<DealerVM> getAllDealer()
        {
            return _dealerRepository.getAllDealer();
        }

        public DealerVM getDealerById(int Id)
        {
            return _dealerRepository.getDealerById(Id);
        }

        public string updateDealer(DealerVM model)
        {
            return _dealerRepository.updateDealer(model);
        }
    }
}
