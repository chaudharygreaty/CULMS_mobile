using CULMS.Helpers;
using CULMS.Model;
using System;
using System.Collections.ObjectModel;

namespace CULMS.ViewModel.DashboardVM
{
    public class AllCoursePageVM : ObservableObject
    {
        #region Private Properties

        private ObservableCollection<CommonModel> allCourseList;
        #endregion

        #region Public Properties

        public ObservableCollection<CommonModel> AllCourseList
        {
            get { return allCourseList; }
            set { allCourseList = value; OnPropertyChanged(nameof(AllCourseList)); }
        }

        #endregion

        #region Methods

        public AllCoursePageVM()
        {
            AllCourseList = GetAllCourseList();
        }

        private ObservableCollection<CommonModel> GetAllCourseList()
        {
            return new ObservableCollection<CommonModel>()
            {
                new CommonModel() {CourseName = "CodeMash Conference 2020"},
                new CommonModel() {CourseName = "THAT Conference 2019"},
                new CommonModel() {CourseName = "Microsoft Azure + AI Conference 2019"},
                new CommonModel() {CourseName = "ng-conf 2021"},
                new CommonModel() {CourseName = "JavaScript and Friends"},
                new CommonModel() {CourseName = "CodeMash Conference 2020"},
                new CommonModel() {CourseName = "THAT Conference 2019"},
                new CommonModel() {CourseName = "Microsoft Azure + AI Conference 2019"},
                new CommonModel() {CourseName = "ng-conf 2021"},
                new CommonModel() {CourseName = "JavaScript and Friends"},
            };
        }
        #endregion

        #region Commands

        #endregion
    }
}
