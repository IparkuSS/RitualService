﻿#pragma checksum "..\..\..\AllAccess\RegForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA35A6B446D01D79F2F12C0D3FBEA6370D8FDC1CB726FDDFD08E36EF2CF90066"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FuneralServices;
using MahApps.Metro.IconPacks;
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


namespace FuneralServices {
    
    
    /// <summary>
    /// RegForm
    /// </summary>
    public partial class RegForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\AllAccess\RegForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\AllAccess\RegForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameF;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\AllAccess\RegForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurNameF;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\AllAccess\RegForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pass;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\AllAccess\RegForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassReb;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\AllAccess\RegForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Comb;
        
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
            System.Uri resourceLocater = new System.Uri("/FuneralServices;component/allaccess/regform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AllAccess\RegForm.xaml"
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
            
            #line 10 "..\..\..\AllAccess\RegForm.xaml"
            ((FuneralServices.RegForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.nameF = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SurNameF = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Pass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.PassReb = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.Comb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 185 "..\..\..\AllAccess\RegForm.xaml"
            this.Comb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_Selected);
            
            #line default
            #line hidden
            
            #line 186 "..\..\..\AllAccess\RegForm.xaml"
            this.Comb.Loaded += new System.Windows.RoutedEventHandler(this.myCmb_Loaded);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 204 "..\..\..\AllAccess\RegForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.regButton);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 209 "..\..\..\AllAccess\RegForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Buton_ToCom);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

