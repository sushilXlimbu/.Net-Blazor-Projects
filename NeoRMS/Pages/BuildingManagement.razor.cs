using Microsoft.AspNetCore.Components;

namespace NeoRMS.Pages
{
    public class BuildingManagementBase:ComponentBase
    {
        [Parameter]
        public string LogNo { get; set; }

        [Parameter]
        public string _activeTab { get; set; }

        public string activeTab = "detailTab";

        public int blockNo { get; set; }



        protected void changeBlock(ChangeEventArgs e)
        {
            blockNo = int.Parse(e.Value.ToString());
        }

        
        public void setActiveClass(string tabId)
        {
            activeTab = tabId;
        }
        public string GetTabHeadClass(string tabId)
        {
            if (tabId == activeTab)
            {
                return "nav-link active";
            }
            else
            {
                return "nav-link";
            }
        }

        public string GetTabBtnClass(string tabId)
        {
            if (tabId == activeTab)
            {
                return "addTabButton";
            }
            else
            {
                return "removeTabButton";
            }
        }
        public string GetActiveClass(string tabId)
        {
            if (tabId == activeTab)
            {
                return "active";
            }
            else
            {
                return "";
            }
        }

    }
}
