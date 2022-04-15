using JourneyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyPlanner.Services
{
    public interface IJourneyService
    {
      List<Places> GetPlaces();
    }
}
