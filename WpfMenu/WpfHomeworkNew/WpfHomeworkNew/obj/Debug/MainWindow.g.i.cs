// Updated by XamlIntelliSenseFileGenerator 29.11.2023 1:02:40
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0026979706FD5774D74102B8BC03F8C3AC5C8BE39DCC3C8893C7E08FD08605AE"
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
using WpfHomeworkNew;


namespace WpfHomeworkNew
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainWindow1;

#line default
#line hidden


#line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_red;

#line default
#line hidden


#line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_white;

#line default
#line hidden


#line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_blue;

#line default
#line hidden


#line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_tool_red;

#line default
#line hidden


#line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_tool_white;

#line default
#line hidden


#line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_tool_blue;

#line default
#line hidden


#line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock status;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfHomeworkNew;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.mainWindow1 = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:

#line 15 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.background_color);

#line default
#line hidden

#line 15 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden
                    return;
                case 3:
                    this.radio_red = ((System.Windows.Controls.RadioButton)(target));

#line 16 "..\..\MainWindow.xaml"
                    this.radio_red.MouseEnter += new System.Windows.Input.MouseEventHandler(this.radio_red_status_E);

#line default
#line hidden

#line 16 "..\..\MainWindow.xaml"
                    this.radio_red.MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 16 "..\..\MainWindow.xaml"
                    this.radio_red.Checked += new System.Windows.RoutedEventHandler(this.red_background);

#line default
#line hidden
                    return;
                case 4:
                    this.radio_white = ((System.Windows.Controls.RadioButton)(target));

#line 17 "..\..\MainWindow.xaml"
                    this.radio_white.MouseEnter += new System.Windows.Input.MouseEventHandler(this.radio_white_status_E);

#line default
#line hidden

#line 17 "..\..\MainWindow.xaml"
                    this.radio_white.MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 17 "..\..\MainWindow.xaml"
                    this.radio_white.Checked += new System.Windows.RoutedEventHandler(this.white_background);

#line default
#line hidden
                    return;
                case 5:
                    this.radio_blue = ((System.Windows.Controls.RadioButton)(target));

#line 18 "..\..\MainWindow.xaml"
                    this.radio_blue.MouseEnter += new System.Windows.Input.MouseEventHandler(this.radio_blue_status_E);

#line default
#line hidden

#line 18 "..\..\MainWindow.xaml"
                    this.radio_blue.MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 18 "..\..\MainWindow.xaml"
                    this.radio_blue.Checked += new System.Windows.RoutedEventHandler(this.blue_background);

#line default
#line hidden
                    return;
                case 6:

#line 21 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.developer_status);

#line default
#line hidden

#line 21 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 21 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.about_developer);

#line default
#line hidden
                    return;
                case 7:

#line 23 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.close_status);

#line default
#line hidden

#line 23 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 23 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.close_window);

#line default
#line hidden
                    return;
                case 8:

#line 25 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.toolBar_status);

#line default
#line hidden

#line 25 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden
                    return;
                case 9:

#line 27 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.TextBlock)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.background_color);

#line default
#line hidden

#line 27 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.TextBlock)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden
                    return;
                case 10:
                    this.radio_tool_red = ((System.Windows.Controls.RadioButton)(target));

#line 29 "..\..\MainWindow.xaml"
                    this.radio_tool_red.MouseEnter += new System.Windows.Input.MouseEventHandler(this.radio_red_status_E);

#line default
#line hidden

#line 29 "..\..\MainWindow.xaml"
                    this.radio_tool_red.MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 29 "..\..\MainWindow.xaml"
                    this.radio_tool_red.Checked += new System.Windows.RoutedEventHandler(this.red_background);

#line default
#line hidden
                    return;
                case 11:
                    this.radio_tool_white = ((System.Windows.Controls.RadioButton)(target));

#line 30 "..\..\MainWindow.xaml"
                    this.radio_tool_white.MouseEnter += new System.Windows.Input.MouseEventHandler(this.radio_white_status_E);

#line default
#line hidden

#line 30 "..\..\MainWindow.xaml"
                    this.radio_tool_white.MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 30 "..\..\MainWindow.xaml"
                    this.radio_tool_white.Checked += new System.Windows.RoutedEventHandler(this.white_background);

#line default
#line hidden
                    return;
                case 12:
                    this.radio_tool_blue = ((System.Windows.Controls.RadioButton)(target));

#line 31 "..\..\MainWindow.xaml"
                    this.radio_tool_blue.MouseEnter += new System.Windows.Input.MouseEventHandler(this.radio_blue_status_E);

#line default
#line hidden

#line 31 "..\..\MainWindow.xaml"
                    this.radio_tool_blue.MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 31 "..\..\MainWindow.xaml"
                    this.radio_tool_blue.Checked += new System.Windows.RoutedEventHandler(this.blue_background);

#line default
#line hidden
                    return;
                case 13:

#line 35 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.developer_status);

#line default
#line hidden

#line 35 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 35 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.about_developer);

#line default
#line hidden
                    return;
                case 14:

#line 37 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.close_status);

#line default
#line hidden

#line 37 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.status_default);

#line default
#line hidden

#line 37 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.close_window);

#line default
#line hidden
                    return;
                case 15:
                    this.status = ((System.Windows.Controls.TextBlock)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.InkCanvas paint;
    }
}

