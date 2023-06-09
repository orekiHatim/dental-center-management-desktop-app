﻿#pragma checksum "..\..\..\Windows\DoctorsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C552928B17A886B38B63863FAD6776C0E565B9598665C30F2615F46ABAF8E1A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cabinet.Windows;
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


namespace Cabinet.Windows {
    
    
    /// <summary>
    /// DoctorsWindow
    /// </summary>
    public partial class DoctorsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button patientsBtn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button appointmentsWindow;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutBtn;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmDeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteBtn;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateBtn;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Windows\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid doctorsDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Cabinet;component/windows/doctorswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\DoctorsWindow.xaml"
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
            this.patientsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Windows\DoctorsWindow.xaml"
            this.patientsBtn.Click += new System.Windows.RoutedEventHandler(this.patientsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.appointmentsWindow = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Windows\DoctorsWindow.xaml"
            this.appointmentsWindow.Click += new System.Windows.RoutedEventHandler(this.appointmentsWindow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logoutBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 87 "..\..\..\Windows\DoctorsWindow.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.confirmDeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\Windows\DoctorsWindow.xaml"
            this.confirmDeleteBtn.Click += new System.Windows.RoutedEventHandler(this.confirmDeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.deleteBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\Windows\DoctorsWindow.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.updateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\Windows\DoctorsWindow.xaml"
            this.updateBtn.Click += new System.Windows.RoutedEventHandler(this.updateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.doctorsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 134 "..\..\..\Windows\DoctorsWindow.xaml"
            this.doctorsDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.doctorsDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

