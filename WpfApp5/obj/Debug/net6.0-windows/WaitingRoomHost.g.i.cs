#pragma checksum "..\..\..\WaitingRoomHost.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5594D6504962355D2DE0C5E535BEDDDA9A25E0D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfApp5;


namespace WpfApp5 {
    
    
    /// <summary>
    /// WaitingRoomHost
    /// </summary>
    public partial class WaitingRoomHost : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 244 "..\..\..\WaitingRoomHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangle;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\..\WaitingRoomHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label magshitrivia;
        
        #line default
        #line hidden
        
        
        #line 285 "..\..\..\WaitingRoomHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Quit;
        
        #line default
        #line hidden
        
        
        #line 287 "..\..\..\WaitingRoomHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RoomsList;
        
        #line default
        #line hidden
        
        
        #line 295 "..\..\..\WaitingRoomHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label magshitrivia_Copy;
        
        #line default
        #line hidden
        
        
        #line 305 "..\..\..\WaitingRoomHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button start;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\..\WaitingRoomHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;
        
        #line default
        #line hidden
        
        
        #line 309 "..\..\..\WaitingRoomHost.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement Gif;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp5;V1.0.0.0;component/waitingroomhost.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WaitingRoomHost.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 2:
            this.magshitrivia = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Quit = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.RoomsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 287 "..\..\..\WaitingRoomHost.xaml"
            this.RoomsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Check_Choosing_Room);
            
            #line default
            #line hidden
            return;
            case 5:
            this.magshitrivia_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.start = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.close = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Gif = ((System.Windows.Controls.MediaElement)(target));
            
            #line 309 "..\..\..\WaitingRoomHost.xaml"
            this.Gif.MediaEnded += new System.Windows.RoutedEventHandler(this.gif_MediaEnded);
            
            #line default
            #line hidden
            
            #line 309 "..\..\..\WaitingRoomHost.xaml"
            this.Gif.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Radio_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

