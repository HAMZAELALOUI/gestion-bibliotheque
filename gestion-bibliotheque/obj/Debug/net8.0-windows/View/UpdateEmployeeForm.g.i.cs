﻿#pragma checksum "..\..\..\..\View\UpdateEmployeeForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79717D7EB7D878CA5BB36F50DD43728F998766AB"
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
using System.Windows.Controls.Ribbon;
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
using gestion_bibliotheque.View;


namespace gestion_bibliotheque.View {
    
    
    /// <summary>
    /// UpdateEmployeeForm
    /// </summary>
    public partial class UpdateEmployeeForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 99 "..\..\..\..\View\UpdateEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNom;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\View\UpdateEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrenom;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\View\UpdateEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMetier;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\View\UpdateEmployeeForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/gestion-bibliotheque;component/view/updateemployeeform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UpdateEmployeeForm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 90 "..\..\..\..\View\UpdateEmployeeForm.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 93 "..\..\..\..\View\UpdateEmployeeForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.close_form);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtNom = ((System.Windows.Controls.TextBox)(target));
            
            #line 99 "..\..\..\..\View\UpdateEmployeeForm.xaml"
            this.txtNom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtPrenom = ((System.Windows.Controls.TextBox)(target));
            
            #line 100 "..\..\..\..\View\UpdateEmployeeForm.xaml"
            this.txtPrenom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtMetier = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\..\..\View\UpdateEmployeeForm.xaml"
            this.txtMetier.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\..\..\View\UpdateEmployeeForm.xaml"
            this.txtDescription.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 104 "..\..\..\..\View\UpdateEmployeeForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Modifier);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

