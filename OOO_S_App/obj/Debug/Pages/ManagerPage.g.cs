﻿#pragma checksum "..\..\..\Pages\ManagerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "52841D2204EB37A733DCA2479B92DC25A1B9FF25FDDC1365828C7D4FC3753865"
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
    /// ManagerPage
    /// </summary>
    public partial class ManagerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBP;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBS;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBBEB;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVTovar;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbFamil;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbImya;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbOtchestvo;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Pages\ManagerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zakaz;
        
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
            System.Uri resourceLocater = new System.Uri("/OOO_S_App;component/pages/managerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ManagerPage.xaml"
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
            
            #line 9 "..\..\..\Pages\ManagerPage.xaml"
            ((OOO_S_App.Pages.ManagerPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBP = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Pages\ManagerPage.xaml"
            this.TBP.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBP_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CBS = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\Pages\ManagerPage.xaml"
            this.CBS.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBS_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CBBEB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\Pages\ManagerPage.xaml"
            this.CBBEB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBBEB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LVTovar = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.TbFamil = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TbImya = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.TbOtchestvo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\Pages\ManagerPage.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.zakaz = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\Pages\ManagerPage.xaml"
            this.zakaz.Click += new System.Windows.RoutedEventHandler(this.zakaz_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

