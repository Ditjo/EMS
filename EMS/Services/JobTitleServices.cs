using EMS.Data;
using EMS.Models;

namespace EMS.Services
{
    public class JobTitleServices : IJobTitleServices
    {
        private readonly IJobTitleRepository _repository;

        public JobTitleServices(IJobTitleRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<JobTitleModel>> ShowJobTitles()
        {
            List<JobTitleModel> ListJobTitles = new();
            ListJobTitles = await _repository.GetData();
            return ListJobTitles;
        }
    }
}
