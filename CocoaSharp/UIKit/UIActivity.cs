using ObjectiveC;
        public static UIActivityCategory ActivityCategory() { return UIActivityCategory.Action; }

    /// <summary>
    /// Activities have a defined category, and the activity UI may show activities grouped by category.
    /// </summary>
    public enum UIActivityCategory
    {
        /// <summary>
        /// Activities whose primary purpose is to take an action on the selected item. For example, copying an image, or saving it to the camera roll.
        /// </summary>
        [iOSVersion(7)]
        Action,

        /// <summary>
        /// Activities whose primary purpose is to share the selected item. For example, sending an image by email.
        /// </summary>
        [iOSVersion(7)]
        Share,
    }