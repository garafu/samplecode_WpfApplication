namespace WpfApplication.ViewModels
{
    using WpfApplication.Commands;
    using WpfApplication.Models;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.OpenMessageDialogCommand = new OpenMessageDialogCommand();
            this.UserModel = new UserModel();
        }

        public OpenMessageDialogCommand OpenMessageDialogCommand { get; set; }

        public UserModel UserModel { get; set; }
    }
}
