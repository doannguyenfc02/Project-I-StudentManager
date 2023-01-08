using System.Data;

namespace Project_I.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    public sealed partial class User2 {
        
        public User2() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        public User2(string fullname, string username, string password, string type)
        {
            this.fullname = fullname;
            this.username = username;
            this.password = password;
            this.type = type;
        }
        public User2(DataRow rows)
        {
            this.fullname = rows[0].ToString();
            this.username = rows[1].ToString();
            this.password = rows[2].ToString();
            this.type = rows[3].ToString();
        }
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }
    }
}
