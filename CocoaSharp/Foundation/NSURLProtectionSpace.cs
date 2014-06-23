using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSURLProtectionSpace_Class/index.html#//apple_ref/occ/cl/NSURLProtectionSpace	/// <summary>	/// An NSURLProtectionSpace object represents a server or an area on a server, commonly referred to as a realm, that requires authentication. The protection space defines a series of matching constraints that determine which credential should be provided.	/// </summary>	[iOSVersion(2)]	public class NSURLProtectionSpace : NSObject	{		/// <summary>		/// Initializes a protection space object.		/// </summary>		/// <param name="host">The host name for the protection space object.</param>		/// <param name="port">The port for the protection space object. If port is 0 the default port for the specified protocol is used, for example, port 80 for HTTP. Note that servers can, and do, treat these values differently.</param>		/// <param name="protocol">The protocol for the protection space object. The value of protocol is equivalent to the scheme for a URL in the protection space, for example, “http”, “https”, “ftp”, etc.</param>		/// <param name="realm">A string indicating a protocol specific subdivision of the host. realm may be nil if there is no specified realm or if the protocol doesn’t support realms.</param>		/// <param name="authenticationMethod">The type of authentication to use. authenticationMethod should be set to one of the values in NSURLProtectionSpace Authentication Methods or nil to use the default, NSURLAuthenticationMethodDefault.</param>		[iOSVersion(2)]		public NSURLProtectionSpace(string host, int port, string protocol, string realm, string authenticationMethod) { }				/// <summary>		/// Initializes a protection space object representing a proxy server.		/// </summary>		/// <param name="proxyHost">The host of the proxy server for the protection space object.</param>		/// <param name="port">The port for the protection space object. If port is 0 the default port for the specified proxy type is used, for example, port 80 for HTTP. Note that servers can, and do, treat these values differently.</param>		/// <param name="type">The type of proxy server. The value of proxyType should be set to one of the values specified in NSURLProtectionSpace Proxy Types.</param>		/// <param name="realm">A string indicating a protocol specific subdivision of the host. realm may be nil if there is no specified realm or if the protocol doesn’t support realms.</param>		/// <param name="authenticationMethod">The type of authentication to use. authenticationMethod should be set to one of the values in NSURLProtectionSpace Authentication Methods or nil to use the default, NSURLAuthenticationMethodDefault.</param>		[iOSVersion(2)]		public NSURLProtectionSpace(string proxyHost, int port, string type, string realm, string authenticationMethod) { }				/// <summary>		/// Returns the authentication method used by the receiver.		/// </summary>		/// <returns>The authentication method used by the receiver. The supported authentication methods are listed in NSURLProtectionSpace Authentication Methods.</returns>		[iOSVersion(2)]		[Export("authenticationMethod")]		public string AuthenticationMethod { get; private set; }				/// <summary>		/// Returns an array of acceptable certificate-issuing authorities for client certificate authentication.		/// </summary>		/// <returns>An array of acceptable certificate-issuing authorities, or nil if the authentication method of the protection space is not client certificate.</returns>		[iOSVersion(3)]		[Export("distinguishedNames")]		public AnyObject[] DistinguishedNames { get; private set; }				/// <summary>		/// Returns the receiver’s host.		/// </summary>		/// <returns>The receiver's host.</returns>		[iOSVersion(2)]		[Export("host")]		public string Host { get; private set; }				/// <summary>		/// Returns the receiver’s port.		/// </summary>		/// <returns>The receiver's port.</returns>		[iOSVersion(2)]		[Export("port")]		public int Port { get; private set; }				/// <summary>		/// Returns the receiver’s protocol.		/// </summary>		/// <returns>The receiver's protocol, or nil if the receiver represents a proxy protection space.</returns>		[iOSVersion(2)]		[Export("protocol")]		public string protocol { get; private set; }				/// <summary>		/// Returns the receiver's proxy type.		/// </summary>		/// <returns>The receiver's proxy type, or nil if the receiver does not represent a proxy protection space. The supported proxy types are listed in NSURLProtectionSpace Proxy Types.</returns>		[iOSVersion(2)]		[Export("proxyType")]		public string ProxyType { get; private set; }				/// <summary>		/// Returns the receiver’s authentication realm		/// </summary>		/// <returns>The receiver’s authentication realm, or nil if no realm has been set.</returns>		[iOSVersion(2)]		[Export("realm")]		public string Realm { get; private set; }				/// <summary>		/// Returns whether the credentials for the protection space can be sent securely.		/// </summary>		/// <returns>true if the credentials for the protection space represented by the receiver can be sent securely, false otherwise.</returns>		[iOSVersion(2)]		[Export("receivesCredentialSecurely")]		public bool ReceivesCredentialSecurely { get; private set; }				/// <summary>		/// Returns a representation of the server’s SSL transaction state.		/// </summary>		/// <returns>The server’s SSL transaction state, or nil if the authentication method of the protection space is not server trust.</returns>		[iOSVersion(3)]		[Export("serverTrust")]		public SecTrust ServerTrust { get; private set; }				/// <summary>		/// These constants describe the supported protocols for a protection space, as returned by protocol.		/// </summary>				/// <summary>		/// The protocol type for HTTP.		/// </summary>		[iOSVersion(2)]		public string NSURLProtectionSpaceHTTP { get; private set; }				/// <summary>		/// The protocol type for HTTPS.		/// </summary>		[iOSVersion(2)]		public string NSURLProtectionSpaceHTTPS { get; private set; }				/// <summary>		/// The protocol type for FTP.		/// </summary>		[iOSVersion(2)]		public string NSURLProtectionSpaceFTP { get; private set; }				/// <summary>		/// These constants describe the supported proxy types used in initWithProxyHost:port:type:realm:authenticationMethod: and returned by proxyType.		/// </summary>				/// <summary>		/// The proxy type for HTTP proxies.		/// </summary>		[iOSVersion(2)]		public string NSURLProtectionSpaceHTTPProxy { get; private set; }				/// <summary>		/// The proxy type for HTTPS proxies.		/// </summary>		[iOSVersion(2)]		public string NSURLProtectionSpaceHTTPSProxy { get; private set; }				/// <summary>		/// The proxy type for FTP proxies.		/// </summary>		[iOSVersion(2)]		public string NSURLProtectionSpaceFTPProxy { get; private set; }				/// <summary>		/// The proxy type for SOCKS proxies.		/// </summary>		[iOSVersion(2)]		public string NSURLProtectionSpaceSOCKSProxy { get; private set; }				/// <summary>		/// These constants describe the available authentication methods used in initWithHost:port:protocol:realm:authenticationMethod:, initWithProxyHost:port:type:realm:authenticationMethod: and returned by authenticationMethod.		/// </summary>				/// <summary>		/// Use the default authentication method for a protocol.		/// </summary>		[iOSVersion(2)]		public string NSURLAuthenticationMethodDefault { get; private set; }				/// <summary>		/// Use HTTP basic authentication for this protection space.		/// </summary>		[iOSVersion(2)]		public string NSURLAuthenticationMethodHTTPBasic { get; private set; }				/// <summary>		/// Use HTTP digest authentication for this protection space.		/// </summary>		[iOSVersion(2)]		public string NSURLAuthenticationMethodHTTPDigest { get; private set; }				/// <summary>		/// Use HTML form authentication for this protection space.		/// </summary>		[iOSVersion(2)]		public string NSURLAuthenticationMethodHTMLForm { get; private set; }				/// <summary>		/// Negotiate whether to use Kerberos or NTLM authentication for this protection space.		/// </summary>		[iOSVersion(2)]		public string NSURLAuthenticationMethodNegotiate { get; private set; }				/// <summary>		/// Use NTLM authentication for this protection space.		/// </summary>		[iOSVersion(2)]		public string NSURLAuthenticationMethodNTLM { get; private set; }				/// <summary>		/// Use client certificate authentication for this protection space.		/// </summary>		[iOSVersion(3)]		public string NSURLAuthenticationMethodClientCertificate { get; private set; }				/// <summary>		/// Perform server trust authentication (certificate validation) for this protection space.		/// </summary>		[iOSVersion(3)]		public string NSURLAuthenticationMethodServerTrust { get; private set; }	}}