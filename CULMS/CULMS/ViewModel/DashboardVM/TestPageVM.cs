using CULMS.Helpers;
using CULMS.Model;
using System;
using System.Collections.ObjectModel;

namespace CULMS.ViewModel.DashboardVM
{
    public class TestPageVM : ObservableObject
    {
		private ObservableCollection<CommonModel> detailList;

		public ObservableCollection<CommonModel> DetailList
        {
			get { return detailList; }
			set { detailList = value;OnPropertyChanged(nameof(DetailList)); }
		}
        public TestPageVM()
        {
            DetailList = GetDetailList();
        }

        private ObservableCollection<CommonModel> GetDetailList()
        {
            return new ObservableCollection<CommonModel>()
            {
                new CommonModel() {Number ="1.", Title ="Name of the PDOT", Centre1 ="Asmacs, Sakinaka", Centre2 ="Asmacs, Sakinaka"},
                new CommonModel() {Number ="2.", Title ="Address", Centre1 ="Asmacs, Sakinaka, Mumbai 403, 4th floor, Sai Plaza, Near MTNL Exchange, Opp.Ashwin kurla Road", Centre2 ="Asmacs, Sakinaka"},
                new CommonModel() {Number ="3.", Title ="Email", Centre1 ="monika@asmacs.net", Centre2 ="monika@asmacs.net"},
                new CommonModel() {Number ="1.", Title ="Name of the PDOT", Centre1 ="Asmacs, Sakinaka", Centre2 ="Asmacs, Sakinaka"},
                new CommonModel() {Number ="2.", Title ="Address", Centre1 ="Asmacs, Sakinaka, Mumbai 403, 4th floor, Sai Plaza, Near MTNL Exchange, Opp.Ashwin kurla Road", Centre2 ="Asmacs, Sakinaka"},
                new CommonModel() {Number ="3.", Title ="Email", Centre1 ="monika@asmacs.net", Centre2 ="monika@asmacs.net"},
                new CommonModel() {Number ="1.", Title ="Name of the PDOT", Centre1 ="Asmacs, Sakinaka", Centre2 ="Asmacs, Sakinaka"},
                new CommonModel() {Number ="2.", Title ="Address", Centre1 ="Asmacs, Sakinaka, Mumbai 403, 4th floor, Sai Plaza, Near MTNL Exchange, Opp.Ashwin kurla Road", Centre2 ="Asmacs, Sakinaka"},
                new CommonModel() {Number ="3.", Title ="Email", Centre1 ="monika@asmacs.net", Centre2 ="monika@asmacs.net"},
                new CommonModel() {Number ="1.", Title ="Name of the PDOT", Centre1 ="Asmacs, Sakinaka", Centre2 ="Asmacs, Sakinaka"},
                new CommonModel() {Number ="2.", Title ="Address", Centre1 ="Asmacs, Sakinaka, Mumbai 403, 4th floor, Sai Plaza, Near MTNL Exchange, Opp.Ashwin kurla Road", Centre2 ="Asmacs, Sakinaka"},
                new CommonModel() {Number ="3.", Title ="Email", Centre1 ="monika@asmacs.net", Centre2 ="monika@asmacs.net"},
            };
        }
    }
}
