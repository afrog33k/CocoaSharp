using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSURLRequest_Class/index.html#//apple_ref/occ/cl/NSURLRequest    /// <summary>    /// NSURLRequest objects represent a URL load request in a manner independent of protocol and URL scheme.    /// </summary>    [iOSVersion(2)]    public class NSURLRequest : NSObject    {        /// <summary>        /// Returns a URL request for a specified URL with default cache policy and timeout value.        /// </summary>        /// <param name="URL">The URL for the request.</param>        /// <returns>The initialized URL request.</returns>        [iOSVersion(2)]        public NSURLRequest(NSURL URL) { }                /// <summary>        /// Returns an initialized URL request with specified values.        /// </summary>        /// <param name="URL">The URL for the request.</param>        /// <param name="cachePolicy">The cache policy for the request.</param>        /// <param name="timeoutinterval">The timeout interval for the request, in seconds.</param>        /// <returns>The initialized URL request.</returns>        [iOSVersion(2)]        public NSURLRequest(NSURL URL, NSURLRequestCachePolicy cachePolicy, NSTimeinterval timeoutinterval) { }                /// <summary>        /// Returns the receiver’s cache policy.        /// </summary>        /// <returns>The receiver’s cache policy.</returns>        [iOSVersion(2)]        [Export("cachePolicy")]        public NSURLRequestCachePolicy CachePolicy { get; private set; }                /// <summary>        /// Returns whether the request should continue transmitting data before receiving a response from an earlier transmission.        /// </summary>        /// <returns>true if the request should continue transmitting data; otherwise, false.</returns>        [iOSVersion(4)]        [Export("HTTPShouldUsePipelining")]        public bool HTTPShouldUsePipelining { get; private set; }                /// <summary>        /// Returns the main document URL associated with the request.        /// </summary>        /// <returns>The main document URL associated with the request.</returns>        [iOSVersion(2)]        [Export("mainDocumentURL")]        public NSURL MainDocumentURL { get; private set; }                /// <summary>        /// Returns the receiver’s timeout interval, in seconds.        /// </summary>        /// <returns>The receiver's timeout interval, in seconds.</returns>        [iOSVersion(2)]        [Export("timeoutinterval")]        public NSTimeinterval Timeoutinterval { get; private set; }                /// <summary>        /// Returns the network service type of the request.        /// </summary>        /// <returns>The network service type of the request.</returns>        [iOSVersion(4)]        [Export("networkServiceType")]        public NSURLRequestNetworkServiceType NetworkServiceType { get; private set; }                /// <summary>        /// Returns the request's URL.        /// </summary>        /// <returns>The request's URL.</returns>        [iOSVersion(2)]        [Export("URL")]        public NSURL URL { get; private set; }                /// <summary>        /// Returns a dictionary containing all the receiver’s HTTP header fields.        /// </summary>        /// <returns>A dictionary containing all the receiver’s HTTP header fields.</returns>        [iOSVersion(2)]        [Export("allHTTPHeaderFields")]        public NSDictionary AllHTTPHeaderFields { get; private set; }                /// <summary>        /// Returns the receiver’s HTTP body data.        /// </summary>        /// <returns>The receiver's HTTP body data.</returns>        [iOSVersion(2)]        [Export("HTTPBody")]        public NSData HTTPBody { get; private set; }                /// <summary>        /// Returns the receiver’s HTTP body stream.        /// </summary>        /// <returns>The receiver’s HTTP body stream, or nil if it has not been set. The returned stream is for examination only, it is not safe to manipulate the stream in any way.</returns>        [iOSVersion(2)]        [Export("HTTPBodyStream")]        public NSInputStream HTTPBodyStream { get; private set; }                /// <summary>        /// Returns the receiver’s HTTP request method.        /// </summary>        /// <returns>The receiver’s HTTP request method.</returns>        [iOSVersion(2)]        [Export("HTTPMethod")]        public string HTTPMethod { get; private set; }                /// <summary>        /// Returns whether the default cookie handling will be used for this request.        /// </summary>        /// <returns>true if the default cookie handling will be used for this request, false otherwise.</returns>        [iOSVersion(2)]        [Export("HTTPShouldHandleCookies")]        public bool HTTPShouldHandleCookies { get; private set; }                /// <summary>        /// Returns the value of the specified HTTP header field.        /// </summary>        /// <param name="field">The name of the header field whose value is to be returned. In keeping with the HTTP RFC, HTTP header field names are case-insensitive.</param>        /// <returns>The value associated with the header field field, or nil if there is no corresponding header field.</returns>        [iOSVersion(2)]        [Export("valueForHTTPHeaderField")]        public string ValueForHTTPHeaderField(string field) { return ""; }                /// <summary>        /// Returns whether the request is allowed to use the cellular radio (if present).        /// </summary>        /// <returns>true if the cellular radio can be used; false otherwise.</returns>        [iOSVersion(6)]        [Export("allowsCellularAccess")]        public bool AllowsCellularAccess { get; private set; }    }

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