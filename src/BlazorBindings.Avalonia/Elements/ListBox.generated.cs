// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using System.Collections;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// An <see cref="T:Avalonia.Controls.ItemsControl" /> in which individual items can be selected.
    /// </summary>
    public partial class ListBox<T> : BlazorBindings.AvaloniaBindings.Elements.Primitives.SelectingItemsControl<T>
    {
        static ListBox()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public IList SelectedItems { get; set; }
        [Parameter] public AC.Selection.ISelectionModel Selection { get; set; }
        /// <summary>
        /// Gets or sets the selection mode.
        /// </summary>
        [Parameter] public AC.SelectionMode? SelectionMode { get; set; }

        public new AC.ListBox NativeControl => (AC.ListBox)((BindableObject)this).NativeControl;

        protected override AC.ListBox CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(SelectedItems):
                    if (!Equals(SelectedItems, value))
                    {
                        SelectedItems = (IList)value;
                        NativeControl.SelectedItems = SelectedItems;
                    }
                    break;
                case nameof(Selection):
                    if (!Equals(Selection, value))
                    {
                        Selection = (AC.Selection.ISelectionModel)value;
                        NativeControl.Selection = Selection;
                    }
                    break;
                case nameof(SelectionMode):
                    if (!Equals(SelectionMode, value))
                    {
                        SelectionMode = (AC.SelectionMode?)value;
                        NativeControl.SelectionMode = SelectionMode ?? (AC.SelectionMode)AC.ListBox.SelectionModeProperty.GetDefaultValue(AC.ListBox.SelectionModeProperty.OwnerType);
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
