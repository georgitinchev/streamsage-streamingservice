using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class InterpretationDAL : BaseDAL
    {
        public InterpretationDAL(string connectionString) : base(connectionString)
        {
        }

        public void CreateInterpretation(InterpretationDTO interpretation)
        {
            throw new NotImplementedException();
        }

        public InterpretationDTO ReadInterpretation(int interpretationId)
        {
            throw new NotImplementedException();
        }

        public void UpdateInterpretation(InterpretationDTO interpretation)
        {
            throw new NotImplementedException();
        }

        public void DeleteInterpretation(int interpretationId)
        {
            throw new NotImplementedException();
        }
    }
}


