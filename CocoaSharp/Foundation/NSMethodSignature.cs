﻿using Foundation;
using ObjectiveC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMethodSignature_Class/index.html#//apple_ref/occ/cl/NSMethodSignature
    /// <summary>
    /// An NSMethodSignature object records type information for the arguments and return value of a method. It is used to forward messages that the receiving object does not respond to—most notably in the case of distributed objects. You typically create an NSMethodSignature object using NSObject’s methodSignatureForSelector: instance method (on OS X v10.5 and later you can also use signatureWithObjCTypes:). It is then used to create an NSInvocation object, which is passed as the argument to a forwardInvocation: message to send the invocation on to whatever other object can handle the message. In the default case, NSObject invokes doesNotRecognizeSelector:, which raises an exception. For distributed objects, the NSInvocation object is encoded using the information in the NSMethodSignature object and sent to the real object represented by the receiver of the message.
    /// </summary>
    public class NSMethodSignature : NSObject
    {
        /// <summary>
        /// Returns an NSMethodSignature object for the given Objective C method type string.
        /// </summary>
        /// <param name="types">An array of characters containing the type encodings for the method arguments.   Indices begin with 0. The hidden arguments self (of type id) and _cmd (of type SEL) are at indices 0 and 1; method-specific arguments begin at index 2.</param>
        /// <returns>An NSMethodSignature object for the given Objective C method type string in types.</returns>
        //[Export("init")]
        public NSMethodSignature(CString objCTypes) { }

        /// <summary>
        /// Returns the type encoding for the argument at a given index.
        /// </summary>
        /// <param name="index">The index of the argument to get.</param>
        /// <returns>The type encoding for the argument at index.</returns>
        [Export("getArgumentTypeAtIndex")]
        public CString GetArgumentTypeAtIndex(int index) { return null; }

        /// <summary>
        /// Returns the number of arguments recorded in the receiver.
        /// </summary>
        /// <returns>The number of arguments recorded in the receiver.</returns>
        [Export("numberOfArguments")]
        public static int NumberOfArguments { get; private set; }

        /// <summary>
        /// Returns the number of bytes that the arguments, taken together, occupy on the stack.
        /// </summary>
        /// <returns>The number of bytes that the arguments, taken together, occupy on the stack.</returns>
        [Export("frameLength")]
        public static int FrameLength { get; private set; }

        /// <summary>
        /// Returns a C string encoding the return type of the method in Objective-C type encoding.
        /// </summary>
        /// <returns>A C string encoding the return type of the method in Objective-C type encoding.</returns>
        [Export("methodReturnType")]
        public static CString MethodReturnType { get; private set; }

        /// <summary>
        /// Returns the number of bytes required for the return value.
        /// </summary>
        /// <returns>The number of bytes required for the return value.</returns>
        [Export("methodReturnLength")]
        public static int MethodReturnLength { get; private set; }

        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver is asynchronous when invoked through distributed objects.
        /// </summary>
        /// <returns>true if the receiver is asynchronous when invoked through distributed objects, otherwise false.</returns>
        [Export("isOneway")]
        public bool IsOneway() { return false; }
    }
}