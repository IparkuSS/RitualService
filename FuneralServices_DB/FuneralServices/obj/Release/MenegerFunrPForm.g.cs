﻿#pragma checksum "..\..\MenegerFunrPForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C10905A40F606C17B9B1FD481FFA3B851EB36032E8B9028D46944686AD3C827"
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
    /// MenegerFunrPForm
    /// </summary>
    public partial class MenegerFunrPForm : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 33 "..\..\MenegerFunrPForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Grid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MenegerFunrPForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn TwoDatColumns;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MenegerFunrPForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn TwoDatColumnDat;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MenegerFunrPForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
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
            System.Uri resourceLocater = new System.Uri("/FuneralServices;component/menegerfunrpform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenegerFunrPForm.xaml"
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
            this.Grid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.TwoDatColumns = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 4:
            this.TwoDatColumnDat = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 6:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 70 "..\..\MenegerFunrPForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Faind_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 76 "..\..\MenegerFunrPForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 82 "..\..\MenegerFunrPForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Work);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 88 "..\..\MenegerFunrPForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 94 "..\..\MenegerFunrPForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 45 "..\..\MenegerFunrPForm.xaml"
            ((System.Windows.Controls.ComboBox)(target)).DropDownOpened += new System.EventHandler(this.comboBox1_DropDownOpened);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MenegerFunrPForm.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectedCof);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MenegerFunrPForm.xaml"
            ((System.Windows.Controls.ComboBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.myCmb_LoadedCof);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 53 "..\..\MenegerFunrPForm.xaml"
            ((MaterialDesignThemes.Wpf.TimePicker)(target)).SelectedTimeChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.DateTime>>(this.sd);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
