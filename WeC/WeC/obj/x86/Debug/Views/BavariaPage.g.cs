﻿#pragma checksum "C:\Users\bonda\source\repos\v1nchiko\WeC\WeC\WeC\Views\BavariaPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A8161BA83C2612BA016501434337B2479D5F8C9977D53DE43662602B4D080EA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeC.Views
{
    partial class BavariaPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_WebView_Source(global::Windows.UI.Xaml.Controls.WebView obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class BavariaPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IBavariaPage_Bindings
        {
            private global::WeC.Views.BavariaPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.WebView obj10;
            private global::Windows.UI.Xaml.Controls.StackPanel obj11;
            private global::Windows.UI.Xaml.Controls.StackPanel obj12;
            private global::Windows.UI.Xaml.Controls.Button obj13;
            private global::Windows.UI.Xaml.Controls.Button obj14;
            private global::Windows.UI.Xaml.Controls.Button obj15;
            private global::Windows.UI.Xaml.Controls.Button obj16;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj17;
            private global::Windows.UI.Xaml.Controls.ProgressRing obj18;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj19;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj20;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10SourceDisabled = false;
            private static bool isobj11VisibilityDisabled = false;
            private static bool isobj12VisibilityDisabled = false;
            private static bool isobj13CommandDisabled = false;
            private static bool isobj14CommandDisabled = false;
            private static bool isobj15CommandDisabled = false;
            private static bool isobj16CommandDisabled = false;
            private static bool isobj17CommandDisabled = false;
            private static bool isobj18IsActiveDisabled = false;
            private static bool isobj19CommandDisabled = false;
            private static bool isobj20CommandDisabled = false;

            private BavariaPage_obj1_BindingsTracking bindingsTracking;

            public BavariaPage_obj1_Bindings()
            {
                this.bindingsTracking = new BavariaPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 83 && columnNumber == 35)
                {
                    isobj10SourceDisabled = true;
                }
                else if (lineNumber == 94 && columnNumber == 21)
                {
                    isobj11VisibilityDisabled = true;
                }
                else if (lineNumber == 100 && columnNumber == 21)
                {
                    isobj12VisibilityDisabled = true;
                }
                else if (lineNumber == 117 && columnNumber == 69)
                {
                    isobj13CommandDisabled = true;
                }
                else if (lineNumber == 120 && columnNumber == 69)
                {
                    isobj14CommandDisabled = true;
                }
                else if (lineNumber == 109 && columnNumber == 69)
                {
                    isobj15CommandDisabled = true;
                }
                else if (lineNumber == 112 && columnNumber == 69)
                {
                    isobj16CommandDisabled = true;
                }
                else if (lineNumber == 104 && columnNumber == 30)
                {
                    isobj17CommandDisabled = true;
                }
                else if (lineNumber == 97 && columnNumber == 27)
                {
                    isobj18IsActiveDisabled = true;
                }
                else if (lineNumber == 89 && columnNumber == 45)
                {
                    isobj19CommandDisabled = true;
                }
                else if (lineNumber == 86 && columnNumber == 45)
                {
                    isobj20CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Views\BavariaPage.xaml line 83
                        this.obj10 = (global::Windows.UI.Xaml.Controls.WebView)target;
                        break;
                    case 11: // Views\BavariaPage.xaml line 94
                        this.obj11 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 12: // Views\BavariaPage.xaml line 100
                        this.obj12 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 13: // Views\BavariaPage.xaml line 117
                        this.obj13 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 14: // Views\BavariaPage.xaml line 120
                        this.obj14 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 15: // Views\BavariaPage.xaml line 109
                        this.obj15 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 16: // Views\BavariaPage.xaml line 112
                        this.obj16 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 17: // Views\BavariaPage.xaml line 104
                        this.obj17 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 18: // Views\BavariaPage.xaml line 97
                        this.obj18 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    case 19: // Views\BavariaPage.xaml line 89
                        this.obj19 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    case 20: // Views\BavariaPage.xaml line 86
                        this.obj20 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IBavariaPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::WeC.Views.BavariaPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WeC.Views.BavariaPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::WeC.ViewModels.BavariaViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Source(obj.Source, phase);
                        this.Update_ViewModel_IsLoadingVisibility(obj.IsLoadingVisibility, phase);
                        this.Update_ViewModel_FailedMesageVisibility(obj.FailedMesageVisibility, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_RefreshCommand(obj.RefreshCommand, phase);
                        this.Update_ViewModel_OpenInBrowserCommand(obj.OpenInBrowserCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_BrowserBackCommand(obj.BrowserBackCommand, phase);
                        this.Update_ViewModel_BrowserForwardCommand(obj.BrowserForwardCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_RetryCommand(obj.RetryCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IsLoading(obj.IsLoading, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_NavFailedCommand(obj.NavFailedCommand, phase);
                        this.Update_ViewModel_NavCompletedCommand(obj.NavCompletedCommand, phase);
                    }
                }
            }
            private void Update_ViewModel_Source(global::System.Uri obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\BavariaPage.xaml line 83
                    if (!isobj10SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_WebView_Source(this.obj10, obj, null);
                    }
                }
            }
            private void Update_ViewModel_IsLoadingVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\BavariaPage.xaml line 94
                    if (!isobj11VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj11, obj);
                    }
                }
            }
            private void Update_ViewModel_FailedMesageVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\BavariaPage.xaml line 100
                    if (!isobj12VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj12, obj);
                    }
                }
            }
            private void Update_ViewModel_RefreshCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\BavariaPage.xaml line 117
                    if (!isobj13CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj13, obj, null);
                    }
                }
            }
            private void Update_ViewModel_OpenInBrowserCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\BavariaPage.xaml line 120
                    if (!isobj14CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj14, obj, null);
                    }
                }
            }
            private void Update_ViewModel_BrowserBackCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\BavariaPage.xaml line 109
                    if (!isobj15CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj15, obj, null);
                    }
                }
            }
            private void Update_ViewModel_BrowserForwardCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\BavariaPage.xaml line 112
                    if (!isobj16CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj16, obj, null);
                    }
                }
            }
            private void Update_ViewModel_RetryCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\BavariaPage.xaml line 104
                    if (!isobj17CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj17, obj, null);
                    }
                }
            }
            private void Update_ViewModel_IsLoading(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\BavariaPage.xaml line 97
                    if (!isobj18IsActiveDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj18, obj);
                    }
                }
            }
            private void Update_ViewModel_NavFailedCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\BavariaPage.xaml line 89
                    if (!isobj19CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj19, obj, null);
                    }
                }
            }
            private void Update_ViewModel_NavCompletedCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\BavariaPage.xaml line 86
                    if (!isobj20CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj20, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class BavariaPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<BavariaPage_obj1_Bindings> weakRefToBindingObj; 

                public BavariaPage_obj1_BindingsTracking(BavariaPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<BavariaPage_obj1_Bindings>(obj);
                }

                public BavariaPage_obj1_Bindings TryGetBindingObject()
                {
                    BavariaPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    BavariaPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::WeC.ViewModels.BavariaViewModel obj = sender as global::WeC.ViewModels.BavariaViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Source(obj.Source, DATA_CHANGED);
                                bindings.Update_ViewModel_IsLoadingVisibility(obj.IsLoadingVisibility, DATA_CHANGED);
                                bindings.Update_ViewModel_FailedMesageVisibility(obj.FailedMesageVisibility, DATA_CHANGED);
                                bindings.Update_ViewModel_BrowserBackCommand(obj.BrowserBackCommand, DATA_CHANGED);
                                bindings.Update_ViewModel_BrowserForwardCommand(obj.BrowserForwardCommand, DATA_CHANGED);
                                bindings.Update_ViewModel_IsLoading(obj.IsLoading, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Source":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Source(obj.Source, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsLoadingVisibility":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsLoadingVisibility(obj.IsLoadingVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "FailedMesageVisibility":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_FailedMesageVisibility(obj.FailedMesageVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BrowserBackCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_BrowserBackCommand(obj.BrowserBackCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BrowserForwardCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_BrowserForwardCommand(obj.BrowserForwardCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsLoading":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsLoading(obj.IsLoading, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::WeC.ViewModels.BavariaViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::WeC.ViewModels.BavariaViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 10: // Views\BavariaPage.xaml line 83
                {
                    this.webView = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\BavariaPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    BavariaPage_obj1_Bindings bindings = new BavariaPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

