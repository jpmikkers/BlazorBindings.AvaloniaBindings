

namespace BlazorBindings.AvaloniaBindings.Elements
{
    
    internal static class DockPanelInitializer
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void RegisterAdditionalHandlers()
        {
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("DockPanel.Dock",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.DockPanel.DockProperty);
                    }
                    else
                    {
                        Avalonia.Controls.DockPanel.SetDock((Avalonia.Controls.Control)element, (AC.Dock)Convert.ChangeType(value, typeof(AC.Dock)));
                    }
                });
        }
    }

    public static partial class DockPanelExtensions
    {
        /// <summary>
        /// Defines the Dock attached property.
        /// </summary>
        public static Control DockPanelDock(this Control element, AC.Dock value)
        {
            element.AttachedProperties["DockPanel.Dock"] = value;
        
            return element;
        }
    }

    public class DockPanel_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the Dock attached property.
        /// </summary>
        [Parameter] public AC.Dock Dock { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(Dock):
                    if (!Equals(Dock, value))
                    {
                        Dock = (AC.Dock)value;
                        //NativeControl.DockProperty = Dock;
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
                if (Dock == Avalonia.Controls.DockPanel.DockProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.DockPanel.DockProperty);
                }
                else
                {
                    Avalonia.Controls.DockPanel.SetDock((Avalonia.Controls.Control)parentElement, Dock);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Dock = Dock != default ? Dock : Avalonia.Controls.DockPanel.DockProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Dock = Avalonia.Controls.DockPanel.DockProperty.GetDefaultValue(parentType);

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
