// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using MCM = Material.Components.Maui;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements.Material.Components
{
    public partial class MDNavigationDrawer : BlazorBindings.Maui.Elements.TemplatedView
    {
        static MDNavigationDrawer()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MCM.DrawerDisplayMode? DisplayMode { get; set; }
        [Parameter] public bool? HasToolBar { get; set; }
        [Parameter] public bool? IsPaneOpen { get; set; }
        [Parameter] public Color PaneBackGroundColour { get; set; }
        [Parameter] public double? PaneWidth { get; set; }
        [Parameter] public global::IconPacks.Material.IconKind? SwitchIcon { get; set; }
        [Parameter] public string Title { get; set; }
        [Parameter] public Color ToolBarBackGroundColour { get; set; }
        [Parameter] public RenderFragment FooterItems { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }

        public new MCM.NavigationDrawer NativeControl => (MCM.NavigationDrawer)((BindableObject)this).NativeControl;

        protected override MCM.NavigationDrawer CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(DisplayMode):
                    if (!Equals(DisplayMode, value))
                    {
                        DisplayMode = (MCM.DrawerDisplayMode?)value;
                        NativeControl.DisplayMode = DisplayMode ?? (MCM.DrawerDisplayMode)MCM.NavigationDrawer.DisplayModeProperty.DefaultValue;
                    }
                    break;
                case nameof(HasToolBar):
                    if (!Equals(HasToolBar, value))
                    {
                        HasToolBar = (bool?)value;
                        NativeControl.HasToolBar = HasToolBar ?? (bool)MCM.NavigationDrawer.HasToolBarProperty.DefaultValue;
                    }
                    break;
                case nameof(IsPaneOpen):
                    if (!Equals(IsPaneOpen, value))
                    {
                        IsPaneOpen = (bool?)value;
                        NativeControl.IsPaneOpen = IsPaneOpen ?? (bool)MCM.NavigationDrawer.IsPaneOpenProperty.DefaultValue;
                    }
                    break;
                case nameof(PaneBackGroundColour):
                    if (!Equals(PaneBackGroundColour, value))
                    {
                        PaneBackGroundColour = (Color)value;
                        NativeControl.PaneBackGroundColour = PaneBackGroundColour;
                    }
                    break;
                case nameof(PaneWidth):
                    if (!Equals(PaneWidth, value))
                    {
                        PaneWidth = (double?)value;
                        NativeControl.PaneWidth = PaneWidth ?? (double)MCM.NavigationDrawer.PaneWidthProperty.DefaultValue;
                    }
                    break;
                case nameof(SwitchIcon):
                    if (!Equals(SwitchIcon, value))
                    {
                        SwitchIcon = (global::IconPacks.Material.IconKind?)value;
                        NativeControl.SwitchIcon = SwitchIcon ?? (global::IconPacks.Material.IconKind)MCM.NavigationDrawer.SwitchIconProperty.DefaultValue;
                    }
                    break;
                case nameof(Title):
                    if (!Equals(Title, value))
                    {
                        Title = (string)value;
                        NativeControl.Title = Title;
                    }
                    break;
                case nameof(ToolBarBackGroundColour):
                    if (!Equals(ToolBarBackGroundColour, value))
                    {
                        ToolBarBackGroundColour = (Color)value;
                        NativeControl.ToolBarBackGroundColour = ToolBarBackGroundColour;
                    }
                    break;
                case nameof(FooterItems):
                    FooterItems = (RenderFragment)value;
                    break;
                case nameof(ChildContent):
                    ChildContent = (RenderFragment)value;
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddListContentProperty<MCM.NavigationDrawer, MC.View>(builder, sequence++, FooterItems, x => x.FooterItems);
            RenderTreeBuilderHelper.AddListContentProperty<MCM.NavigationDrawer, MC.View>(builder, sequence++, ChildContent, x => x.Items);
        }

        static partial void RegisterAdditionalHandlers();
    }
}