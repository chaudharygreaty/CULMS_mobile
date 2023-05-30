﻿using CULMS.Helpers;
using CULMS.Model;
using System;
using System.Collections.ObjectModel;

namespace CULMS.ViewModel.DashboardVM
{
    public class NewCoursesVM : ObservableObject
    {
        #region Private Properties

        private ObservableCollection<CommonModel> newCoursesList;
        #endregion

        #region Public Properties


        public ObservableCollection<CommonModel> NewCoursesList
        {
            get { return newCoursesList; }
            set { newCoursesList = value; OnPropertyChanged(nameof(NewCoursesList)); }
        }

        #endregion

        #region Methods

        public NewCoursesVM()
        {
            NewCoursesList = GetNewCoursesList();
        }

        private ObservableCollection<CommonModel> GetNewCoursesList()
        {
            return new ObservableCollection<CommonModel>()
            {
                new CommonModel {CourseImage ="Animation", CourseName="Animation"},
                new CommonModel {CourseImage ="B_Tech", CourseName="B.Tech"},
                new CommonModel {CourseImage ="commerce", CourseName="Commerce"},
                new CommonModel {CourseImage ="mba", CourseName="MBA"},
                new CommonModel {CourseImage ="Animation", CourseName="Animation"},
                new CommonModel {CourseImage ="B_Tech", CourseName="B.Tech"},
                new CommonModel {CourseImage ="commerce", CourseName="Commerce"},
                new CommonModel {CourseImage ="mba", CourseName="MBA"},
            };
        }
        #endregion

        #region Commands

        #endregion
    }
}