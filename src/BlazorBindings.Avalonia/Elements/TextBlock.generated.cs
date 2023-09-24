// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// A control that displays a block of text.
    /// </summary>
    public partial class TextBlock : Control
    {
        static TextBlock()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a brush used to paint the control's background.
        /// </summary>
        [Parameter] public global::Avalonia.Media.IBrush Background { get; set; }
        /// <summary>
        /// The BaselineOffset property provides an adjustment to baseline offset
        /// </summary>
        [Parameter] public double? BaselineOffset { get; set; }
        /// <summary>
        /// Gets or sets the font family used to draw the control's text.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontFamily FontFamily { get; set; }
        /// <summary>
        /// Gets or sets the size of the control's text in points.
        /// </summary>
        [Parameter] public double? FontSize { get; set; }
        /// <summary>
        /// Gets or sets the font stretch used to draw the control's text.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontStretch? FontStretch { get; set; }
        /// <summary>
        /// Gets or sets the font style used to draw the control's text.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontStyle? FontStyle { get; set; }
        /// <summary>
        /// Gets or sets the font weight used to draw the control's text.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontWeight? FontWeight { get; set; }
        /// <summary>
        /// Gets or sets the brush used to draw the control's text and other foreground elements.
        /// </summary>
        [Parameter] public global::Avalonia.Media.IBrush Foreground { get; set; }
        /// <summary>
        /// Gets or sets the inlines.
        /// </summary>
        [Parameter] public AC.Documents.InlineCollection Inlines { get; set; }
        /// <summary>
        /// Gets or sets the letter spacing.
        /// </summary>
        [Parameter] public double? LetterSpacing { get; set; }
        /// <summary>
        /// Gets or sets the height of each line of content.
        /// </summary>
        [Parameter] public double? LineHeight { get; set; }
        /// <summary>
        /// Gets or sets the maximum number of text lines.
        /// </summary>
        [Parameter] public int? MaxLines { get; set; }
        /// <summary>
        /// Gets or sets the padding to place around the <see cref="P:Avalonia.Controls.TextBlock.Text" />.
        /// </summary>
        [Parameter] public global::Avalonia.Thickness? Padding { get; set; }
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [Parameter] public string Text { get; set; }
        /// <summary>
        /// Gets or sets the text alignment.
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextAlignment? TextAlignment { get; set; }
        /// <summary>
        /// Gets or sets the text decorations.
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextDecorationCollection TextDecorations { get; set; }
        /// <summary>
        /// Gets or sets the control's text trimming mode.
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextTrimming TextTrimming { get; set; }
        /// <summary>
        /// Gets or sets the control's text wrapping mode.
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextWrapping? TextWrapping { get; set; }

        public new AC.TextBlock NativeControl => (AC.TextBlock)((BindableObject)this).NativeControl;

        protected override AC.TextBlock CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Background):
                    if (!Equals(Background, value))
                    {
                        Background = (global::Avalonia.Media.IBrush)value;
                        NativeControl.Background = Background;
                    }
                    break;
                case nameof(BaselineOffset):
                    if (!Equals(BaselineOffset, value))
                    {
                        BaselineOffset = (double?)value;
                        NativeControl.BaselineOffset = BaselineOffset ?? (double)AC.TextBlock.BaselineOffsetProperty.GetDefaultValue(AC.TextBlock.BaselineOffsetProperty.OwnerType);
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (global::Avalonia.Media.FontFamily)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double?)value;
                        NativeControl.FontSize = FontSize ?? (double)AC.TextBlock.FontSizeProperty.GetDefaultValue(AC.TextBlock.FontSizeProperty.OwnerType);
                    }
                    break;
                case nameof(FontStretch):
                    if (!Equals(FontStretch, value))
                    {
                        FontStretch = (global::Avalonia.Media.FontStretch?)value;
                        NativeControl.FontStretch = FontStretch ?? (global::Avalonia.Media.FontStretch)AC.TextBlock.FontStretchProperty.GetDefaultValue(AC.TextBlock.FontStretchProperty.OwnerType);
                    }
                    break;
                case nameof(FontStyle):
                    if (!Equals(FontStyle, value))
                    {
                        FontStyle = (global::Avalonia.Media.FontStyle?)value;
                        NativeControl.FontStyle = FontStyle ?? (global::Avalonia.Media.FontStyle)AC.TextBlock.FontStyleProperty.GetDefaultValue(AC.TextBlock.FontStyleProperty.OwnerType);
                    }
                    break;
                case nameof(FontWeight):
                    if (!Equals(FontWeight, value))
                    {
                        FontWeight = (global::Avalonia.Media.FontWeight?)value;
                        NativeControl.FontWeight = FontWeight ?? (global::Avalonia.Media.FontWeight)AC.TextBlock.FontWeightProperty.GetDefaultValue(AC.TextBlock.FontWeightProperty.OwnerType);
                    }
                    break;
                case nameof(Foreground):
                    if (!Equals(Foreground, value))
                    {
                        Foreground = (global::Avalonia.Media.IBrush)value;
                        NativeControl.Foreground = Foreground;
                    }
                    break;
                case nameof(Inlines):
                    if (!Equals(Inlines, value))
                    {
                        Inlines = (AC.Documents.InlineCollection)value;
                        NativeControl.Inlines = Inlines;
                    }
                    break;
                case nameof(LetterSpacing):
                    if (!Equals(LetterSpacing, value))
                    {
                        LetterSpacing = (double?)value;
                        NativeControl.LetterSpacing = LetterSpacing ?? (double)AC.TextBlock.LetterSpacingProperty.GetDefaultValue(AC.TextBlock.LetterSpacingProperty.OwnerType);
                    }
                    break;
                case nameof(LineHeight):
                    if (!Equals(LineHeight, value))
                    {
                        LineHeight = (double?)value;
                        NativeControl.LineHeight = LineHeight ?? (double)AC.TextBlock.LineHeightProperty.GetDefaultValue(AC.TextBlock.LineHeightProperty.OwnerType);
                    }
                    break;
                case nameof(MaxLines):
                    if (!Equals(MaxLines, value))
                    {
                        MaxLines = (int?)value;
                        NativeControl.MaxLines = MaxLines ?? (int)AC.TextBlock.MaxLinesProperty.GetDefaultValue(AC.TextBlock.MaxLinesProperty.OwnerType);
                    }
                    break;
                case nameof(Padding):
                    if (!Equals(Padding, value))
                    {
                        Padding = (global::Avalonia.Thickness?)value;
                        NativeControl.Padding = Padding ?? (global::Avalonia.Thickness)AC.TextBlock.PaddingProperty.GetDefaultValue(AC.TextBlock.PaddingProperty.OwnerType);
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(TextAlignment):
                    if (!Equals(TextAlignment, value))
                    {
                        TextAlignment = (global::Avalonia.Media.TextAlignment?)value;
                        NativeControl.TextAlignment = TextAlignment ?? (global::Avalonia.Media.TextAlignment)AC.TextBlock.TextAlignmentProperty.GetDefaultValue(AC.TextBlock.TextAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(TextDecorations):
                    if (!Equals(TextDecorations, value))
                    {
                        TextDecorations = (global::Avalonia.Media.TextDecorationCollection)value;
                        NativeControl.TextDecorations = TextDecorations;
                    }
                    break;
                case nameof(TextTrimming):
                    if (!Equals(TextTrimming, value))
                    {
                        TextTrimming = (global::Avalonia.Media.TextTrimming)value;
                        NativeControl.TextTrimming = TextTrimming;
                    }
                    break;
                case nameof(TextWrapping):
                    if (!Equals(TextWrapping, value))
                    {
                        TextWrapping = (global::Avalonia.Media.TextWrapping?)value;
                        NativeControl.TextWrapping = TextWrapping ?? (global::Avalonia.Media.TextWrapping)AC.TextBlock.TextWrappingProperty.GetDefaultValue(AC.TextBlock.TextWrappingProperty.OwnerType);
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