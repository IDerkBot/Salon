#pragma checksum "..\..\..\UserEditPages\AddReception.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "476811181C469E09FB8DD71F9165F6A896A3A4FBB61114B99FC4155ECDC3C097"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SalonApp.UserEditPages {
    
    
    /// <summary>
    /// AddReception
    /// </summary>
    public partial class AddReception : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MasterCB;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Client;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Date;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Time;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ServiceCB;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductCB;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Discount;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SumL;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InReception;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UserEditPages\AddReception.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/SalonApp;component/usereditpages/addreception.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserEditPages\AddReception.xaml"
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
            this.MasterCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\UserEditPages\AddReception.xaml"
            this.MasterCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MasterCB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Client = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Date = ((System.Windows.Controls.DatePicker)(target));
            
            #line 40 "..\..\..\UserEditPages\AddReception.xaml"
            this.Date.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Date_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Time = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ServiceCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\UserEditPages\AddReception.xaml"
            this.ServiceCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ServiceCB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProductCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\UserEditPages\AddReception.xaml"
            this.ProductCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductCB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Discount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.SumL = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.InReception = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\UserEditPages\AddReception.xaml"
            this.InReception.Click += new System.Windows.RoutedEventHandler(this.InReception_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\UserEditPages\AddReception.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

