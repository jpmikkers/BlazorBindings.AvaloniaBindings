

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public static partial class CanvasExtensions
    {
        /// <summary>
        /// Defines the Left, Top, Right and Bottom attached property.
        /// </summary>
        public static AvaloniaObject CanvasAll(this AvaloniaObject element, Thickness thickness)
        {
            element.CanvasLeft(thickness.Left)
                .CanvasTop(thickness.Top)
                .CanvasRight(thickness.Right)
                .CanvasBottom(thickness.Bottom);
        
            return element;
        }

        /// <summary>
        /// Defines the Left, Top, Right and Bottom attached property.
        /// </summary>
        public static AvaloniaObject CanvasAll(this AvaloniaObject element, double left, double top, double right, double bottom)
        {
            element.CanvasLeft(left)
                .CanvasTop(top)
                .CanvasRight(right)
                .CanvasBottom(bottom);

            return element;
        }
    }
}
