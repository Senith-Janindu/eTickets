using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ProducerService:EnttyBaseRepository<Producer>, IProducersService
    {
        public ProducerService(AppDbContext context):base(context)
        {

        }
    }
}
