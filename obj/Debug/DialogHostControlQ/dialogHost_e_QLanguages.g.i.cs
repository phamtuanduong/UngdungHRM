﻿#pragma checksum "..\..\..\DialogHostControlQ\dialogHost_e_QLanguages.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CAEA2173BA310D436547229F5EFF14893A605A2D2585F44E8F87FDAE3521D517"
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
using UngdungHRM.DialogHostControlQ;


namespace UngdungHRM.DialogHostControlQ {
    
    
    /// <summary>
    /// dialogHost_e_QLanguages
    /// </summary>
    public partial class dialogHost_e_QLanguages : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 77 "..\..\..\DialogHostControlQ\dialogHost_e_QLanguages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbChucVu;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\DialogHostControlQ\dialogHost_e_QLanguages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKyNang;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\DialogHostControlQ\dialogHost_e_QLanguages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTrinhDo;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\DialogHostControlQ\dialogHost_e_QLanguages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveCur;
        
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
            System.Uri resourceLocater = new System.Uri("/UngdungHRM;component/dialoghostcontrolq/dialoghost_e_qlanguages.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogHostControlQ\dialogHost_e_QLanguages.xaml"
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
            this.cbChucVu = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cbKyNang = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cbTrinhDo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.btnSaveCur = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\..\DialogHostControlQ\dialogHost_e_QLanguages.xaml"
            this.btnSaveCur.Click += new System.Windows.RoutedEventHandler(this.btnSaveCur_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 148 "..\..\..\DialogHostControlQ\dialogHost_e_QLanguages.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHuyB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

