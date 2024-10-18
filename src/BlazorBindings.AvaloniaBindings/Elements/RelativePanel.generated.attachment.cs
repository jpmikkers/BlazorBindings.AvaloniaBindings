

namespace BlazorBindings.AvaloniaBindings.Elements
{
    
    internal static class RelativePanelInitializer
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void RegisterAdditionalHandlers()
        {
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.Above",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AboveProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAbove((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignBottomWithPanel",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignBottomWithPanelProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignBottomWithPanel((Avalonia.AvaloniaObject)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignBottomWith",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignBottomWithProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignBottomWith((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignHorizontalCenterWithPanel",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignHorizontalCenterWithPanelProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignHorizontalCenterWithPanel((Avalonia.AvaloniaObject)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignHorizontalCenterWith",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignHorizontalCenterWithProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignHorizontalCenterWith((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignLeftWithPanel",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignLeftWithPanelProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignLeftWithPanel((Avalonia.AvaloniaObject)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignLeftWith",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignLeftWithProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignLeftWith((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignRightWithPanel",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignRightWithPanelProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignRightWithPanel((Avalonia.AvaloniaObject)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignRightWith",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignRightWithProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignRightWith((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignTopWithPanel",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignTopWithPanelProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignTopWithPanel((Avalonia.AvaloniaObject)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignTopWith",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignTopWithProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignTopWith((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignVerticalCenterWithPanel",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignVerticalCenterWithPanelProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignVerticalCenterWithPanel((Avalonia.AvaloniaObject)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.AlignVerticalCenterWith",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.AlignVerticalCenterWithProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetAlignVerticalCenterWith((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.Below",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.BelowProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetBelow((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.LeftOf",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.LeftOfProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetLeftOf((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("RelativePanel.RightOf",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.RelativePanel.RightOfProperty);
                    }
                    else
                    {
                        Avalonia.Controls.RelativePanel.SetRightOf((Avalonia.AvaloniaObject)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
        }
    }

    public static partial class RelativePanelExtensions
    {
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AboveProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAbove(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.Above"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignBottomWithPanel(this AvaloniaObject element, bool value)
        {
            element.AttachedProperties["RelativePanel.AlignBottomWithPanel"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignBottomWithProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignBottomWith(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.AlignBottomWith"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignHorizontalCenterWithPanel(this AvaloniaObject element, bool value)
        {
            element.AttachedProperties["RelativePanel.AlignHorizontalCenterWithPanel"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignHorizontalCenterWith(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.AlignHorizontalCenterWith"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignLeftWithPanel(this AvaloniaObject element, bool value)
        {
            element.AttachedProperties["RelativePanel.AlignLeftWithPanel"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignLeftWithProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignLeftWith(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.AlignLeftWith"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignRightWithPanel(this AvaloniaObject element, bool value)
        {
            element.AttachedProperties["RelativePanel.AlignRightWithPanel"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignRightWithProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignRightWith(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.AlignRightWith"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignTopWithPanel(this AvaloniaObject element, bool value)
        {
            element.AttachedProperties["RelativePanel.AlignTopWithPanel"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignTopWithProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignTopWith(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.AlignTopWith"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignVerticalCenterWithPanel(this AvaloniaObject element, bool value)
        {
            element.AttachedProperties["RelativePanel.AlignVerticalCenterWithPanel"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelAlignVerticalCenterWith(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.AlignVerticalCenterWith"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.BelowProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelBelow(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.Below"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.LeftOfProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelLeftOf(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.LeftOf"] = value;
        
            return element;
        }
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.RightOfProperty" /> XAML attached property.
        /// </summary>
        public static AvaloniaObject RelativePanelRightOf(this AvaloniaObject element, object value)
        {
            element.AttachedProperties["RelativePanel.RightOf"] = value;
        
            return element;
        }
    }

    public class RelativePanel_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AboveProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object Above { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public bool AlignBottomWithPanel { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignBottomWithProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object AlignBottomWith { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public bool AlignHorizontalCenterWithPanel { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object AlignHorizontalCenterWith { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public bool AlignLeftWithPanel { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignLeftWithProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object AlignLeftWith { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public bool AlignRightWithPanel { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignRightWithProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object AlignRightWith { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public bool AlignTopWithPanel { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignTopWithProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object AlignTopWith { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public bool AlignVerticalCenterWithPanel { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object AlignVerticalCenterWith { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.BelowProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object Below { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.LeftOfProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object LeftOf { get; set; }

        /// <summary>
        /// Identifies the <see cref="F:Avalonia.Controls.RelativePanel.RightOfProperty" /> XAML attached property.
        /// </summary>
        [Parameter] public object RightOf { get; set; }

        private Avalonia.AvaloniaObject _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(Above):
                    if (!Equals(Above, value))
                    {
                        Above = (object)value;
                        //NativeControl.AboveProperty = Above;
                    }
                    break;

                    case nameof(AlignBottomWithPanel):
                    if (!Equals(AlignBottomWithPanel, value))
                    {
                        AlignBottomWithPanel = (bool)value;
                        //NativeControl.AlignBottomWithPanelProperty = AlignBottomWithPanel;
                    }
                    break;

                    case nameof(AlignBottomWith):
                    if (!Equals(AlignBottomWith, value))
                    {
                        AlignBottomWith = (object)value;
                        //NativeControl.AlignBottomWithProperty = AlignBottomWith;
                    }
                    break;

                    case nameof(AlignHorizontalCenterWithPanel):
                    if (!Equals(AlignHorizontalCenterWithPanel, value))
                    {
                        AlignHorizontalCenterWithPanel = (bool)value;
                        //NativeControl.AlignHorizontalCenterWithPanelProperty = AlignHorizontalCenterWithPanel;
                    }
                    break;

                    case nameof(AlignHorizontalCenterWith):
                    if (!Equals(AlignHorizontalCenterWith, value))
                    {
                        AlignHorizontalCenterWith = (object)value;
                        //NativeControl.AlignHorizontalCenterWithProperty = AlignHorizontalCenterWith;
                    }
                    break;

                    case nameof(AlignLeftWithPanel):
                    if (!Equals(AlignLeftWithPanel, value))
                    {
                        AlignLeftWithPanel = (bool)value;
                        //NativeControl.AlignLeftWithPanelProperty = AlignLeftWithPanel;
                    }
                    break;

                    case nameof(AlignLeftWith):
                    if (!Equals(AlignLeftWith, value))
                    {
                        AlignLeftWith = (object)value;
                        //NativeControl.AlignLeftWithProperty = AlignLeftWith;
                    }
                    break;

                    case nameof(AlignRightWithPanel):
                    if (!Equals(AlignRightWithPanel, value))
                    {
                        AlignRightWithPanel = (bool)value;
                        //NativeControl.AlignRightWithPanelProperty = AlignRightWithPanel;
                    }
                    break;

                    case nameof(AlignRightWith):
                    if (!Equals(AlignRightWith, value))
                    {
                        AlignRightWith = (object)value;
                        //NativeControl.AlignRightWithProperty = AlignRightWith;
                    }
                    break;

                    case nameof(AlignTopWithPanel):
                    if (!Equals(AlignTopWithPanel, value))
                    {
                        AlignTopWithPanel = (bool)value;
                        //NativeControl.AlignTopWithPanelProperty = AlignTopWithPanel;
                    }
                    break;

                    case nameof(AlignTopWith):
                    if (!Equals(AlignTopWith, value))
                    {
                        AlignTopWith = (object)value;
                        //NativeControl.AlignTopWithProperty = AlignTopWith;
                    }
                    break;

                    case nameof(AlignVerticalCenterWithPanel):
                    if (!Equals(AlignVerticalCenterWithPanel, value))
                    {
                        AlignVerticalCenterWithPanel = (bool)value;
                        //NativeControl.AlignVerticalCenterWithPanelProperty = AlignVerticalCenterWithPanel;
                    }
                    break;

                    case nameof(AlignVerticalCenterWith):
                    if (!Equals(AlignVerticalCenterWith, value))
                    {
                        AlignVerticalCenterWith = (object)value;
                        //NativeControl.AlignVerticalCenterWithProperty = AlignVerticalCenterWith;
                    }
                    break;

                    case nameof(Below):
                    if (!Equals(Below, value))
                    {
                        Below = (object)value;
                        //NativeControl.BelowProperty = Below;
                    }
                    break;

                    case nameof(LeftOf):
                    if (!Equals(LeftOf, value))
                    {
                        LeftOf = (object)value;
                        //NativeControl.LeftOfProperty = LeftOf;
                    }
                    break;

                    case nameof(RightOf):
                    if (!Equals(RightOf, value))
                    {
                        RightOf = (object)value;
                        //NativeControl.RightOfProperty = RightOf;
                    }
                    break;

                }
            }
        
            TryUpdateParent(_parent);
            return base.SetParametersAsync(ParameterView.Empty);
        }

        private void TryUpdateParent(object parentElement)
        {
            if (parentElement is not null)
            {
                if (Above == Avalonia.Controls.RelativePanel.AboveProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AboveProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAbove((Avalonia.AvaloniaObject)parentElement, Above);
                }
                
                if (AlignBottomWithPanel == Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignBottomWithPanel((Avalonia.AvaloniaObject)parentElement, AlignBottomWithPanel);
                }
                
                if (AlignBottomWith == Avalonia.Controls.RelativePanel.AlignBottomWithProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignBottomWithProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignBottomWith((Avalonia.AvaloniaObject)parentElement, AlignBottomWith);
                }
                
                if (AlignHorizontalCenterWithPanel == Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignHorizontalCenterWithPanel((Avalonia.AvaloniaObject)parentElement, AlignHorizontalCenterWithPanel);
                }
                
                if (AlignHorizontalCenterWith == Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignHorizontalCenterWith((Avalonia.AvaloniaObject)parentElement, AlignHorizontalCenterWith);
                }
                
                if (AlignLeftWithPanel == Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignLeftWithPanel((Avalonia.AvaloniaObject)parentElement, AlignLeftWithPanel);
                }
                
                if (AlignLeftWith == Avalonia.Controls.RelativePanel.AlignLeftWithProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignLeftWithProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignLeftWith((Avalonia.AvaloniaObject)parentElement, AlignLeftWith);
                }
                
                if (AlignRightWithPanel == Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignRightWithPanel((Avalonia.AvaloniaObject)parentElement, AlignRightWithPanel);
                }
                
                if (AlignRightWith == Avalonia.Controls.RelativePanel.AlignRightWithProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignRightWithProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignRightWith((Avalonia.AvaloniaObject)parentElement, AlignRightWith);
                }
                
                if (AlignTopWithPanel == Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignTopWithPanel((Avalonia.AvaloniaObject)parentElement, AlignTopWithPanel);
                }
                
                if (AlignTopWith == Avalonia.Controls.RelativePanel.AlignTopWithProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignTopWithProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignTopWith((Avalonia.AvaloniaObject)parentElement, AlignTopWith);
                }
                
                if (AlignVerticalCenterWithPanel == Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignVerticalCenterWithPanel((Avalonia.AvaloniaObject)parentElement, AlignVerticalCenterWithPanel);
                }
                
                if (AlignVerticalCenterWith == Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetAlignVerticalCenterWith((Avalonia.AvaloniaObject)parentElement, AlignVerticalCenterWith);
                }
                
                if (Below == Avalonia.Controls.RelativePanel.BelowProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.BelowProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetBelow((Avalonia.AvaloniaObject)parentElement, Below);
                }
                
                if (LeftOf == Avalonia.Controls.RelativePanel.LeftOfProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.LeftOfProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetLeftOf((Avalonia.AvaloniaObject)parentElement, LeftOf);
                }
                
                if (RightOf == Avalonia.Controls.RelativePanel.RightOfProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.RelativePanel.RightOfProperty);
                }
                else
                {
                    Avalonia.Controls.RelativePanel.SetRightOf((Avalonia.AvaloniaObject)parentElement, RightOf);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Above = Above != default ? Above : Avalonia.Controls.RelativePanel.AboveProperty.GetDefaultValue(parentType);
                AlignBottomWithPanel = AlignBottomWithPanel != default ? AlignBottomWithPanel : Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty.GetDefaultValue(parentType);
                AlignBottomWith = AlignBottomWith != default ? AlignBottomWith : Avalonia.Controls.RelativePanel.AlignBottomWithProperty.GetDefaultValue(parentType);
                AlignHorizontalCenterWithPanel = AlignHorizontalCenterWithPanel != default ? AlignHorizontalCenterWithPanel : Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty.GetDefaultValue(parentType);
                AlignHorizontalCenterWith = AlignHorizontalCenterWith != default ? AlignHorizontalCenterWith : Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty.GetDefaultValue(parentType);
                AlignLeftWithPanel = AlignLeftWithPanel != default ? AlignLeftWithPanel : Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty.GetDefaultValue(parentType);
                AlignLeftWith = AlignLeftWith != default ? AlignLeftWith : Avalonia.Controls.RelativePanel.AlignLeftWithProperty.GetDefaultValue(parentType);
                AlignRightWithPanel = AlignRightWithPanel != default ? AlignRightWithPanel : Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty.GetDefaultValue(parentType);
                AlignRightWith = AlignRightWith != default ? AlignRightWith : Avalonia.Controls.RelativePanel.AlignRightWithProperty.GetDefaultValue(parentType);
                AlignTopWithPanel = AlignTopWithPanel != default ? AlignTopWithPanel : Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty.GetDefaultValue(parentType);
                AlignTopWith = AlignTopWith != default ? AlignTopWith : Avalonia.Controls.RelativePanel.AlignTopWithProperty.GetDefaultValue(parentType);
                AlignVerticalCenterWithPanel = AlignVerticalCenterWithPanel != default ? AlignVerticalCenterWithPanel : Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty.GetDefaultValue(parentType);
                AlignVerticalCenterWith = AlignVerticalCenterWith != default ? AlignVerticalCenterWith : Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty.GetDefaultValue(parentType);
                Below = Below != default ? Below : Avalonia.Controls.RelativePanel.BelowProperty.GetDefaultValue(parentType);
                LeftOf = LeftOf != default ? LeftOf : Avalonia.Controls.RelativePanel.LeftOfProperty.GetDefaultValue(parentType);
                RightOf = RightOf != default ? RightOf : Avalonia.Controls.RelativePanel.RightOfProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = (Avalonia.AvaloniaObject)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Above = Avalonia.Controls.RelativePanel.AboveProperty.GetDefaultValue(parentType);
                AlignBottomWithPanel = Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty.GetDefaultValue(parentType);
                AlignBottomWith = Avalonia.Controls.RelativePanel.AlignBottomWithProperty.GetDefaultValue(parentType);
                AlignHorizontalCenterWithPanel = Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty.GetDefaultValue(parentType);
                AlignHorizontalCenterWith = Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty.GetDefaultValue(parentType);
                AlignLeftWithPanel = Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty.GetDefaultValue(parentType);
                AlignLeftWith = Avalonia.Controls.RelativePanel.AlignLeftWithProperty.GetDefaultValue(parentType);
                AlignRightWithPanel = Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty.GetDefaultValue(parentType);
                AlignRightWith = Avalonia.Controls.RelativePanel.AlignRightWithProperty.GetDefaultValue(parentType);
                AlignTopWithPanel = Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty.GetDefaultValue(parentType);
                AlignTopWith = Avalonia.Controls.RelativePanel.AlignTopWithProperty.GetDefaultValue(parentType);
                AlignVerticalCenterWithPanel = Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty.GetDefaultValue(parentType);
                AlignVerticalCenterWith = Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty.GetDefaultValue(parentType);
                Below = Avalonia.Controls.RelativePanel.BelowProperty.GetDefaultValue(parentType);
                LeftOf = Avalonia.Controls.RelativePanel.LeftOfProperty.GetDefaultValue(parentType);
                RightOf = Avalonia.Controls.RelativePanel.RightOfProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = null;
        }

        public void AddChild(object child, int physicalSiblingIndex)
        {
        }

        public void RemoveChild(object child, int physicalSiblingIndex)
        {
        }

        protected override void RenderAdditionalElementContent(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
        }
    }
}
