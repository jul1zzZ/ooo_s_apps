﻿#pragma checksum "..\..\..\Pages\ZakazPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "082A64B3A04979E5F155D5DD62A09426A964A043B0E60902B587906C55919657"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OOO_S_App.Pages;
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


namespace OOO_S_App.Pages {
    
    
    /// <summary>
    /// ZakazPage
    /// </summary>
    public partial class ZakazPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 17 "..\..\..\Pages\ZakazPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Zakaz;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\ZakazPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addzakaz;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\ZakazPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deletezakaz;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\ZakazPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/OOO_S_App;component/pages/zakazpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ZakazPage.xaml"
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
            
            #line 9 "..\..\..\Pages\ZakazPage.xaml"
            ((OOO_S_App.Pages.ZakazPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Zakaz = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\Pages\ZakazPage.xaml"
            this.Zakaz.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.Zakaz_LoadingRow);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\Pages\ZakazPage.xaml"
            this.Zakaz.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Zakaz_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addzakaz = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\ZakazPage.xaml"
            this.addzakaz.Click += new System.Windows.RoutedEventHandler(this.addzakaz_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.deletezakaz = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\ZakazPage.xaml"
            this.deletezakaz.Click += new System.Windows.RoutedEventHandler(this.deletezakaz_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\ZakazPage.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
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
            
            #line 32 "..\..\..\Pages\ZakazPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

