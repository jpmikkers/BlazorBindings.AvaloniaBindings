

namespace BlazorBindings.AvaloniaBindings.Elements
{
    
    internal static class ToolTipInitializer
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void RegisterAdditionalHandlers()
        {
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ToolTip.HorizontalOffset",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ToolTip.HorizontalOffsetProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ToolTip.SetHorizontalOffset((Avalonia.Controls.Control)element, (double)Convert.ChangeType(value, typeof(double)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ToolTip.IsOpen",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ToolTip.IsOpenProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ToolTip.SetIsOpen((Avalonia.Controls.Control)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ToolTip.Placement",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ToolTip.PlacementProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ToolTip.SetPlacement((Avalonia.Controls.Control)element, (AC.PlacementMode)Convert.ChangeType(value, typeof(AC.PlacementMode)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ToolTip.ShowDelay",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ToolTip.ShowDelayProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ToolTip.SetShowDelay((Avalonia.Controls.Control)element, (int)Convert.ChangeType(value, typeof(int)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ToolTip.ChildContent",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ToolTip.TipProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ToolTip.SetTip((Avalonia.Controls.Control)element, (object)Convert.ChangeType(value, typeof(object)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("ToolTip.VerticalOffset",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.ToolTip.VerticalOffsetProperty);
                    }
                    else
                    {
                        Avalonia.Controls.ToolTip.SetVerticalOffset((Avalonia.Controls.Control)element, (double)Convert.ChangeType(value, typeof(double)));
                    }
                });
        }
    }

    public static partial class ToolTipExtensions
    {
        /// <summary>
        /// Defines the ToolTip.HorizontalOffset property.
        /// </summary>
        public static Control ToolTipHorizontalOffset(this Control element, double value)
        {
            element.AttachedProperties["ToolTip.HorizontalOffset"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the ToolTip.IsOpen attached property.
        /// </summary>
        public static Control ToolTipIsOpen(this Control element, bool value)
        {
            element.AttachedProperties["ToolTip.IsOpen"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the ToolTip.Placement property.
        /// </summary>
        public static Control ToolTipPlacement(this Control element, AC.PlacementMode value)
        {
            element.AttachedProperties["ToolTip.Placement"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the ToolTip.ShowDelay property.
        /// </summary>
        public static Control ToolTipShowDelay(this Control element, int value)
        {
            element.AttachedProperties["ToolTip.ShowDelay"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the ToolTip.Tip attached property.
        /// </summary>
        public static Control ToolTipChildContent(this Control element, RenderFragment value)
        {
            element.AttachedProperties["ToolTip.ChildContent"] = value;
        
            return element;
        }
        /// <summary>
        /// Defines the ToolTip.VerticalOffset property.
        /// </summary>
        public static Control ToolTipVerticalOffset(this Control element, double value)
        {
            element.AttachedProperties["ToolTip.VerticalOffset"] = value;
        
            return element;
        }
    }

    public class ToolTip_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the ToolTip.HorizontalOffset property.
        /// </summary>
        [Parameter] public double HorizontalOffset { get; set; }

        /// <summary>
        /// Defines the ToolTip.IsOpen attached property.
        /// </summary>
        [Parameter] public bool IsOpen { get; set; }

        /// <summary>
        /// Defines the ToolTip.Placement property.
        /// </summary>
        [Parameter] public AC.PlacementMode Placement { get; set; }

        /// <summary>
        /// Defines the ToolTip.ShowDelay property.
        /// </summary>
        [Parameter] public int ShowDelay { get; set; }

        /// <summary>
        /// Defines the ToolTip.Tip attached property.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Defines the ToolTip.VerticalOffset property.
        /// </summary>
        [Parameter] public double VerticalOffset { get; set; }


        protected override RenderFragment GetChildContent() => ChildContent;

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(HorizontalOffset):
                    if (!Equals(HorizontalOffset, value))
                    {
                        HorizontalOffset = (double)value;
                        //NativeControl.HorizontalOffsetProperty = HorizontalOffset;
                    }
                    break;

                    case nameof(IsOpen):
                    if (!Equals(IsOpen, value))
                    {
                        IsOpen = (bool)value;
                        //NativeControl.IsOpenProperty = IsOpen;
                    }
                    break;

                    case nameof(Placement):
                    if (!Equals(Placement, value))
                    {
                        Placement = (AC.PlacementMode)value;
                        //NativeControl.PlacementProperty = Placement;
                    }
                    break;

                    case nameof(ShowDelay):
                    if (!Equals(ShowDelay, value))
                    {
                        ShowDelay = (int)value;
                        //NativeControl.ShowDelayProperty = ShowDelay;
                    }
                    break;

                    case nameof(ChildContent):
                    if (!Equals(ChildContent, value))
                    {
                        ChildContent = (RenderFragment)value;
                        //NativeControl.TipProperty = ChildContent;
                    }
                    break;

                    case nameof(VerticalOffset):
                    if (!Equals(VerticalOffset, value))
                    {
                        VerticalOffset = (double)value;
                        //NativeControl.VerticalOffsetProperty = VerticalOffset;
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
                if (HorizontalOffset == Avalonia.Controls.ToolTip.HorizontalOffsetProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.HorizontalOffsetProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetHorizontalOffset((Avalonia.Controls.Control)parentElement, HorizontalOffset);
                }
                
                if (IsOpen == Avalonia.Controls.ToolTip.IsOpenProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.IsOpenProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetIsOpen((Avalonia.Controls.Control)parentElement, IsOpen);
                }
                
                if (Placement == Avalonia.Controls.ToolTip.PlacementProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.PlacementProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetPlacement((Avalonia.Controls.Control)parentElement, Placement);
                }
                
                if (ShowDelay == Avalonia.Controls.ToolTip.ShowDelayProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.ShowDelayProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetShowDelay((Avalonia.Controls.Control)parentElement, ShowDelay);
                }
                
                if (VerticalOffset == Avalonia.Controls.ToolTip.VerticalOffsetProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.VerticalOffsetProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetVerticalOffset((Avalonia.Controls.Control)parentElement, VerticalOffset);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                HorizontalOffset = HorizontalOffset != default ? HorizontalOffset : Avalonia.Controls.ToolTip.HorizontalOffsetProperty.GetDefaultValue(parentType);
                IsOpen = IsOpen != default ? IsOpen : Avalonia.Controls.ToolTip.IsOpenProperty.GetDefaultValue(parentType);
                Placement = Placement != default ? Placement : Avalonia.Controls.ToolTip.PlacementProperty.GetDefaultValue(parentType);
                ShowDelay = ShowDelay != default ? ShowDelay : Avalonia.Controls.ToolTip.ShowDelayProperty.GetDefaultValue(parentType);
                VerticalOffset = VerticalOffset != default ? VerticalOffset : Avalonia.Controls.ToolTip.VerticalOffsetProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            if (_parent is not null)
            {
                Avalonia.Controls.ToolTip.SetTip(_parent, default);
            }

            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                HorizontalOffset = Avalonia.Controls.ToolTip.HorizontalOffsetProperty.GetDefaultValue(parentType);
                IsOpen = Avalonia.Controls.ToolTip.IsOpenProperty.GetDefaultValue(parentType);
                Placement = Avalonia.Controls.ToolTip.PlacementProperty.GetDefaultValue(parentType);
                ShowDelay = Avalonia.Controls.ToolTip.ShowDelayProperty.GetDefaultValue(parentType);
                VerticalOffset = Avalonia.Controls.ToolTip.VerticalOffsetProperty.GetDefaultValue(parentType);

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
            RenderTreeBuilderHelper.AddContentProperty<Avalonia.Controls.Control>(builder, sequence++, ChildContent,
                (nativeControl, value) =>
                {
                    if (_parent is not null)
                    {
                        Avalonia.Controls.ToolTip.SetTip(_parent, value);
                    }
                });
        }
    }
}
