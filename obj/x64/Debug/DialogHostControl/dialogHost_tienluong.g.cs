﻿#pragma checksum "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B304BAA5EDED0EBA964137985BEA941576547C91E2E81E2EC1C6D7EC86AEB43"
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
using UngdungHRM.DialogHostControl;


namespace UngdungHRM.DialogHostControl {
    
    
    /// <summary>
    /// dialogHost_tienluong
    /// </summary>
    public partial class dialogHost_tienluong : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid controlThemTiente;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtInfo;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbQuocgia;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTS;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTiente;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
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
            System.Uri resourceLocater = new System.Uri("/UngdungHRM;component/dialoghostcontrol/dialoghost_tienluong.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
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
            this.controlThemTiente = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.cbQuocgia = ((System.Windows.Controls.ComboBox)(target));
            
            #line 97 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
            this.cbQuocgia.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbQuocgia_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbTS = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbTiente = ((System.Windows.Controls.ComboBox)(target));
            
            #line 143 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
            this.cbTiente.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbTiente_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSaveCur = ((System.Windows.Controls.Button)(target));
            
            #line 171 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
            this.btnSaveCur.Click += new System.Windows.RoutedEventHandler(this.btnSaveCur_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 185 "..\..\..\..\DialogHostControl\dialogHost_tienluong.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHuyB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

