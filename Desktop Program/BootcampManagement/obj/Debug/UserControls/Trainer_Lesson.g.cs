﻿#pragma checksum "..\..\..\UserControls\Trainer_Lesson.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6EDD738D11DB52B07B91F3E7F90786D18475C49E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BootcampManagement.UserControls;
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


namespace BootcampManagement.UserControls {
    
    
    /// <summary>
    /// Trainer_Lesson
    /// </summary>
    public partial class Trainer_Lesson : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UserControls\Trainer_Lesson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Id_Tbox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UserControls\Trainer_Lesson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title_Tbox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UserControls\Trainer_Lesson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description_Tbox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\UserControls\Trainer_Lesson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Date_Dpc;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UserControls\Trainer_Lesson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Insert_Btn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UserControls\Trainer_Lesson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update_Btn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UserControls\Trainer_Lesson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_Btn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UserControls\Trainer_Lesson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Lesson_DataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/BootcampManagement;component/usercontrols/trainer_lesson.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\Trainer_Lesson.xaml"
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
            this.Id_Tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Title_Tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Description_Tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Date_Dpc = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Insert_Btn = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Update_Btn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Delete_Btn = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Lesson_DataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

