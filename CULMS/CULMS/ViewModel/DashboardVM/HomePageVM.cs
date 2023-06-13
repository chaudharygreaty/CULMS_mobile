using CULMS.Helpers;
using CULMS.Model;
using CULMS.View.Auth;
using CULMS.View.Dashboard;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CULMS.ViewModel.DashboardVM
{
    public class HomePageVM : ObservableObject
    {
        #region Private Properties

        private ObservableCollection<CommonModel> courcesList;
        private ObservableCollection<CommonModel> popularSkillsList;
        private ObservableCollection<CommonModel> pathList;
        #endregion

        #region Public Properties


        public ObservableCollection<CommonModel> PathList
        {
            get { return pathList; }
            set { pathList = value; OnPropertyChanged(nameof(PathList)); }
        }

        public ObservableCollection<CommonModel> PopularSkillsList
        {
            get { return popularSkillsList; }
            set { popularSkillsList = value; OnPropertyChanged(nameof(PopularSkillsList)); }
        }


        public ObservableCollection<CommonModel> CourcesList
        {
            get { return courcesList; }
            set { courcesList = value; OnPropertyChanged(nameof(CourcesList)); }
        }

        #endregion

        #region Methods

        public HomePageVM()
        {
            PopularSkillsList = GetPopularSkillsList();
            CourcesList = GetCourcesList();
            PathList = GetPathList();
        }

        private ObservableCollection<CommonModel> GetPathList()
        {
            return new ObservableCollection<CommonModel>()
            {
                new CommonModel() {CourseImage = "googlecloud"},
                new CommonModel() {CourseImage = "googlecloud"},
                new CommonModel() {CourseImage = "googlecloud"},
                new CommonModel() {CourseImage = "googlecloud"},
                new CommonModel() {CourseImage = "googlecloud"},
                new CommonModel() {CourseImage = "googlecloud"},
                new CommonModel() {CourseImage = "googlecloud"},
            };
        }

        private ObservableCollection<CommonModel> GetCourcesList()
        {
            return new ObservableCollection<CommonModel>()
            {
                new CommonModel {CourseImage ="course3", CourseName ="CONFERENCES"},
                new CommonModel {CourseImage ="course4", CourseName ="CERTIFICATIONS"},
                new CommonModel {CourseImage ="course5", CourseName ="DATA"},
                new CommonModel {CourseImage ="course6", CourseName ="BUSINESS"},
                new CommonModel {CourseImage ="course7", CourseName ="DEVELOPEMENT"},
                new CommonModel {CourseImage ="course1", CourseName ="IT"},
                new CommonModel {CourseImage ="course2", CourseName ="DESIGN"},
                new CommonModel {CourseImage ="course3", CourseName ="CREATIVE"},
                new CommonModel {CourseImage ="course4", CourseName ="CYBER SECURITY"},
                new CommonModel {CourseImage ="course5", CourseName ="CONFERENCES"},
            };
        }

        private ObservableCollection<CommonModel> GetPopularSkillsList()
        {
            return new ObservableCollection<CommonModel>()
            {
                new CommonModel {Skills = "MBA"},
                new CommonModel {Skills = "B.Tech"},
                new CommonModel {Skills = "Hotel Management"},
                new CommonModel {Skills = "Animaton and Design"},
                new CommonModel {Skills = "Arts"},
                new CommonModel {Skills = "Commerce"},
                new CommonModel {Skills = "Computer Applications and IT"},
                new CommonModel {Skills = "Education"},
                new CommonModel {Skills = "Law"},
                new CommonModel {Skills = "Pharmacy"},
                new CommonModel {Skills = "Media"},
            };
        }
        #endregion

        #region Commands

        public Command NewCourseCommand => new Command(() =>
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new NewCoursesPage());
        });
        public Command LogoutCommand => new Command(async() =>
        {
            IsLoading = true;
            await Task.Delay(50);
            Application.Current.MainPage = new LoginPage();
            Preferences.Set(StringConstant.IsLogin, false);
            IsLoading = false;
        });

        public Command AllCourseCommand => new Command(async () =>
        {
            try
            {
                IsLoading = true;
                await Application.Current.MainPage.Navigation.PushModalAsync(new AllCoursePage());
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
            finally
            {
                IsLoading = false;
            }
        });
        #endregion
    }
}
