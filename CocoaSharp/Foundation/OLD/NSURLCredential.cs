using ObjectiveC;
        /// !! IMPORTANT !! Name the parameter you're using
        /// 
        /// Creates and returns an NSURLCredential object for server trust authentication with a given accepted trust.
        /// Returns an NSURLCredential object for server trust authentication initialized with a given accepted trust.
        /// <param name="forTrust">The accepted trust.</param>
        /// <param name="trust">The accepted trust.</param>
        public NSURLCredential(SecTrust forTrust = null, SecTrust trust = null) { }

    /// <summary>
    /// These constants specify how long the credential will be kept.
    /// </summary>
    [iOSVersion(2)]
    public enum NSURLCredentialPersistence
    {
        None,
        ForSession,
        Permanent,
        Synchronizable
    }
}