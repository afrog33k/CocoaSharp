using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// The types of edges that participate in collisions for a collision behavior.
    /// </summary>
    public enum UICollisionBehaviorMode
    {
        /// <summary>
        /// Specifies that the dynamic items, associated with the collision behavior, collide only with each other and not with specified collision boundaries.
        /// </summary>
        [iOSVersion(7)]
        Items,

        /// <summary>
        /// Specifies that the dynamic items, associated with the collision behavior, collide only with specified collision boundaries and do not collide with each other.
        /// </summary>
        [iOSVersion(7)]
        Boundaries,

        /// <summary>
        /// Specifies that the dynamic items, associated with the collision behavior, collide with each other and with specified collision boundaries.
        /// </summary>
        [iOSVersion(7)]
        Everything,
    }