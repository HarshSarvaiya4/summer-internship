namespace Mission.Entities.ViewModels.MissionTheme
{
    public class MissionThemeResponceModel : UpsertMissionThemeRequestModel
    {
        public MissionThemeResponceModel() { }
        public MissionThemeResponceModel(Models.MissionTheme missionTheme)
        {
            Id = missionTheme.Id;
            ThemeName = missionTheme.ThemeName;
            Status = missionTheme.Status;
        }
    }
    
}
