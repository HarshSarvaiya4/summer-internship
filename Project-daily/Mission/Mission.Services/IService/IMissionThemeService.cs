using Mission.Entities.ViewModels.MissionTheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IService
{
    public interface IMissionThemeService
    {
        Task<List<MissionThemeResponceModel>> GetMissionThemeListAsync();

        Task AddMissionThemeAsync(UpsertMissionThemeRequestModel model);
        Task<MissionThemeResponceModel?> GetMissionThemeByIdAsync(int missionThemeId);
        Task<bool> UpdateMissionThemeAsync(UpsertMissionThemeRequestModel model);
        Task<bool> DeleteMissionTheme(int id);
    }
}
