using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSURLConnectionDelegate protocol defines methods common to the NSURLConnectionDataDelegate and NSURLConnectionDownloadDelegate protocols.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSURLConnectionDelegate_Protocol/index.html#//apple_ref/occ/intf/NSURLConnectionDelegate"/>    [iOSVersion(5)]    [Export("")]    public interface NSURLConnectionDelegate//: NSObjectProtocol    {        /// <summary>        /// Tells the delegate that the connection will send a request for an authentication challenge.        /// </summary>        /// <param name="connection">The connection sending the message.</param>        /// <param name="willSendRequestForAuthenticationChallenge">The authentication challenge for which a request is being sent.</param>        //[iOSVersion(5)]        //[Export("connection")]        //[InheritOptional]        //void Connection(NSURLConnection connection, NSURLAuthenticationChallenge willSendRequestForAuthenticationChallenge);                /// <summary>        /// Sent to determine whether the delegate is able to respond to a protection space’s form of authentication.        /// </summary>        /// <param name="connection">The connection sending the message.</param>        /// <param name="canAuthenticateAgainstProtectionSpace">The protection space that generates an authentication challenge.</param>        //[iOSVersion(3)]        //[Export("connection")]        //[InheritOptional]        //bool Connection(NSURLConnection connection, NSURLProtectionSpace canAuthenticateAgainstProtectionSpace);                /// <summary>        /// Sent when a connection cancels an authentication challenge.        /// </summary>        /// <param name="connection">The connection sending the message.</param>        /// <param name="didCancelAuthenticationChallenge">The challenge that was canceled.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        //[iOSVersion(2)]        //[Export("connection")]        //[InheritOptional]        //[IgnoreParameter("NAME_YOUR_PARAMS")]        //void Connection(NSURLConnection connection, NSURLAuthenticationChallenge didCancelAuthenticationChallenge, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Sent when a connection must authenticate a challenge in order to download its request.        /// </summary>        /// <param name="connection">The connection sending the message.</param>        /// <param name="didReceiveAuthenticationChallenge">The challenge that connection must authenticate in order to download its request.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        //[iOSVersion(2)]        //[Export("connection")]        //[InheritOptional]        //[IgnoreParameter("NAME_YOUR_PARAMS")]        //void Connection(NSURLConnection connection, NSURLAuthenticationChallenge didReceiveAuthenticationChallenge, int NAME_YOUR_PARAMS = 0);                /// <summary>        /// Sent to determine whether the URL loader should use the credential storage for authenticating the connection.        /// </summary>        /// <param name="connection">The connection sending the message.</param>        //[iOSVersion(3)]        //[Export("connectionShouldUseCredentialStorage")]        //[InheritOptional]        //bool ConnectionShouldUseCredentialStorage(NSURLConnection connection);                /// <summary>        /// Sent when a connection fails to load its request successfully.        /// </summary>        /// <param name="connection">The connection sending the message.</param>        /// <param name="didFailWithError">An error object containing details of why the connection failed to load the request successfully.</param>        //[iOSVersion(2)]        //[Export("connection")]        //[InheritOptional]        //void Connection(NSURLConnection connection, NSError didFailWithError);    }}