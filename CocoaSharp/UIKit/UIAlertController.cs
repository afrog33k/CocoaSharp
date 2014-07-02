using ObjectiveC;

namespace UIKit

    /// <summary>
    /// Constants indicating the type of alert to display.
    /// </summary>
    public enum UIAlertControllerStyle
    {
        /// <summary>
        /// An action sheet displayed in the context of the view controller that presented it.
        /// </summary>
        [iOSVersion(8)]
        ActionSheet,

        /// <summary>
        /// An alert displayed modally for the app.
        /// </summary>
        [iOSVersion(8)]
        Alert,
    }