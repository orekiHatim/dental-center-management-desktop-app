﻿#pragma checksum "..\..\..\..\Windows\Appointments\addAppointment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0602FEDA238D14EA718BF11E7A76CA51AD016F802113FD9254DBDB37E6B690E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cabinet.Windows.Appointments;
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


namespace Cabinet.Windows.Appointments {
    
    
    /// <summary>
    /// addAppointment
    /// </summary>
    public partial class addAppointment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox doctorsList;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox patientsList;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateInput;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker timeInput;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel formError;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon iconError;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textError;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Cabinet;component/windows/appointments/addappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
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
            
            #line 28 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.close);
            
            #line default
            #line hidden
            return;
            case 2:
            this.doctorsList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.patientsList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.dateInput = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.timeInput = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 6:
            this.formError = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.iconError = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 8:
            this.textError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\Windows\Appointments\addAppointment.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.submit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

