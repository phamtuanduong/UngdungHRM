﻿#pragma checksum "..\..\..\..\DialogHostControlQ\dialogHost_e_QWorkExperience.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF70E06AED6A869B596BDF3241380E84AA881C99BF8BF88A08ACB8B93E5B3675"
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
    /// dialogHost_e_QWorkExperience
    /// </summary>
    public partial class dialogHost_e_QWorkExperience : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 84 "..\..\..\..\DialogHostControlQ\dialogHost_e_QWorkExperience.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTen;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\DialogHostControlQ\dialogHost_e_QWorkExperience.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateStart;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\DialogHostControlQ\dialogHost_e_QWorkExperience.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateEnd;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\DialogHostControlQ\dialogHost_e_QWorkExperience.xaml"
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
            System.Uri resourceLocater = new System.Uri("/UngdungHRM;component/dialoghostcontrolq/dialoghost_e_qworkexperience.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\DialogHostControlQ\dialogHost_e_QWorkExperience.xaml"
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
            this.txtTen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.dateStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.dateEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.btnSaveCur = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\..\..\DialogHostControlQ\dialogHost_e_QWorkExperience.xaml"
            this.btnSaveCur.Click += new System.Windows.RoutedEventHandler(this.btnSaveCur_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 164 "..\..\..\..\DialogHostControlQ\dialogHost_e_QWorkExperience.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHuyB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

