using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSURLCredential is an immutable object representing an authentication credential consisting of authentication information specific to the type of credential and the type of persistent storage to use, if any.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSURLCredential_Class/index.html#//apple_ref/occ/cl/NSURLCredential"/>    [iOSVersion(2)]    [Export("")]    public class NSURLCredential : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable    {        public NSURLCredential() { }        /// <summary>        /// Creates and returns an NSURLCredential object for server trust authentication with a given accepted trust.        /// </summary>        /// <param name="forTrust">The accepted trust.</param>        [iOSVersion(3)]        public NSURLCredential([Unwrapped] SecTrust forTrust) { }                /// <summary>        /// Creates and returns an NSURLCredential object for client certificate authentication with a given identity and a given array of client certificates using a given persistence setting.        /// </summary>        /// <param name="identity">The identity for the credential.</param>        /// <param name="certificates">An array of one or more SecCertificateRef objects representing certificates for the credential.</param>        /// <param name="persistence">The persistence setting for the credential.</param>        [iOSVersion(3)]        public NSURLCredential(SecIdentity identity, AnyObject[] certificates, NSURLCredentialPersistence persistence) { }                /// <summary>        /// Returns an NSURLCredential object for client certificate authentication initialized with a given identity and a given array of client certificates using a given persistence setting.        /// </summary>        /// <param name="identity">The identity for the credential.</param>        /// <param name="certificates">An array of one or more SecCertificateRef objects representing certificates for the credential.</param>        /// <param name="persistence">The persistence setting for the credential.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(3)]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public NSURLCredential([Unwrapped] SecIdentity identity, AnyObject[] certificates, NSURLCredentialPersistence persistence, bool NAME_YOUR_PARAMS = false) { }                /// <summary>        /// Returns an NSURLCredential object for server trust authentication initialized with a given accepted trust.        /// </summary>        /// <param name="trust">The accepted trust.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(3)]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public NSURLCredential([Unwrapped] SecTrust trust, bool NAME_YOUR_PARAMS = false) { }                /// <summary>        /// Returns an NSURLCredential object initialized with a given user name and password using a given persistence setting.        /// </summary>        /// <param name="user">The user for the credential.</param>        /// <param name="password">The password for user.</param>        /// <param name="persistence">The persistence setting for the credential.</param>        [iOSVersion(2)]        public NSURLCredential(string user, string password, NSURLCredentialPersistence persistence) { }                /// <summary>        /// The receiver’s user name. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("user")]        [Optional]        public string User { get; private set; }                /// <summary>        /// The certificates of the credential, if it is a client certificate credential. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("certificates")]        public AnyObject[] Certificates { get; private set; }                /// <summary>        /// A Boolean value that indicates whether the receiver has a password. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("hasPassword")]        public bool HasPassword { get; private set; }                /// <summary>        /// The receiver’s password. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("password")]        [Optional]        public string Password { get; private set; }                /// <summary>        /// The identity of this credential if it is a client certificate credential. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("identity")]        [Optional]        public SecIdentity Identity { get; private set; }                /// <summary>        /// The receiver’s persistence setting. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("persistence")]        public NSURLCredentialPersistence Persistence { get; private set; }    }    /// <summary>    /// These constants specify how long the credential will be kept.    /// </summary>    public enum NSURLCredentialPersistence    {        /// <summary>        /// Credential should not be stored.        /// </summary>        [iOSVersion(2)]        None,        /// <summary>        /// Credential should be stored only for this session.        /// </summary>        [iOSVersion(2)]        ForSession,        /// <summary>        /// Credential should be stored in the keychain.        /// </summary>        [iOSVersion(2)]        Permanent,        /// <summary>        /// Credential should be stored permanently in the keychain, and in addition should be distributed to other devices based on the owning AppleID.        /// </summary>        [iOSVersion(6)]        Synchronizable,    }}