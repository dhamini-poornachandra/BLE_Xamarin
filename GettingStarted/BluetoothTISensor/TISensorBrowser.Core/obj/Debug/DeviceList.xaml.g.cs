// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TISensorBrowser {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class DeviceList : ContentPage {
        
        private ToolbarItem ScanAllButton;
        
        private ListView listView;
        
        private Frame InfoFrame;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(DeviceList));
            ScanAllButton = this.FindByName <ToolbarItem>("ScanAllButton");
            listView = this.FindByName <ListView>("listView");
            InfoFrame = this.FindByName <Frame>("InfoFrame");
        }
    }
}
