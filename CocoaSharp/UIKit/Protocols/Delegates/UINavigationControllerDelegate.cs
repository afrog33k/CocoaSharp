using ObjectiveC;

    /// <summary>
    /// These constants define the type of navigation controller transitions that can occur.
    /// </summary>
    public enum UINavigationControllerOperation
    {
        /// <summary>
        /// No operation is taking place.
        /// </summary>
        [iOSVersion(7)]
        None,

        /// <summary>
        /// A view controller is being pushed onto the navigation stack.
        /// </summary>
        [iOSVersion(7)]
        Push,

        /// <summary>
        /// The topmost view controller is being removed from the navigation stack.
        /// </summary>
        [iOSVersion(7)]
        Pop,
    }