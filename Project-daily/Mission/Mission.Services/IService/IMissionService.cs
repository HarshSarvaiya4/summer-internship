using Mission.Entities.ViewModels.Mission;
using Mission.Entities.ViewModels.MissionApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IService
{
    public interface IMissionService
    {
        Task AddMissionRequestAsync(AddMissionRequestModel model);

        Task<List<MissionResponseModel>> GetMissionList();

        Task<MissionRequestViewModel?> GetMissionById(int id);

        Task<bool> UpdateMission(MissionRequestViewModel model);
        Task<bool> DeleteMission(int missionId);
        Task<List<ClientMissionResponseModel>> GetClientSideMissionList(int userId);

        Task<(bool result, string message)> ApplyMission(ApplyMissionRequestModel model);

        Task<List<MissionApplicationResponseModel>> GetMissionApplicationList();

        Task<bool> MissionApplicationApprove(MissionApplicationResponseModel model);

        Task<bool> MissionApplicationDelete(MissionApplicationResponseModel model);

    }
}
