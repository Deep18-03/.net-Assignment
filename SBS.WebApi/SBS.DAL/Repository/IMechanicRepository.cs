using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Repository
{
    public interface IMechanicRepository
    {
        List<MechanicVM> getallMechanic();
        MechanicVM getMechanicyId(int Id);
        string updateMechanic(MechanicVM model);
        string deleteMechanic(int Id);
        string createMechanic(MechanicVM model);
    }
}
