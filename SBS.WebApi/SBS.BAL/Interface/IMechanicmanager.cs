using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.BAL.Interface
{
    public interface IMechanicmanager
    {
        List<MechanicVM> getallMechanic();
        MechanicVM getMechanicyId(int Id);
        string deleteMechanic(int Id);
        string updateMechanic(MechanicVM model);
        string createMechanic(MechanicVM model);
    }
}
