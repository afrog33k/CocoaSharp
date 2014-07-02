using ObjectiveC;

    /// <summary>
    /// Constants indicating the type of action being performed on an item.
    /// </summary>
    public enum UICollectionUpdateAction
    {
        /// <summary>
        /// Insert the item into the collection view.
        /// </summary>
        [iOSVersion(6)]
        Insert,

        /// <summary>
        /// Remove the item from the collection view.
        /// </summary>
        [iOSVersion(6)]
        Delete,

        /// <summary>
        /// Reload the item, which consists of deleting and then inserting the item.
        /// </summary>
        [iOSVersion(6)]
        Reload,

        /// <summary>
        /// Move the item from its current location to a new location.
        /// </summary>
        [iOSVersion(6)]
        Move,

        /// <summary>
        /// Take no action on the item.
        /// </summary>
        [iOSVersion(6)]
        None,
    }