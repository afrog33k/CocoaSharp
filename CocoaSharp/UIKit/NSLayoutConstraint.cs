using CoreGraphics;
using ObjectiveC;
        /// !! IMPORTANT !! do not name the parameters here!
        /// 
    }

    /// <summary>
    /// Describes the relation between the first attribute and the modified second attribute in a constraint.
    /// </summary>
    public enum NSLayoutRelation
    {
        /// <summary>
        /// The constraint requires that the first attribute be less than or equal to the modified second attribute.
        /// </summary>
        [iOSVersion(6)]
        LessThanOrEqual,

        /// <summary>
        /// The constraint requires that the first attribute be exactly equal to the modified second attribute.
        /// </summary>
        [iOSVersion(6)]
        Equal,

        /// <summary>
        /// The constraint requires that the first attribute by greater than or equal to the modified second attribute.
        /// </summary>
        [iOSVersion(6)]
        GreaterThanOrEqual,
    }
    /// <summary>
    /// Layout attributes are used to specify the part of the object’s visual representation that should be used to get the value for the constraint.
    /// </summary>
    public enum NSLayoutAttribute
    {
        /// <summary>
        /// The left side of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        Left,

        /// <summary>
        /// The right side of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        Right,

        /// <summary>
        /// The top of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        Top,

        /// <summary>
        /// The bottom of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        Bottom,

        /// <summary>
        /// The leading edge of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        Leading,

        /// <summary>
        /// The trailing edge of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        Trailing,

        /// <summary>
        /// The width of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        Width,

        /// <summary>
        /// The height of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        Height,

        /// <summary>
        /// The center along the x-axis of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        CenterX,

        /// <summary>
        /// The center along the y-axis of the object’s alignment rectangle.
        /// </summary>
        [iOSVersion(6)]
        CenterY,

        /// <summary>
        /// The object’s baseline.
        /// </summary>
        [iOSVersion(6)]
        Baseline,
        FirstBaseline,

        /// <summary>
        /// The requested attribute does not exist. This result would be returned if you asked a constraint with no second object for the attribute of its second object.
        /// </summary>
        [iOSVersion(6)]
        NotAnAttribute,
    }
    /// <summary>
    /// A bit mask that specifies both a part of an interface element to align and a direction for the alignment between two interface elements.
    /// </summary>
    public enum NSLayoutFormatOptions
    {
        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeLeft on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllLeft,

        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeRight on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllRight,

        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeTop on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllTop,

        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeBottom on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllBottom,

        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeLeading on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllLeading,

        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeTrailing on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllTrailing,

        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeCenterX on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllCenterX,

        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeCenterY on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllCenterY,

        /// <summary>
        /// Align all specified interface elements using NSLayoutAttributeBaseline on each.
        /// </summary>
        [iOSVersion(6)]
        AlignAllBaseline,
        AlignAllLastBaseline,
        AlignAllFirstBaseline,

        /// <summary>
        /// Bit mask that can be combined with a NSLayoutFormatOptions variable to yield only the alignment portion of the format options.
        /// </summary>
        [iOSVersion(6)]
        AlignmentMask,

        /// <summary>
        /// Arrange objects in order based on the normal text flow for the current user interface language. In English this results in the first object being placed farthest to the left, the next one to its right, and so on. In right to left languages this ordering is reversed.
        /// </summary>
        [iOSVersion(6)]
        DirectionLeadingToTrailing,

        /// <summary>
        /// Arrange objects in order from left to right.
        /// </summary>
        [iOSVersion(6)]
        DirectionLeftToRight,

        /// <summary>
        /// Arrange objects in order from right to left.
        /// </summary>
        [iOSVersion(6)]
        DirectionRightToLeft,

        /// <summary>
        /// Bit mask that can be combined with a NSLayoutFormatOptions variable to yield only the direction portion of the format options.
        /// </summary>
        [iOSVersion(6)]
        DirectionMask,
    }