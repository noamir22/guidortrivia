﻿#pragma checksum "..\..\..\JoinRoom.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "946D1F9F32F4267249B00660A99EA7F31646AB3C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
    /// JoinRoom
    /// </summary>
    public partial class JoinRoom : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 244 "..\..\..\JoinRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rectangle;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\JoinRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard Sb;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\..\JoinRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label magshitrivia;
        
        #line default
        #line hidden
        
        
        #line 285 "..\..\..\JoinRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button joinRoom;
        
        #line default
        #line hidden
        
        
        #line 287 "..\..\..\JoinRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 289 "..\..\..\JoinRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 291 "..\..\..\JoinRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RoomsList;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp5;component/joinroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\JoinRoom.xaml"
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
            this.joinRoom = ((System.Windows.Controls.Button)(target));
            
            #line 286 "..\..\..\JoinRoom.xaml"
            this.joinRoom.Click += new System.Windows.RoutedEventHandler(this.Join_Room_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 288 "..\..\..\JoinRoom.xaml"
            this.Refresh.Click += new System.Windows.RoutedEventHandler(this.Refresh_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 290 "..\..\..\JoinRoom.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RoomsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 291 "..\..\..\JoinRoom.xaml"
            this.RoomsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Check_Choosing_Room);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

