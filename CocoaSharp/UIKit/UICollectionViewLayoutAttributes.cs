using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// Constants specifying the type of view.
    /// </summary>
    public enum UICollectionElementCategory
    {
        /// <summary>
        /// The view is a cell.
        /// </summary>
        [iOSVersion(6)]
        Cell,

        /// <summary>
        /// The view is a supplementary view.
        /// </summary>
        [iOSVersion(6)]
        SupplementaryView,

        /// <summary>
        /// The view is a decoration view.
        /// </summary>
        [iOSVersion(6)]
        DecorationView,
    }