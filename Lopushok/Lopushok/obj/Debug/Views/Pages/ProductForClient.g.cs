﻿#pragma checksum "..\..\..\..\Views\Pages\ProductForClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D5153EA0DA643C2BC988127980C08312A9BC021A15E426C8C8DA00E6E41A0F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Lopushok.Views.Pages;
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


namespace Lopushok.Views.Pages {
    
    
    /// <summary>
    /// ProductForClient
    /// </summary>
    public partial class ProductForClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Views\Pages\ProductForClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\Pages\ProductForClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortComboBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\Pages\ProductForClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ascDescCheckBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\Pages\ProductForClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView productListView;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Views\Pages\ProductForClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Lopushok;component/views/pages/productforclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\ProductForClient.xaml"
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
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\Views\Pages\ProductForClient.xaml"
            this.searchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sortComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\Views\Pages\ProductForClient.xaml"
            this.sortComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sortComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ascDescCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 28 "..\..\..\..\Views\Pages\ProductForClient.xaml"
            this.ascDescCheckBox.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\..\Views\Pages\ProductForClient.xaml"
            this.ascDescCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.productListView = ((System.Windows.Controls.ListView)(target));
            
            #line 36 "..\..\..\..\Views\Pages\ProductForClient.xaml"
            this.productListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.productListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editBtn = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Views\Pages\ProductForClient.xaml"
            this.editBtn.Click += new System.Windows.RoutedEventHandler(this.editBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

