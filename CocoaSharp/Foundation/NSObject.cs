using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace ObjectiveC{	/// <summary>	/// NSObject is the root class of most Objective-C class hierarchies. Through NSObject, objects inherit a basic interface to the runtime system and the ability to behave as Objective-C objects.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSObject_Class/index.html#//apple_ref/occ/cl/NSObject"/>	[iOSVersion(2)]	public class NSObjectAnyObject, NSObjectProtocol	{		/// <summary>		/// Initializes the class before it receives its first message.		/// </summary>		[iOSVersion(2)]		[Export("initialize")]		public static void Initialize() {  }				/// <summary>		/// Invoked whenever a class or category is added to the Objective-C runtime; implement this method to perform class-specific behavior upon loading.		/// </summary>		[iOSVersion(2)]		[Export("load")]		public static void Load() {  }				/// <summary>		/// Returns a new instance of the receiving class.		/// </summary>		[iOSVersion(2)]		[Export("alloc")]		public static Self Alloc() { return default(Self); }				/// <summary>		/// Returns a new instance of the receiving class.		/// </summary>		/// <param name="zone">This parameter is ignored.</param>		[iOSVersion(2)]		[Export("allocWithZone")]		public static Self AllocWithZone(COpaquePointer zone) { return default(Self); }				/// <summary>		/// Implemented by subclasses to initialize a new object (the receiver) immediately after memory for it has been allocated.		/// </summary>		[iOSVersion(2)]		public NSObject() { }				/// <summary>		/// Returns the object returned by copyWithZone:.		/// </summary>		[iOSVersion(2)]		[Export("copy")]		public AnyObject Copy() { return default(AnyObject); }				/// <summary>		/// Returns the object returned by mutableCopyWithZone: where the zone is nil.		/// </summary>		[iOSVersion(2)]		[Export("mutableCopy")]		public AnyObject MutableCopy() { return default(AnyObject); }				/// <summary>		/// Allocates a new instance of the receiving class, sends it an init message, and returns the initialized object.		/// </summary>		[iOSVersion(2)]		public static Self `new`() { return default(Self); }				/// <summary>		/// Returns the class object for the receiver’s superclass.		/// </summary>		[iOSVersion(2)]		[Export("superclass")]		public static AnyClass Superclass() { return default(AnyClass); }				/// <summary>		/// Returns a Boolean value that indicates whether the receiving class is a subclass of, or identical to, a given class.		/// </summary>		/// <param name="aClass">A class object.</param>		[iOSVersion(2)]		[Export("isSubclassOfClass")]		public static bool IsSubclassOfClass(AnyClass aClass) { return default(bool); }				/// <summary>		/// Returns a Boolean value that indicates whether instances of the receiver are capable of responding to a given selector.		/// </summary>		/// <param name="aSelector">A selector.</param>		[iOSVersion(2)]		[Export("instancesRespondToSelector")]		public static bool InstancesRespondToSelector(Selector aSelector) { return default(bool); }				/// <summary>		/// Returns a Boolean value that indicates whether the receiver conforms to a given protocol.		/// </summary>		/// <param name="`aProtocol`"></param>		[iOSVersion(2)]		[Export("conformsToProtocol")]		public static bool ConformsToProtocol(Protocol `aProtocol`) { return default(bool); }				/// <summary>		/// Locates and returns the address of the receiver’s implementation of a method so it can be called as a function.		/// </summary>		/// <param name="aSelector">A selector that identifies the method for which to return the implementation address. The selector must be a valid and non-NULL. If in doubt, use the respondsToSelector: method to check before passing the selector to methodForSelector:.</param>		[iOSVersion(2)]		[Export("methodForSelector")]		public IMP MethodForSelector(Selector aSelector) { return default(IMP); }				/// <summary>		/// Locates and returns the address of the implementation of the instance method identified by a given selector.		/// </summary>		/// <param name="aSelector">A selector that identifies the method for which to return the implementation address. The selector must be non-NULL and valid for the receiver. If in doubt, use the respondsToSelector: method to check before passing the selector to methodForSelector:.</param>		[iOSVersion(2)]		[Export("instanceMethodForSelector")]		public static IMP InstanceMethodForSelector(Selector aSelector) { return default(IMP); }				/// <summary>		/// Returns the object to which unrecognized messages should first be directed.		/// </summary>		/// <param name="aSelector">A selector for a method that the receiver does not implement.</param>		[iOSVersion(2)]		[Export("forwardingTargetForSelector")]		public AnyObject ForwardingTargetForSelector(Selector aSelector) { return default(AnyObject); }				/// <summary>		/// Dynamically provides an implementation for a given selector for a class method.		/// </summary>		/// <param name="name">The name of a selector to resolve.</param>		[iOSVersion(2)]		[Export("resolveClassMethod")]		public static bool ResolveClassMethod(Selector name) { return default(bool); }				/// <summary>		/// Dynamically provides an implementation for a given selector for an instance method.		/// </summary>		/// <param name="name">The name of a selector to resolve.</param>		[iOSVersion(2)]		[Export("resolveInstanceMethod")]		public static bool ResolveInstanceMethod(Selector name) { return default(bool); }				/// <summary>		/// Handles messages the receiver doesn’t recognize.		/// </summary>		/// <param name="aSelector">A selector that identifies a method not implemented or recognized by the receiver.</param>		[iOSVersion(2)]		[Export("doesNotRecognizeSelector")]		public void DoesNotRecognizeSelector(Selector aSelector) {  }				/// <summary>		/// The garbage collector invokes this method on the receiver before disposing of the memory it uses.		/// </summary>		[iOSVersion(2)]		[Export("finalize")]		public void Finalize() {  }	}}