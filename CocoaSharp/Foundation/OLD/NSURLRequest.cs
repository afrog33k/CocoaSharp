using ObjectiveC;

    /// <summary>
    /// These constants are used to specify interaction with the cached responses.
    /// </summary>
    [iOSVersion(2)]
    public enum NSURLRequestCachePolicy
    {
        UseProtocolCachePolicy,
        ReloadIgnoringLocalCacheData,
        ReloadIgnoringLocalAndRemoteCacheData,
        ReturnCacheDataElseLoad,
        ReturnCacheDataDontLoad,
        ReloadRevalidatingCacheData
    }

    /// <summary>
    /// These constants are used to specify the network service type of a request.
    /// </summary>
    [iOSVersion(4)]
    public enum NSURLRequestNetworkServiceType
    {
        NetworkServiceTypeDefault,
        NetworkServiceTypeVoIP,
        NetworkServiceTypeVideo,
        NetworkServiceTypeBackground,
        NetworkServiceTypeVoice
    }
}