﻿#pragma checksum "..\..\MenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8E4DEE76D36433C2FCF9BBB910ADF1C1D6B6CAB77EB5246A51D2549DC4829D8"
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
using cafe_management;


namespace cafe_management {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCaPheVietNam;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCaPheMay;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDaXay;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTraTraiCay;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTraSuaMacchiato;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rectCaPheVietNam;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rectCaPheMay;
        
        #line default
        #line hidden
        
        
        #line 496 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rectDaXay;
        
        #line default
        #line hidden
        
        
        #line 683 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rectTraTraiCay;
        
        #line default
        #line hidden
        
        
        #line 866 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rectTraSuaMacchiato;
        
        #line default
        #line hidden
        
        
        #line 1103 "..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCoffee;
        
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
            System.Uri resourceLocater = new System.Uri("/cafe_management;component/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuWindow.xaml"
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
            this.btnCaPheVietNam = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MenuWindow.xaml"
            this.btnCaPheVietNam.Click += new System.Windows.RoutedEventHandler(this.CaPheVietNam_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCaPheMay = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\MenuWindow.xaml"
            this.btnCaPheMay.Click += new System.Windows.RoutedEventHandler(this.CaPheMay_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDaXay = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\MenuWindow.xaml"
            this.btnDaXay.Click += new System.Windows.RoutedEventHandler(this.DaXay_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnTraTraiCay = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\MenuWindow.xaml"
            this.btnTraTraiCay.Click += new System.Windows.RoutedEventHandler(this.TraTraiCay_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnTraSuaMacchiato = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\MenuWindow.xaml"
            this.btnTraSuaMacchiato.Click += new System.Windows.RoutedEventHandler(this.TraSuaMacchiato_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 7:
            this.rectCaPheVietNam = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.rectCaPheMay = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.rectDaXay = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.rectTraTraiCay = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.rectTraSuaMacchiato = ((System.Windows.Controls.Grid)(target));
            return;
            case 12:
            this.dgCoffee = ((System.Windows.Controls.DataGrid)(target));
            
            #line 1106 "..\..\MenuWindow.xaml"
            this.dgCoffee.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgCoffee_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

