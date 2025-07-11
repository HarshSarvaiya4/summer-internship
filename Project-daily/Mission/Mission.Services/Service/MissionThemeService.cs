using Mission.Entities.ViewModels.MissionTheme;
using Mission.Repositories.IRepository;
using Mission.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.Service
{
    public class MissionThemeService(IMissionThemeRepository missionThemeRepository) : IMissionThemeService
    {
        private readonly IMissionThemeRepository _missionThemeRepository = missionThemeRepository;
        
        public async Task<List<MissionThemeResponceModel>> GetMissionThemeListAsync()
        {
            return await _missionThemeRepository.GetMissionThemeListAsync();
        }

        public async Task AddMissionThemeAsync(UpsertMissionThemeRequestModel model)
        {
            await _missionThemeRepository.AddMissionThemeAsync(model);
            return;
        }

        public async Task<MissionThemeResponceModel?> GetMissionThemeByIdAsync(int missionThemeId)
        {
            return await _missionThemeRepository.GetMissionThemeByIdAsync(missionThemeId);
        }

        public async Task<bool> UpdateMissionThemeAsync(UpsertMissionThemeRequestModel model)
        {
            return await _missionThemeRepository.UpdateMissionThemeAsync(model);
        }

        public async Task<bool> DeleteMissionTheme(int id)
        {
            return await _missionThemeRepository.DeleteMissionTheme(id);
        }
    }
}
