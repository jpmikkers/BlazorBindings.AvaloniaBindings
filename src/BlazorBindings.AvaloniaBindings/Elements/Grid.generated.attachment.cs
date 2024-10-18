

namespace BlazorBindings.AvaloniaBindings.Elements
{
    
    internal static class GridInitializer
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void RegisterAdditionalHandlers()
        {
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("Grid.Column",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.Grid.ColumnProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Grid.SetColumn((Avalonia.Controls.Control)element, (int)Convert.ChangeType(value, typeof(int)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("Grid.ColumnSpan",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.Grid.ColumnSpanProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Grid.SetColumnSpan((Avalonia.Controls.Control)element, (int)Convert.ChangeType(value, typeof(int)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("Grid.IsSharedSizeScope",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.Grid.IsSharedSizeScopeProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Grid.SetIsSharedSizeScope((Avalonia.Controls.Control)element, (bool)Convert.ChangeType(value, typeof(bool)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("Grid.Row",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.Grid.RowProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Grid.SetRow((Avalonia.Controls.Control)element, (int)Convert.ChangeType(value, typeof(int)));
                    }
                });
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("Grid.RowSpan",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.Grid.RowSpanProperty);
                    }
                    else
                    {
                        Avalonia.Controls.Grid.SetRowSpan((Avalonia.Controls.Control)element, (int)Convert.ChangeType(value, typeof(int)));
                    }
                });
        }
    }

    public static partial class GridExtensions
    {
        /// <summary>
        /// Column property. This is an attached property. Grid defines Column property, so that it can be set on any element treated as a cell. Column property specifies child's position with respect to columns.
        /// </summary>
        public static Control GridColumn(this Control element, int value)
        {
            element.AttachedProperties["Grid.Column"] = value;
        
            return element;
        }
        /// <summary>
        /// ColumnSpan property. This is an attached property. Grid defines ColumnSpan, so that it can be set on any element treated as a cell. ColumnSpan property specifies child's width with respect to columns. Example, ColumnSpan == 2 means that child will span across two columns.
        /// </summary>
        public static Control GridColumnSpan(this Control element, int value)
        {
            element.AttachedProperties["Grid.ColumnSpan"] = value;
        
            return element;
        }
        /// <summary>
        /// IsSharedSizeScope property marks scoping element for shared size.
        /// </summary>
        public static Control GridIsSharedSizeScope(this Control element, bool value)
        {
            element.AttachedProperties["Grid.IsSharedSizeScope"] = value;
        
            return element;
        }
        /// <summary>
        /// Row property. This is an attached property. Grid defines Row, so that it can be set on any element treated as a cell. Row property specifies child's position with respect to rows. <remarks><para> Rows are 0 - based. In order to appear in first row, element should have Row property set to <c>0</c>. </para><para> Default value for the property is <c>0</c>. </para></remarks>
        /// </summary>
        public static Control GridRow(this Control element, int value)
        {
            element.AttachedProperties["Grid.Row"] = value;
        
            return element;
        }
        /// <summary>
        /// RowSpan property. This is an attached property. Grid defines RowSpan, so that it can be set on any element treated as a cell. RowSpan property specifies child's height with respect to row grid lines. Example, RowSpan == 3 means that child will span across three rows.
        /// </summary>
        public static Control GridRowSpan(this Control element, int value)
        {
            element.AttachedProperties["Grid.RowSpan"] = value;
        
            return element;
        }
    }

    public class Grid_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Column property. This is an attached property. Grid defines Column property, so that it can be set on any element treated as a cell. Column property specifies child's position with respect to columns.
        /// </summary>
        [Parameter] public int Column { get; set; }

        /// <summary>
        /// ColumnSpan property. This is an attached property. Grid defines ColumnSpan, so that it can be set on any element treated as a cell. ColumnSpan property specifies child's width with respect to columns. Example, ColumnSpan == 2 means that child will span across two columns.
        /// </summary>
        [Parameter] public int ColumnSpan { get; set; }

        /// <summary>
        /// IsSharedSizeScope property marks scoping element for shared size.
        /// </summary>
        [Parameter] public bool IsSharedSizeScope { get; set; }

        /// <summary>
        /// Row property. This is an attached property. Grid defines Row, so that it can be set on any element treated as a cell. Row property specifies child's position with respect to rows. <remarks><para> Rows are 0 - based. In order to appear in first row, element should have Row property set to <c>0</c>. </para><para> Default value for the property is <c>0</c>. </para></remarks>
        /// </summary>
        [Parameter] public int Row { get; set; }

        /// <summary>
        /// RowSpan property. This is an attached property. Grid defines RowSpan, so that it can be set on any element treated as a cell. RowSpan property specifies child's height with respect to row grid lines. Example, RowSpan == 3 means that child will span across three rows.
        /// </summary>
        [Parameter] public int RowSpan { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(Column):
                    if (!Equals(Column, value))
                    {
                        Column = (int)value;
                        //NativeControl.ColumnProperty = Column;
                    }
                    break;

                    case nameof(ColumnSpan):
                    if (!Equals(ColumnSpan, value))
                    {
                        ColumnSpan = (int)value;
                        //NativeControl.ColumnSpanProperty = ColumnSpan;
                    }
                    break;

                    case nameof(IsSharedSizeScope):
                    if (!Equals(IsSharedSizeScope, value))
                    {
                        IsSharedSizeScope = (bool)value;
                        //NativeControl.IsSharedSizeScopeProperty = IsSharedSizeScope;
                    }
                    break;

                    case nameof(Row):
                    if (!Equals(Row, value))
                    {
                        Row = (int)value;
                        //NativeControl.RowProperty = Row;
                    }
                    break;

                    case nameof(RowSpan):
                    if (!Equals(RowSpan, value))
                    {
                        RowSpan = (int)value;
                        //NativeControl.RowSpanProperty = RowSpan;
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
                if (Column == Avalonia.Controls.Grid.ColumnProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Grid.ColumnProperty);
                }
                else
                {
                    Avalonia.Controls.Grid.SetColumn((Avalonia.Controls.Control)parentElement, Column);
                }
                
                if (ColumnSpan == Avalonia.Controls.Grid.ColumnSpanProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Grid.ColumnSpanProperty);
                }
                else
                {
                    Avalonia.Controls.Grid.SetColumnSpan((Avalonia.Controls.Control)parentElement, ColumnSpan);
                }
                
                if (IsSharedSizeScope == Avalonia.Controls.Grid.IsSharedSizeScopeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Grid.IsSharedSizeScopeProperty);
                }
                else
                {
                    Avalonia.Controls.Grid.SetIsSharedSizeScope((Avalonia.Controls.Control)parentElement, IsSharedSizeScope);
                }
                
                if (Row == Avalonia.Controls.Grid.RowProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Grid.RowProperty);
                }
                else
                {
                    Avalonia.Controls.Grid.SetRow((Avalonia.Controls.Control)parentElement, Row);
                }
                
                if (RowSpan == Avalonia.Controls.Grid.RowSpanProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Grid.RowSpanProperty);
                }
                else
                {
                    Avalonia.Controls.Grid.SetRowSpan((Avalonia.Controls.Control)parentElement, RowSpan);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Column = Column != default ? Column : Avalonia.Controls.Grid.ColumnProperty.GetDefaultValue(parentType);
                ColumnSpan = ColumnSpan != default ? ColumnSpan : Avalonia.Controls.Grid.ColumnSpanProperty.GetDefaultValue(parentType);
                IsSharedSizeScope = IsSharedSizeScope != default ? IsSharedSizeScope : Avalonia.Controls.Grid.IsSharedSizeScopeProperty.GetDefaultValue(parentType);
                Row = Row != default ? Row : Avalonia.Controls.Grid.RowProperty.GetDefaultValue(parentType);
                RowSpan = RowSpan != default ? RowSpan : Avalonia.Controls.Grid.RowSpanProperty.GetDefaultValue(parentType);

                TryUpdateParent(parentElement);
            }

            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Column = Avalonia.Controls.Grid.ColumnProperty.GetDefaultValue(parentType);
                ColumnSpan = Avalonia.Controls.Grid.ColumnSpanProperty.GetDefaultValue(parentType);
                IsSharedSizeScope = Avalonia.Controls.Grid.IsSharedSizeScopeProperty.GetDefaultValue(parentType);
                Row = Avalonia.Controls.Grid.RowProperty.GetDefaultValue(parentType);
                RowSpan = Avalonia.Controls.Grid.RowSpanProperty.GetDefaultValue(parentType);

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
