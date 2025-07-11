using Mission.Entities.ViewModels.MissionTheme;

namespace Mission.Repositories.IRepository
{
    public interface IMissionThemeRepository
    {
        Task<List<MissionThemeResponceModel>> GetMissionThemeListAsync();

        Task AddMissionThemeAsync(UpsertMissionThemeRequestModel model);

        Task<MissionThemeResponceModel?> GetMissionThemeByIdAsync(int missionThemeId);
        Task<bool> UpdateMissionThemeAsync(UpsertMissionThemeRequestModel model);
        Task<bool> DeleteMissionTheme(int id);
    }
}
