using CoreGraphics;
using ObjectiveC;
        public CGPoint PreviousLocationInView(UIView view) { return new CGPoint(); }

    /// <summary>
    /// The phase of a finger touch.
    /// </summary>
    public enum UITouchPhase
    {
        /// <summary>
        /// A finger for a given event touched the screen.
        /// </summary>
        [iOSVersion(2)]
        Began,

        /// <summary>
        /// A finger for a given event moved on the screen.
        /// </summary>
        [iOSVersion(2)]
        Moved,

        /// <summary>
        /// A finger is touching the surface but hasn't moved since the previous event.
        /// </summary>
        [iOSVersion(2)]
        Stationary,

        /// <summary>
        /// A finger for a given event was lifted from the screen.
        /// </summary>
        [iOSVersion(2)]
        Ended,

        /// <summary>
        /// The system cancelled tracking for the touch, as when (for example) the user puts the device to his or her face.
        /// </summary>
        [iOSVersion(2)]
        Cancelled,
    }