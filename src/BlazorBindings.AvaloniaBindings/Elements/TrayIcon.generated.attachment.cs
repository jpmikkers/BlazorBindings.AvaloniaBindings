

namespace BlazorBindings.AvaloniaBindings.Elements
{
    
    internal static class TrayIconInitializer
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void RegisterAdditionalHandlers()
        {
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TrayIcon.Icons",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.TrayIcon.IconsProperty);
                    }
                    else
                    {
                        Avalonia.Controls.TrayIcon.SetIcons((Avalonia.Application)element, (AC.TrayIcons)Convert.ChangeType(value, typeof(AC.TrayIcons)));
                    }
                });
        }
    }

    public static partial class TrayIconExtensions
    {
        /// <summary>
        /// Defines the <see cref="T:Avalonia.Controls.TrayIcons" /> attached property.
        /// </summary>
        public static Application TrayIconIcons(this Application element, AC.TrayIcons value)
        {
            element.AttachedProperties["TrayIcon.Icons"] = value;
        
            return element;
        }
    }

    public class TrayIcon_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the <see cref="T:Avalonia.Controls.TrayIcons" /> attached property.
        /// </summary>
        [Parameter] public AC.TrayIcons Icons { get; set; }

        private Avalonia.Application _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(Icons):
                    if (!Equals(Icons, value))
                    {
                        Icons = (AC.TrayIcons)value;
                        //NativeControl.IconsProperty = Icons;
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
                if (Icons == Avalonia.Controls.TrayIcon.IconsProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Application)parentElement).ClearValue(Avalonia.Controls.TrayIcon.IconsProperty);
                }
                else
                {
                    Avalonia.Controls.TrayIcon.SetIcons((Avalonia.Application)parentElement, Icons);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Icons = Icons != default ? Icons : Avalonia.Controls.TrayIcon.IconsProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = (Avalonia.Application)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Icons = Avalonia.Controls.TrayIcon.IconsProperty.GetDefaultValue(parentType);

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
