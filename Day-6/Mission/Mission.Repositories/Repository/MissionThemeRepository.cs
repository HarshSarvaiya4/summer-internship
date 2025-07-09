using Microsoft.EntityFrameworkCore;
using Mission.Entities;
using Mission.Entities.Models;
using Mission.Entities.ViewModels.MissionSkill;
using Mission.Entities.ViewModels.MissionTheme;
using Mission.Repositories.IRepository;
using System.Threading.Tasks;

namespace Mission.Repositories.Repository
{
    public class MissionThemeRepository(MissionDbContext dbContext) : IMissionThemeRepository
    {
        private readonly MissionDbContext _dbContext = dbContext;

        public async Task<List<MissionThemeResponceModel>> GetMissionThemeListAsync()
        {
            return await _dbContext.MissionThemes
                .Select(x => new MissionThemeResponceModel
                {
                    Id = x.Id,
                    ThemeName = x.ThemeName,
                    Status = x.Status

                }).ToListAsync();
        }

        public async Task AddMissionThemeAsync(UpsertMissionThemeRequestModel model)
        {
            var missionTheme = new MissionTheme()
            {
                ThemeName = model.ThemeName,
                Status = model.Status,
            };
            _dbContext.MissionThemes.Add(missionTheme);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<MissionThemeResponceModel?> GetMissionThemeByIdAsync(int missionThemeId)
        {
            var MissionTheme = await _dbContext.MissionThemes.FindAsync(missionThemeId);

            if (MissionTheme == null)
                return null;

            return new MissionThemeResponceModel(MissionTheme);
        }

        public async Task<bool> UpdateMissionThemeAsync(UpsertMissionThemeRequestModel model)
        {
            var missionTheme = _dbContext.MissionThemes.Find(model.Id);

            if(missionTheme == null)
                return false;

            missionTheme.ThemeName = model.ThemeName;
            missionTheme.Status = model.Status;

            _dbContext.MissionThemes.Update(missionTheme);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteMissionTheme(int id)
        {
            var missionTheme = await _dbContext.MissionThemes.FindAsync(id);
            if (missionTheme == null)
                return false;
            _dbContext.MissionThemes.Remove(missionTheme);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }

}
