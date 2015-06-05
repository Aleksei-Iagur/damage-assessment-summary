﻿#pragma checksum "..\..\..\Controls\FilterControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E8989E3D4EEC25EEC3B372295F05202D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ConfigureSummaryReport;
using ConfigureSummaryReport.Controls;
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


namespace ConfigureSummaryReport.Controls {
    
    
    /// <summary>
    /// FilterControl
    /// </summary>
    public partial class FilterControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 26 "..\..\..\Controls\FilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboFieldNames;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Controls\FilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboOperators;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Controls\FilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ConfigureSummaryReport.Controls.ClickableTextBox txtSimpleExpression;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Controls\FilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddExpression;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Controls\FilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ConfigureSummaryReport.Controls.ClickableTextBox txtAdvancedExpression;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Controls\FilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddAdvancedExpression;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Controls\FilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvExpressions;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Controls\FilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnValidateExpression;
        
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
            System.Uri resourceLocater = new System.Uri("/SummaryReport;component/controls/filtercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\FilterControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.cboFieldNames = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cboOperators = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txtSimpleExpression = ((ConfigureSummaryReport.Controls.ClickableTextBox)(target));
            return;
            case 4:
            this.btnAddExpression = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Controls\FilterControl.xaml"
            this.btnAddExpression.Click += new System.Windows.RoutedEventHandler(this.btnAddExpression_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtAdvancedExpression = ((ConfigureSummaryReport.Controls.ClickableTextBox)(target));
            return;
            case 6:
            this.btnAddAdvancedExpression = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Controls\FilterControl.xaml"
            this.btnAddAdvancedExpression.Click += new System.Windows.RoutedEventHandler(this.btnAddAdvancedExpression_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lvExpressions = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.btnValidateExpression = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\Controls\FilterControl.xaml"
            this.btnValidateExpression.Click += new System.Windows.RoutedEventHandler(this.validateExpression_Click);
            
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
            case 8:
            
            #line 104 "..\..\..\Controls\FilterControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

