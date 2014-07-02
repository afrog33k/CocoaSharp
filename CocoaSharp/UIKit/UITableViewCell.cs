using CoreGraphics;
using ObjectiveC;
    }

    /// <summary>
    /// An enumeration for the various styles of cells.
    /// </summary>
    public enum UITableViewCellStyle
    {
        /// <summary>
        /// A simple style for a cell with a text label (black and left-aligned) and an optional image view. Note that this is the default style for cells prior to iOS 3.0.
        /// </summary>
        [iOSVersion(3)]
        Default,

        /// <summary>
        /// A style for a cell with a label on the left side of the cell with left-aligned and black text; on the right side is a label that has smaller blue text and is right-aligned. The Settings application uses cells in this style.
        /// </summary>
        [iOSVersion(3)]
        Value1,

        /// <summary>
        /// A style for a cell with a label on the left side of the cell with text that is right-aligned and blue; on the right side of the cell is another label with smaller text that is left-aligned and black. The Phone/Contacts application uses cells in this style.
        /// </summary>
        [iOSVersion(3)]
        Value2,

        /// <summary>
        /// A style for a cell with a left-aligned label across the top and a left-aligned label below it in smaller gray text. The iPod application uses cells in this style.
        /// </summary>
        [iOSVersion(3)]
        Subtitle,
    }
    /// <summary>
    /// The style of selected cells.
    /// </summary>
    public enum UITableViewCellSelectionStyle
    {
        /// <summary>
        /// The cell has no distinct style for when it is selected.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// The cell has a default background color when selected.
        /// </summary>
        [iOSVersion(2)]
        Blue,

        /// <summary>
        /// Then cell when selected has a gray background.
        /// </summary>
        [iOSVersion(2)]
        Gray,

        /// <summary>
        /// The cell selection style to use for tables. This is the default value.
        /// </summary>
        [iOSVersion(7)]
        Default,
    }
    /// <summary>
    /// The editing control used by a cell.
    /// </summary>
    public enum UITableViewCellEditingStyle
    {
        /// <summary>
        /// The cell has no editing control. This is the default value.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// The cell has the delete editing control; this control is a red circle enclosing a minus sign.
        /// </summary>
        [iOSVersion(2)]
        Delete,

        /// <summary>
        /// The cell has the insert editing control; this control is a green circle enclosing a plus sign.
        /// </summary>
        [iOSVersion(2)]
        Insert,
    }
    /// <summary>
    /// The type of standard accessory control used by a cell.
    /// </summary>
    public enum UITableViewCellAccessoryType
    {
        /// <summary>
        /// The cell does not have any accessory view. This is the default value.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// The cell has an accessory control shaped like a chevron. This control indicates that tapping the cell triggers a push action. The control does not track touches.
        /// </summary>
        [iOSVersion(2)]
        DisclosureIndicator,

        /// <summary>
        /// The cell has an info button and a chevron image as content. This control indicates that tapping the cell allows the user to configure the cell’s contents. The control tracks touches.
        /// </summary>
        [iOSVersion(2)]
        DetailDisclosureButton,

        /// <summary>
        /// The cell has a check mark on its right side. This control does not track touches. The delegate of the table view can manage check marks in a section of rows (possibly limiting the check mark to one row of the section) in its tableView:didSelectRowAtIndexPath: method.
        /// </summary>
        [iOSVersion(2)]
        Checkmark,

        /// <summary>
        /// The cell has an info button without a chevron. This control indicates that tapping the cell displays additional information about the cell’s contents. The control tracks touches.
        /// </summary>
        [iOSVersion(7)]
        DetailButton,
    }
    /// <summary>
    /// Constants used to determine the new state of a cell as it transitions between states.
    /// </summary>
    public enum UITableViewCellStateMask
    {
        /// <summary>
        /// The normal state of a table cell.
        /// </summary>
        [iOSVersion(3)]
        DefaultMask,

        /// <summary>
        /// The state of a table view cell when the table view is in editing mode.
        /// </summary>
        [iOSVersion(3)]
        ShowingEditControlMask,

        /// <summary>
        /// The state of a table view cell that shows a button requesting confirmation of a delete gesture.
        /// </summary>
        [iOSVersion(3)]
        ShowingDeleteConfirmationMask,
    }
    /// <summary>
    /// The style for cells used as separators.
    /// </summary>
    public enum UITableViewCellSeparatorStyle
    {
        /// <summary>
        /// The separator cell has no distinct style.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// The separator cell has a single line running across its width. This is the default value
        /// </summary>
        [iOSVersion(2)]
        SingleLine,

        /// <summary>
        /// The separator cell has double lines running across its width, giving it an etched look. This style is currently only supported for grouped-style table views.
        /// </summary>
        [iOSVersion(3.2)]
        SingleLineEtched,
    }