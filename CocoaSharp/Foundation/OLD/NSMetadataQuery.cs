using ObjectiveC;
    /// Posted when the receiver has finished with the initial result-gathering phase of the query.
    /// </summary>
    [iOSVersion(5)]
    public class NSMetadataQueryDidFinishGatheringNotification : NSNotification
    {
        public NSMetadataQueryDidFinishGatheringNotification() : base("", null) { }
    }

    /// <summary>
    /// Posted when the receiver begins with the initial result-gathering phase of the query.
    /// </summary>
    [iOSVersion(5)]
    public class NSMetadataQueryDidStartGatheringNotification : NSNotification
    {
        public NSMetadataQueryDidStartGatheringNotification() : base("", null) { }
    }

    /// <summary>
    /// Posted when the receiver’s results have changed during the live-update phase of the query.
    /// </summary>
    [iOSVersion(5)]
    public class NSMetadataQueryDidUpdateNotification : NSNotification
    {
        public NSMetadataQueryDidUpdateNotification() : base("", null) { }
    }

    /// <summary>
    /// Posted as the receiver’s is collecting results during the initial result-gathering phase of the query.
    /// </summary>
    [iOSVersion(5)]
    public class NSMetadataQueryGatheringProgressNotification : NSNotification
    {
        public NSMetadataQueryGatheringProgressNotification() : base("", null) { }
    }
