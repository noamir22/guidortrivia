#pragma checksum "..\..\..\Menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C72BF8A28F6595BE9A41BB5C1A5FD46A7E7B2B45"
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
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 196 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rectangle;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard Sb;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label magshitrivia;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button JoinRoom;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MyStatus;
        
        #line default
        #line hidden
        
        
        #line 241 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Quit;
        
        #line default
        #line hidden
        
        
        #line 243 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateRoom;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BestScore;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Avatar;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageAvatar;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement Gif;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Frame1;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp5;V1.0.0.0;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Menu.xaml"
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
            this.Rectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 2:
            this.Sb = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 3:
            this.magshitrivia = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.JoinRoom = ((System.Windows.Controls.Button)(target));
            
            #line 238 "..\..\..\Menu.xaml"
            this.JoinRoom.Click += new System.Windows.RoutedEventHandler(this.Join_Room_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MyStatus = ((System.Windows.Controls.Button)(target));
            
            #line 240 "..\..\..\Menu.xaml"
            this.MyStatus.Click += new System.Windows.RoutedEventHandler(this.My_Status_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Quit = ((System.Windows.Controls.Button)(target));
            
            #line 242 "..\..\..\Menu.xaml"
            this.Quit.Click += new System.Windows.RoutedEventHandler(this.Quit_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CreateRoom = ((System.Windows.Controls.Button)(target));
            
            #line 244 "..\..\..\Menu.xaml"
            this.CreateRoom.Click += new System.Windows.RoutedEventHandler(this.Create_Room_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BestScore = ((System.Windows.Controls.Button)(target));
            
            #line 246 "..\..\..\Menu.xaml"
            this.BestScore.Click += new System.Windows.RoutedEventHandler(this.Best_Score_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Avatar = ((System.Windows.Controls.Button)(target));
            
            #line 248 "..\..\..\Menu.xaml"
            this.Avatar.Click += new System.Windows.RoutedEventHandler(this.Avatar_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ImageAvatar = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.Gif = ((System.Windows.Controls.MediaElement)(target));
            
            #line 250 "..\..\..\Menu.xaml"
            this.Gif.MediaEnded += new System.Windows.RoutedEventHandler(this.gif_MediaEnded);
            
            #line default
            #line hidden
            
            #line 250 "..\..\..\Menu.xaml"
            this.Gif.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Radio_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Frame1 = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

