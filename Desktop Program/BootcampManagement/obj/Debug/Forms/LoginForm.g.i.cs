﻿#pragma checksum "..\..\..\Forms\LoginForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E1F3A76094490BEF88E05E62A001B5530EA6780"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BootcampManagement;
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


namespace BootcampManagement {
    
    
    /// <summary>
    /// LoginForm
    /// </summary>
    public partial class LoginForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Forms\LoginForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ___BootcampManagement_component_LoginImage_png;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Forms\LoginForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close_Btn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Forms\LoginForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ___BootcampManagement_component_user_png;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Forms\LoginForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameLogin_Tbox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Forms\LoginForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordLogin_Pbox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Forms\LoginForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Register_Btn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Forms\LoginForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login_Btn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Forms\LoginForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ForgotPassword_Txt;
        
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
            System.Uri resourceLocater = new System.Uri("/BootcampManagement;component/forms/loginform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\LoginForm.xaml"
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
            
            #line 10 "..\..\..\Forms\LoginForm.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.___BootcampManagement_component_LoginImage_png = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Close_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Forms\LoginForm.xaml"
            this.Close_Btn.Click += new System.Windows.RoutedEventHandler(this.Close_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.___BootcampManagement_component_user_png = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.UsernameLogin_Tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PasswordLogin_Pbox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.Register_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Forms\LoginForm.xaml"
            this.Register_Btn.Click += new System.Windows.RoutedEventHandler(this.Register_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Login_Btn = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.ForgotPassword_Txt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 38 "..\..\..\Forms\LoginForm.xaml"
            this.ForgotPassword_Txt.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ForgotPassword_Txt_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

