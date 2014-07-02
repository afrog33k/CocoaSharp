using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// The type of force for the push behavior.
    /// </summary>
    public enum UIPushBehaviorMode
    {
        /// <summary>
        /// Option for continuous force.
        /// </summary>
        [iOSVersion(7)]
        Continuous,

        /// <summary>
        /// Option for instantaneous force.
        /// </summary>
        [iOSVersion(7)]
        Instantaneous,
    }