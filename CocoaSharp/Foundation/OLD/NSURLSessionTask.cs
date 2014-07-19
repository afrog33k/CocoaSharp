using ObjectiveC;

    /// <summary>
    /// Constants for determining the current state of a task.
    /// </summary>
    [iOSVersion(7)]
    public enum NSURLSessionTaskState
    {
        Running,
        Suspended,
        Canceling,
        Completed
    }
}