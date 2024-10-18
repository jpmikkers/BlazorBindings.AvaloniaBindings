

namespace BlazorBindings.AvaloniaBindings.Elements
{
    
    internal static class ScrollViewerInitializer
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void RegisterAdditionalHandlers()
        {
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.AllowAutoHide",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.AllowAutoHideProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetAllowAutoHide((Avalonia.Controls.Control)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.BringIntoViewOnFocusChange",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.BringIntoViewOnFocusChangeProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetBringIntoViewOnFocusChange((Avalonia.Controls.Control)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.HorizontalScrollBarVisibility",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.HorizontalScrollBarVisibilityProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetHorizontalScrollBarVisibility((Avalonia.Controls.Control)element, (AC.Primitives.ScrollBarVisibility)Convert.ChangeType(value, typeof(AC.Primitives.ScrollBarVisibility)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.HorizontalSnapPointsAlignment",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.HorizontalSnapPointsAlignmentProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsAlignment((Avalonia.Controls.Control)element, (AC.Primitives.SnapPointsAlignment)Convert.ChangeType(value, typeof(AC.Primitives.SnapPointsAlignment)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.HorizontalSnapPointsType",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.HorizontalSnapPointsTypeProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsType((Avalonia.Controls.Control)element, (AC.Primitives.SnapPointsType)Convert.ChangeType(value, typeof(AC.Primitives.SnapPointsType)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.IsDeferredScrollingEnabled",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.IsDeferredScrollingEnabledProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetIsDeferredScrollingEnabled((Avalonia.Controls.Control)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.IsScrollChainingEnabled",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.IsScrollChainingEnabledProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetIsScrollChainingEnabled((Avalonia.Controls.Control)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.IsScrollInertiaEnabled",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.IsScrollInertiaEnabledProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetIsScrollInertiaEnabled((Avalonia.Controls.Control)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.VerticalScrollBarVisibility",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.VerticalScrollBarVisibilityProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetVerticalScrollBarVisibility((Avalonia.Controls.Control)element, (AC.Primitives.ScrollBarVisibility)Convert.ChangeType(value, typeof(AC.Primitives.ScrollBarVisibility)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.VerticalSnapPointsAlignment",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.VerticalSnapPointsAlignmentProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsAlignment((Avalonia.Controls.Control)element, (AC.Primitives.SnapPointsAlignment)Convert.ChangeType(value, typeof(AC.Primitives.SnapPointsAlignment)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ScrollViewer.VerticalSnapPointsType",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ScrollViewer.VerticalSnapPointsTypeProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsType((Avalonia.Controls.Control)element, (AC.Primitives.SnapPointsType)Convert.ChangeType(value, typeof(AC.Primitives.SnapPointsType)));
                    }
                });
        }
    }

    public static partial class ScrollViewerExtensions
    {
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.AllowAutoHide" /> property.
        /// </summary>
        public static Control ScrollViewerAllowAutoHide(this Control element, bool value)
        {
            element.AttachedProperties["ScrollViewer.AllowAutoHide"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChange" /> property.
        /// </summary>
        public static Control ScrollViewerBringIntoViewOnFocusChange(this Control element, bool value)
        {
            element.AttachedProperties["ScrollViewer.BringIntoViewOnFocusChange"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibility" /> property.
        /// </summary>
        public static Control ScrollViewerHorizontalScrollBarVisibility(this Control element, AC.Primitives.ScrollBarVisibility value)
        {
            element.AttachedProperties["ScrollViewer.HorizontalScrollBarVisibility"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignment" /> property.
        /// </summary>
        public static Control ScrollViewerHorizontalSnapPointsAlignment(this Control element, AC.Primitives.SnapPointsAlignment value)
        {
            element.AttachedProperties["ScrollViewer.HorizontalSnapPointsAlignment"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalSnapPointsType" /> property.
        /// </summary>
        public static Control ScrollViewerHorizontalSnapPointsType(this Control element, AC.Primitives.SnapPointsType value)
        {
            element.AttachedProperties["ScrollViewer.HorizontalSnapPointsType"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabled" /> property.
        /// </summary>
        public static Control ScrollViewerIsDeferredScrollingEnabled(this Control element, bool value)
        {
            element.AttachedProperties["ScrollViewer.IsDeferredScrollingEnabled"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.IsScrollChainingEnabled" /> property.
        /// </summary>
        public static Control ScrollViewerIsScrollChainingEnabled(this Control element, bool value)
        {
            element.AttachedProperties["ScrollViewer.IsScrollChainingEnabled"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabled" /> property.
        /// </summary>
        public static Control ScrollViewerIsScrollInertiaEnabled(this Control element, bool value)
        {
            element.AttachedProperties["ScrollViewer.IsScrollInertiaEnabled"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibility" /> property.
        /// </summary>
        public static Control ScrollViewerVerticalScrollBarVisibility(this Control element, AC.Primitives.ScrollBarVisibility value)
        {
            element.AttachedProperties["ScrollViewer.VerticalScrollBarVisibility"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignment" /> property.
        /// </summary>
        public static Control ScrollViewerVerticalSnapPointsAlignment(this Control element, AC.Primitives.SnapPointsAlignment value)
        {
            element.AttachedProperties["ScrollViewer.VerticalSnapPointsAlignment"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalSnapPointsType" /> property.
        /// </summary>
        public static Control ScrollViewerVerticalSnapPointsType(this Control element, AC.Primitives.SnapPointsType value)
        {
            element.AttachedProperties["ScrollViewer.VerticalSnapPointsType"] = value;
        
            return element;
        }
    }

    public class ScrollViewer_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.AllowAutoHide" /> property.
        /// </summary>
        [Parameter] public bool AllowAutoHide { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChange" /> property.
        /// </summary>
        [Parameter] public bool BringIntoViewOnFocusChange { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibility" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignment" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.SnapPointsAlignment HorizontalSnapPointsAlignment { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalSnapPointsType" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.SnapPointsType HorizontalSnapPointsType { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabled" /> property.
        /// </summary>
        [Parameter] public bool IsDeferredScrollingEnabled { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.IsScrollChainingEnabled" /> property.
        /// </summary>
        [Parameter] public bool IsScrollChainingEnabled { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabled" /> property.
        /// </summary>
        [Parameter] public bool IsScrollInertiaEnabled { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibility" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.ScrollBarVisibility VerticalScrollBarVisibility { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignment" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.SnapPointsAlignment VerticalSnapPointsAlignment { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalSnapPointsType" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.SnapPointsType VerticalSnapPointsType { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(AllowAutoHide):
                    if (!Equals(AllowAutoHide, value))
                    {
                        AllowAutoHide = (bool)value;
                        //NativeControl.AllowAutoHideProperty = AllowAutoHide;
                    }
                    break;

                    case nameof(BringIntoViewOnFocusChange):
                    if (!Equals(BringIntoViewOnFocusChange, value))
                    {
                        BringIntoViewOnFocusChange = (bool)value;
                        //NativeControl.BringIntoViewOnFocusChangeProperty = BringIntoViewOnFocusChange;
                    }
                    break;

                    case nameof(HorizontalScrollBarVisibility):
                    if (!Equals(HorizontalScrollBarVisibility, value))
                    {
                        HorizontalScrollBarVisibility = (AC.Primitives.ScrollBarVisibility)value;
                        //NativeControl.HorizontalScrollBarVisibilityProperty = HorizontalScrollBarVisibility;
                    }
                    break;

                    case nameof(HorizontalSnapPointsAlignment):
                    if (!Equals(HorizontalSnapPointsAlignment, value))
                    {
                        HorizontalSnapPointsAlignment = (AC.Primitives.SnapPointsAlignment)value;
                        //NativeControl.HorizontalSnapPointsAlignmentProperty = HorizontalSnapPointsAlignment;
                    }
                    break;

                    case nameof(HorizontalSnapPointsType):
                    if (!Equals(HorizontalSnapPointsType, value))
                    {
                        HorizontalSnapPointsType = (AC.Primitives.SnapPointsType)value;
                        //NativeControl.HorizontalSnapPointsTypeProperty = HorizontalSnapPointsType;
                    }
                    break;

                    case nameof(IsDeferredScrollingEnabled):
                    if (!Equals(IsDeferredScrollingEnabled, value))
                    {
                        IsDeferredScrollingEnabled = (bool)value;
                        //NativeControl.IsDeferredScrollingEnabledProperty = IsDeferredScrollingEnabled;
                    }
                    break;

                    case nameof(IsScrollChainingEnabled):
                    if (!Equals(IsScrollChainingEnabled, value))
                    {
                        IsScrollChainingEnabled = (bool)value;
                        //NativeControl.IsScrollChainingEnabledProperty = IsScrollChainingEnabled;
                    }
                    break;

                    case nameof(IsScrollInertiaEnabled):
                    if (!Equals(IsScrollInertiaEnabled, value))
                    {
                        IsScrollInertiaEnabled = (bool)value;
                        //NativeControl.IsScrollInertiaEnabledProperty = IsScrollInertiaEnabled;
                    }
                    break;

                    case nameof(VerticalScrollBarVisibility):
                    if (!Equals(VerticalScrollBarVisibility, value))
                    {
                        VerticalScrollBarVisibility = (AC.Primitives.ScrollBarVisibility)value;
                        //NativeControl.VerticalScrollBarVisibilityProperty = VerticalScrollBarVisibility;
                    }
                    break;

                    case nameof(VerticalSnapPointsAlignment):
                    if (!Equals(VerticalSnapPointsAlignment, value))
                    {
                        VerticalSnapPointsAlignment = (AC.Primitives.SnapPointsAlignment)value;
                        //NativeControl.VerticalSnapPointsAlignmentProperty = VerticalSnapPointsAlignment;
                    }
                    break;

                    case nameof(VerticalSnapPointsType):
                    if (!Equals(VerticalSnapPointsType, value))
                    {
                        VerticalSnapPointsType = (AC.Primitives.SnapPointsType)value;
                        //NativeControl.VerticalSnapPointsTypeProperty = VerticalSnapPointsType;
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
                if (AllowAutoHide == Avalonia.Controls.ScrollViewer.AllowAutoHideProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetAllowAutoHide((Avalonia.Controls.Control)parentElement, AllowAutoHide);
                }
                
                if (BringIntoViewOnFocusChange == Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetBringIntoViewOnFocusChange((Avalonia.Controls.Control)parentElement, BringIntoViewOnFocusChange);
                }
                
                if (HorizontalScrollBarVisibility == Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetHorizontalScrollBarVisibility((Avalonia.Controls.Control)parentElement, HorizontalScrollBarVisibility);
                }
                
                if (HorizontalSnapPointsAlignment == Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsAlignment((Avalonia.Controls.Control)parentElement, HorizontalSnapPointsAlignment);
                }
                
                if (HorizontalSnapPointsType == Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsType((Avalonia.Controls.Control)parentElement, HorizontalSnapPointsType);
                }
                
                if (IsDeferredScrollingEnabled == Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetIsDeferredScrollingEnabled((Avalonia.Controls.Control)parentElement, IsDeferredScrollingEnabled);
                }
                
                if (IsScrollChainingEnabled == Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetIsScrollChainingEnabled((Avalonia.Controls.Control)parentElement, IsScrollChainingEnabled);
                }
                
                if (IsScrollInertiaEnabled == Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetIsScrollInertiaEnabled((Avalonia.Controls.Control)parentElement, IsScrollInertiaEnabled);
                }
                
                if (VerticalScrollBarVisibility == Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetVerticalScrollBarVisibility((Avalonia.Controls.Control)parentElement, VerticalScrollBarVisibility);
                }
                
                if (VerticalSnapPointsAlignment == Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsAlignment((Avalonia.Controls.Control)parentElement, VerticalSnapPointsAlignment);
                }
                
                if (VerticalSnapPointsType == Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsType((Avalonia.Controls.Control)parentElement, VerticalSnapPointsType);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                AllowAutoHide = AllowAutoHide != default ? AllowAutoHide : Avalonia.Controls.ScrollViewer.AllowAutoHideProperty.GetDefaultValue(parentType);
                BringIntoViewOnFocusChange = BringIntoViewOnFocusChange != default ? BringIntoViewOnFocusChange : Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty.GetDefaultValue(parentType);
                HorizontalScrollBarVisibility = HorizontalScrollBarVisibility != default ? HorizontalScrollBarVisibility : Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty.GetDefaultValue(parentType);
                HorizontalSnapPointsAlignment = HorizontalSnapPointsAlignment != default ? HorizontalSnapPointsAlignment : Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty.GetDefaultValue(parentType);
                HorizontalSnapPointsType = HorizontalSnapPointsType != default ? HorizontalSnapPointsType : Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty.GetDefaultValue(parentType);
                IsDeferredScrollingEnabled = IsDeferredScrollingEnabled != default ? IsDeferredScrollingEnabled : Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty.GetDefaultValue(parentType);
                IsScrollChainingEnabled = IsScrollChainingEnabled != default ? IsScrollChainingEnabled : Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty.GetDefaultValue(parentType);
                IsScrollInertiaEnabled = IsScrollInertiaEnabled != default ? IsScrollInertiaEnabled : Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty.GetDefaultValue(parentType);
                VerticalScrollBarVisibility = VerticalScrollBarVisibility != default ? VerticalScrollBarVisibility : Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty.GetDefaultValue(parentType);
                VerticalSnapPointsAlignment = VerticalSnapPointsAlignment != default ? VerticalSnapPointsAlignment : Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty.GetDefaultValue(parentType);
                VerticalSnapPointsType = VerticalSnapPointsType != default ? VerticalSnapPointsType : Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                AllowAutoHide = Avalonia.Controls.ScrollViewer.AllowAutoHideProperty.GetDefaultValue(parentType);
                BringIntoViewOnFocusChange = Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty.GetDefaultValue(parentType);
                HorizontalScrollBarVisibility = Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty.GetDefaultValue(parentType);
                HorizontalSnapPointsAlignment = Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty.GetDefaultValue(parentType);
                HorizontalSnapPointsType = Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty.GetDefaultValue(parentType);
                IsDeferredScrollingEnabled = Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty.GetDefaultValue(parentType);
                IsScrollChainingEnabled = Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty.GetDefaultValue(parentType);
                IsScrollInertiaEnabled = Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty.GetDefaultValue(parentType);
                VerticalScrollBarVisibility = Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty.GetDefaultValue(parentType);
                VerticalSnapPointsAlignment = Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty.GetDefaultValue(parentType);
                VerticalSnapPointsType = Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty.GetDefaultValue(parentType);

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
