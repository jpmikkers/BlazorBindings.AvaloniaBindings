// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using CMV = CommunityToolkit.Maui.Views;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.CommunityToolkit
{
    public partial class AvatarView : BlazorBindings.Maui.Elements.Border
    {
        static AvatarView()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public Color BorderColor { get; set; }
        [Parameter] public double? BorderWidth { get; set; }
        [Parameter] public double? CharacterSpacing { get; set; }
        [Parameter] public CornerRadius? CornerRadius { get; set; }
        [Parameter] public MC.FontAttributes? FontAttributes { get; set; }
        [Parameter] public bool? FontAutoScalingEnabled { get; set; }
        [Parameter] public string FontFamily { get; set; }
        [Parameter] public double? FontSize { get; set; }
        [Parameter] public MC.ImageSource ImageSource { get; set; }
        [Parameter] public string Text { get; set; }
        [Parameter] public Color TextColor { get; set; }
        [Parameter] public TextTransform? TextTransform { get; set; }

        public new CMV.AvatarView NativeControl => (CMV.AvatarView)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new CMV.AvatarView();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(BorderColor):
                    if (!Equals(BorderColor, value))
                    {
                        BorderColor = (Color)value;
                        NativeControl.BorderColor = BorderColor;
                    }
                    break;
                case nameof(BorderWidth):
                    if (!Equals(BorderWidth, value))
                    {
                        BorderWidth = (double?)value;
                        NativeControl.BorderWidth = BorderWidth ?? (double)CMV.AvatarView.BorderWidthProperty.DefaultValue;
                    }
                    break;
                case nameof(CharacterSpacing):
                    if (!Equals(CharacterSpacing, value))
                    {
                        CharacterSpacing = (double?)value;
                        NativeControl.CharacterSpacing = CharacterSpacing ?? default;
                    }
                    break;
                case nameof(CornerRadius):
                    if (!Equals(CornerRadius, value))
                    {
                        CornerRadius = (CornerRadius?)value;
                        NativeControl.CornerRadius = CornerRadius ?? (CornerRadius)CMV.AvatarView.CornerRadiusProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAttributes):
                    if (!Equals(FontAttributes, value))
                    {
                        FontAttributes = (MC.FontAttributes?)value;
                        NativeControl.FontAttributes = FontAttributes ?? (MC.FontAttributes)CMV.AvatarView.FontAttributesProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAutoScalingEnabled):
                    if (!Equals(FontAutoScalingEnabled, value))
                    {
                        FontAutoScalingEnabled = (bool?)value;
                        NativeControl.FontAutoScalingEnabled = FontAutoScalingEnabled ?? (bool)CMV.AvatarView.FontAutoScalingEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (string)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double?)value;
                        NativeControl.FontSize = FontSize ?? (double)CMV.AvatarView.FontSizeProperty.DefaultValue;
                    }
                    break;
                case nameof(ImageSource):
                    if (!Equals(ImageSource, value))
                    {
                        ImageSource = (MC.ImageSource)value;
                        NativeControl.ImageSource = ImageSource;
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;
                case nameof(TextTransform):
                    if (!Equals(TextTransform, value))
                    {
                        TextTransform = (TextTransform?)value;
                        NativeControl.TextTransform = TextTransform ?? (TextTransform)CMV.AvatarView.TextTransformProperty.DefaultValue;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}