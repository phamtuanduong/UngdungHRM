﻿#pragma checksum "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1928414FD7D158B4A9A0483E25DC7B0BA217B20D13B43F085F4F79602A8FF1BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using UngdungHRM.NewControls;


namespace UngdungHRM.NewControls {
    
    
    /// <summary>
    /// quanlinhanvien_controlItem
    /// </summary>
    public partial class quanlinhanvien_controlItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander expander;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost dialogHost;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid dialogHostControl;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid controls;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid controlEdit;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Mess;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/UngdungHRM;component/newcontrols/quanlinhanvien_controlitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.expander = ((System.Windows.Controls.Expander)(target));
            return;
            case 2:
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 57 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
            this.scrollViewer.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.TS_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 67 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnNhanvienList_Click);
            
            #line default
            #line hidden
            
            #line 68 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
            ((System.Windows.Controls.Button)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 104 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnNhanvienReportList_Click);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\NewControls\quanlinhanvien_controlItem.xaml"
            ((System.Windows.Controls.Button)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Button1_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dialogHost = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 6:
            this.dialogHostControl = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.controls = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.controlEdit = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.Mess = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            this.txtMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

