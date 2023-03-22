using EMS.Models;

namespace EMS.Services
{
    public interface IJobTitleServices
    {
        public Task<List<JobTitleModel>> ShowJobTitles();
    }
}
