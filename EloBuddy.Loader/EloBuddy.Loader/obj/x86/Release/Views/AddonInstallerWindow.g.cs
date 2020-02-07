﻿#pragma checksum "..\..\..\..\Views\AddonInstallerWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "40967A03F72C8692E0C97BB79A4DB35A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EloBuddy.Loader.Controls;
using EloBuddy.Loader.Converter;
using EloBuddy.Loader.Globals;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace EloBuddy.Loader.Views {
    
    
    /// <summary>
    /// AddonInstallerWindow
    /// </summary>
    public partial class AddonInstallerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Views\AddonInstallerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\AddonInstallerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton LocalAddonRadiobutton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\AddonInstallerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LocalAddonTextBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\AddonInstallerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RemoteAddonRadiobutton;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\AddonInstallerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RemoteAddonTextbox;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Views\AddonInstallerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InstallButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EloBuddy.Loader;component/views/addoninstallerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 5 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            ((EloBuddy.Loader.Views.AddonInstallerWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 6 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            ((EloBuddy.Loader.Views.AddonInstallerWindow)(target)).ContentRendered += new System.EventHandler(this.Window_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LocalAddonRadiobutton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            
            #line 66 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LocalAddonTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            this.LocalAddonTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.LocalAddonTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RemoteAddonRadiobutton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.RemoteAddonTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            this.RemoteAddonTextbox.GotFocus += new System.Windows.RoutedEventHandler(this.RemoteAddonTextbox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 91 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.InstallButton = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\Views\AddonInstallerWindow.xaml"
            this.InstallButton.Click += new System.Windows.RoutedEventHandler(this.InstallButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

