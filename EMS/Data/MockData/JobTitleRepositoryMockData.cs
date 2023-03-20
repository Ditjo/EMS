using EMS.Models;

namespace EMS.Data.MockData
{
    public class JobTitleRepositoryMockData : IJobTitle
    {
        public async Task<List<JobTitleModel>> GetData()
        {
            List<JobTitleModel> list = new()
            {
                new()
                {
                    Id=1,
                    JobTitleName="CoffeBoy"
                },
                new()
                {
                    Id=2,
                    JobTitleName="Da Boss"
                },
                new()
                {
                    Id=3,
                    JobTitleName="Kontor Nusser"
                },
                new()
                {
                    Id=4,
                    JobTitleName="Hackerman"
                },
                new()
                {
                    Id=5,
                    JobTitleName="Lystløgner"
                }
            };
            return list;
        }
    }
}
