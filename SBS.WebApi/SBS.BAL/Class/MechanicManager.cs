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
    public class MechanicManager: IMechanicmanager
    {
        private readonly IMechanicRepository _mechanicRepository;
        public MechanicManager(IMechanicRepository mechanicRepository)
        {
            _mechanicRepository = mechanicRepository;
        }

        public string createMechanic(MechanicVM model)
        {
            return _mechanicRepository.createMechanic(model);
        }

        public string deleteMechanic(int Id)
        {
            return _mechanicRepository.deleteMechanic(Id);
        }

        public List<MechanicVM> getallMechanic()
        {
            return _mechanicRepository.getallMechanic();
        }

        public MechanicVM getMechanicyId(int Id)
        {
            return _mechanicRepository.getMechanicyId(Id);
        }

        public string updateMechanic(MechanicVM model)
        {
            return _mechanicRepository.updateMechanic(model);
        }
    }
}
