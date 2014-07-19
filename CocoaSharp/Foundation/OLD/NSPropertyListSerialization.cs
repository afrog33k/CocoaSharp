using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// The only read options supported are described in NSPropertyListMutabilityOptions.
    /// </summary>
    //[iOSVersion(4)]
    using NSPropertyListReadOptions = Int32;

    using NSPropertyListWriteOptions = Int32; //TODO: later figure out what NSPropertyListWriteOptions really is

    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSPropertyListSerialization_Class/index.html#//apple_ref/occ/cl/NSPropertyListSerialization
    /// <summary>
    /// The NSPropertyListSerialization class provides methods that convert property list objects to and from several serialized formats. Property list objects include NSData, NSString, NSArray, NSDictionary, NSDate, and NSNumber objects. These objects are toll-free bridged with their respective Core Foundation types (CFData, CFString, and so on). For more about toll-free bridging, see interchangeable Data Types.
    /// </summary>
    [iOSVersion(2)]
    public class NSPropertyListSerialization : NSObject
    {
        /// <summary>
        /// Returns an NSData object containing a given property list in a specified format.
        /// </summary>
        /// <param name="plist">A property list object. Passing nil for this value will cause an exception to be raised.</param>
        /// <param name="format">A property list format. Possible values for format are described in NSPropertyListFormat.</param>
        /// <param name="options">The opt parameter is currently unused and should be set to 0.</param>
        /// <param name="error">If the method does not complete successfully, upon return contains an NSError object that describes the problem.</param>
        /// <returns>An NSData object containing plist in the format specified by format.</returns>
        [iOSVersion(4)]
        [Export("dataWithPropertyList")]
        public static NSData DataWithPropertyList(AnyObject plist, NSPropertyListFormat format, NSPropertyListWriteOptions options, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Writes the specified property list to the specified stream.
        /// </summary>
        /// <param name="plist">A property list object. Passing nil for this value will cause an exception to be raised.</param>
        /// <param name="toStream">An NSStream object. The stream should be open and configured for reading.</param>
        /// <param name="format">A property list format. Possible values for format are described in NSPropertyListFormat.</param>
        /// <param name="options">The opt parameter is currently unused and should be set to 0.</param>
        /// <param name="error">If the method does not complete successfully, upon return contains an NSError object that describes the problem.</param>
        /// <returns>Returns the number of bytes written to the stream. If the value is 0 an error occurred.</returns>
        [iOSVersion(4)]
        [Export("writePropertyList")]
        public static int WritePropertyList(AnyObject plist, NSOutputStream toStream, NSPropertyListFormat format, NSPropertyListWriteOptions options, NSErrorPointer error) { return 0; }
        
        /// <summary>
        /// Creates and returns a property list from the specified data.
        /// </summary>
        /// <param name="data">A data object containing a serialized property list. Passing nil for this value will cause an exception to be raised.</param>
        /// <param name="options">The options can be any of those listed in NSPropertyListMutabilityOptions.</param>
        /// <param name="format">Upon return, contains the format that the property list was stored in. Pass NULL if you do not need to know the format.</param>
        /// <param name="error">If the method does not complete successfully, upon return contains an NSError object that describes the problem.</param>
        /// <returns>A property list object corresponding to the representation in data. If data is not in a supported format, returns nil.</returns>
        [iOSVersion(4)]
        [Export("propertyListWithData")]
        public static AnyObject PropertyListWithData(NSData data, NSPropertyListReadOptions options, CMutablePointer<NSPropertyListFormat> format, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Creates and returns a property list by reading from the specified stream.
        /// </summary>
        /// <param name="stream">An NSStream object. The stream should be open and configured for reading.</param>
        /// <param name="options">Set to 0—read options are not implemented.</param>
        /// <param name="format">Upon return, contains the format that the property list was stored in. Pass NULL if you do not need to know the format.</param>
        /// <param name="error">If the method does not complete successfully, upon return contains an NSError object that describes the problem.</param>
        /// <returns>A property list object corresponding to the representation in data. If data is not in a supported format, returns nil.</returns>
        [iOSVersion(4)]
        [Export("propertyListWithStream")]
        public static AnyObject PropertyListWithStream(NSInputStream stream, NSPropertyListReadOptions options, CMutablePointer<NSPropertyListFormat> format, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether a given property list is valid for a given format.
        /// </summary>
        /// <param name="plist">A property list object.</param>
        /// <param name="isValidForFormat">A property list format. Possible values for format are listed in NSPropertyListFormat.</param>
        /// <returns>true if plist is a valid property list in format format, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("propertyList")]
        public static bool PropertyList(AnyObject plist, NSPropertyListFormat isValidForFormat) { return false; }
        
        /// <summary>
        /// This method is obsolete and will be deprecated soon.				 		  Deprecation Statement		  		 Use dataWithPropertyList:format:options:error: instead.
        /// </summary>
        /// <param name="plist">A property list object.</param>
        /// <param name="format">A property list format. Possible values for format are described in NSPropertyListFormat.</param>
        /// <param name="errorDescription">Upon return, if the conversion is successful, errorString is nil. If the conversion fails, upon return contains a string describing the nature of the error.</param>
        /// <returns>An NSData object containing plist in the format specified by format.</returns>
        [Obsolete]
        [iOSVersion(2)]
        [Export("dataFromPropertyList")]
        public static NSData DataFromPropertyList(AnyObject plist, NSPropertyListFormat format, CMutablePointer<NSString> errorDescription) { return null; }
        
        /// <summary>
        /// This method is obsolete and will be deprecated soon.				 		  Deprecation Statement		  		 Use propertyListWithData:options:format:error: instead.
        /// </summary>
        /// <param name="data">A data object containing a serialized property list.</param>
        /// <param name="mutabilityOption">The opt parameter is currently unused and should be set to 0.</param>
        /// <param name="format">If the property list is valid, upon return contains the format. format can be NULL, in which case the property list format is not returned. Possible values are described in NSPropertyListFormat.</param>
        /// <param name="errorDescription">Upon return, if the conversion is successful, errorString is nil. If the conversion fails, upon return contains a string describing the nature of the error.</param>
        /// <returns>A property list object corresponding to the representation in data. If data is not in a supported format, returns nil.</returns>
        [Obsolete]
        [iOSVersion(2)]
        [Export("propertyListFromData")]
        public static AnyObject PropertyListFromData(NSData data, NSPropertyListMutabilityOptions mutabilityOption, CMutablePointer<NSPropertyListFormat> format, CMutablePointer<NSString> errorDescription) { return null; }
    }
        
    /// <summary>
    /// These constants specify mutability options in property lists.
    /// </summary>
    public enum NSPropertyListMutabilityOptions
    {
        /// <summary>
        /// Causes the returned property list to contain immutable objects.
        /// </summary>
        [iOSVersion(2)]
        Immutable,
            
        /// <summary>
        /// Causes the returned property list to have mutable containers but immutable leaves.
        /// </summary>
        [iOSVersion(2)]
        MutableContainers,
            
        /// <summary>
        /// Causes the returned property list to have mutable containers and leaves.
        /// </summary>
        [iOSVersion(2)]
        MutableContainersAndLeaves,
    }

    /// <summary>
    /// These constants are used to specify a property list serialization format.
    /// </summary>
    [iOSVersion(2)]
    public enum NSPropertyListFormat
    {
        /// <summary>
        /// Specifies the ASCII property list format inherited from the OpenStep APIs.
        /// !! IMPORTANT !! The NSPropertyListOpenStepFormat constant is not supported for writing. It can be used only for reading old-style property lists.
        /// </summary>
        [iOSVersion(2)]
        OpenStepFormat,

        /// <summary>
        /// Specifies the XML property list format.
        /// </summary>
        [iOSVersion(2)]
        XMLFormat_v1_0,

        /// <summary>
        /// Specifies the binary property list format.
        /// </summary>
        [iOSVersion(2)]
        BinaryFormat_v1_0
    }
}