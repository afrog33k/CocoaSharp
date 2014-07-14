﻿using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// NSArray and its subclass NSMutableArray manage ordered collections of objects called arrays. NSArray creates static arrays, and NSMutableArray creates dynamic arrays. You can use arrays when you need an ordered collection of objects.
    /// </summary>
    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSArray_Class/index.html#//apple_ref/occ/instm/NSArray/initWithContentsOfFile:"/>
    public class NSArray : NSObject, AnyObject, ArrayLiteralConvertible, NSCoding, NSCopying, NSFastEnumeration, NSMutableCopying, NSObjectProtocol, NSSecureCoding, Reflectable, Sequence
    {
        /// <summary>
        /// Creates and returns an array containing a given object.
        /// </summary>
        /// <param name="@object">An object.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        public NSArray(AnyObject @object) { }

        /// <summary>
        /// Initializes a newly allocated array.
        /// </summary>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        public NSArray() { }

        /// <summary>
        /// Initializes a newly allocated array by placing in it the objects contained in a given array.
        /// </summary>
        /// <param name="array">An array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        public NSArray(AnyObject[] array) { }

        /// <summary>
        /// Initializes a newly allocated array using anArray as the source of data objects for the array.
        /// </summary>
        /// <param name="array">An array containing the objects with which to initialize the new array.</param>
        /// <param name="copyItems">If true, each object in array receives a copyWithZone: message to create a copy of the object—objects must conform to the NSCopying protocol. In a managed memory environment, this is instead of the retain message the object would otherwise receive. The object copy is then added to the returned array.
        ///   If false, then in a managed memory environment each object in array simply receives a retain message when it is added to the returned array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        public NSArray(AnyObject[] array, bool copyItems) { }

        /// <summary>
        /// Initializes a newly allocated array with the contents of the file specified by a given path.
        /// </summary>
        /// <param name="contentsOfFile">The path to a file containing a representation of an array produced by the writeToFile:atomically: method.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        public NSArray(string contentsOfFile) { }

        /// <summary>
        /// Initializes a newly allocated array with the contents of the location specified by a given URL.
        /// </summary>
        /// <param name="contentsOfURL">The location of a file containing a string representation of an array produced by the writeToURL:atomically: method.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        public NSArray(NSURL contentsOfURL) { }

        /// <summary>
        /// Initializes a newly allocated array to include a given number of objects from a given C array.
        /// </summary>
        /// <param name="objects">A C array of objects.</param>
        /// <param name="count">The number of values from the objects C array to include in the new array. This number will be the count of the new array—it must not be negative or greater than the number of elements in objects.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        public NSArray(ConstUnsafePointer<AnyObject> objects, int count) { }

        /// <summary>
        /// Returns a Boolean value that indicates whether a given object is present in the array.
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("containsObject")]
        public bool ContainsObject(AnyObject anObject) { return default(bool); }

        /// <summary>
        /// Copies all the objects contained in the array to aBuffer.
        /// </summary>
        /// <param name="aBuffer">A C array of objects of size at least the count of the array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("getObjects")]
        public void GetObjects(AutoreleasingUnsafePointer<AnyObject> aBuffer) { }

        /// <summary>
        /// Copies the objects contained in the array that fall within the specified range to aBuffer.
        /// </summary>
        /// <param name="aBuffer">A C array of objects of size at least the length of the range specified by aRange.</param>
        /// <param name="range">A range within the bounds of the array.
        ///   If the location plus the length of the range is greater than the count of the array, this method raises an NSRangeException.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("getObjects")]
        public void GetObjects(AutoreleasingUnsafePointer<AnyObject> aBuffer, NSRange range) { }

        /// <summary>
        /// Returns the object located at the specified index.
        /// </summary>
        /// <param name="index">An index within the bounds of the array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("objectAtIndex")]
        public AnyObject ObjectAtIndex(int index) { return default(AnyObject); }

        /// <summary>
        /// Returns the object at the specified index.
        /// </summary>
        /// <param name="idx">An index within the bounds of the array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(6)]
        [Export("objectAtIndexedSubscript")]
        public AnyObject ObjectAtIndexedSubscript(int idx) { return default(AnyObject); }

        /// <summary>
        /// Returns an array containing the objects in the array at the indexes specified by a given index set.
        /// </summary>
        /// <param name="indexes"></param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("objectsAtIndexes")]
        public AnyObject[] ObjectsAtIndexes(NSIndexSet indexes) { return default(AnyObject[]); }

        /// <summary>
        /// Returns an enumerator object that lets you access each object in the array.
        /// </summary>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("objectEnumerator")]
        public NSEnumerator ObjectEnumerator() { return default(NSEnumerator); }

        /// <summary>
        /// Returns an enumerator object that lets you access each object in the array, in reverse order.
        /// </summary>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("reverseObjectEnumerator")]
        public NSEnumerator ReverseObjectEnumerator() { return default(NSEnumerator); }

        /// <summary>
        /// Returns the lowest index whose corresponding array value is equal to a given object.
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("indexOfObject")]
        public int IndexOfObject(AnyObject anObject) { return default(int); }

        /// <summary>
        /// Returns the lowest index within a specified range whose corresponding array value is equal to a given object .
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <param name="inRange">The range of indexes in the array within which to search for anObject.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("indexOfObject")]
        public int IndexOfObject(AnyObject anObject, NSRange inRange) { return default(int); }

        /// <summary>
        /// Returns the lowest index whose corresponding array value is identical to a given object.
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("indexOfObjectIdenticalTo")]
        public int IndexOfObjectIdenticalTo(AnyObject anObject) { return default(int); }

        /// <summary>
        /// Returns the lowest index within a specified range whose corresponding array value is equal to a given object .
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <param name="inRange">The range of indexes in the array within which to search for anObject.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("indexOfObjectIdenticalTo")]
        public int IndexOfObjectIdenticalTo(AnyObject anObject, NSRange inRange) { return default(int); }

        /// <summary>
        /// Returns the index of the first object in the array that passes a test in a given Block.
        /// </summary>
        /// <param name="predicate">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.
        ///   The Block returns a Boolean value that indicates whether obj passed the test. Returning true will stop further processing of the array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("indexOfObjectPassingTest")]
        public int IndexOfObjectPassingTest(Func<AnyObject, int, UnsafePointer<ObjCBool>, bool> predicate) { return default(int); }

        /// <summary>
        /// Returns the index of an object in the array that passes a test in a given Block for a given set of enumeration options.
        /// </summary>
        /// <param name="opts">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.
        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("indexOfObjectWithOptions")]
        public int IndexOfObjectWithOptions(NSEnumerationOptions opts, Func<AnyObject, int, UnsafePointer<ObjCBool>, bool> passingTest) { return default(int); }

        /// <summary>
        /// Returns the index, from a given set of indexes, of the first object in the array that passes a test in a given Block for a given set of enumeration options.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.
        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("indexOfObjectAtIndexes")]
        public int IndexOfObjectAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Func<AnyObject, int, UnsafePointer<ObjCBool>, bool> passingTest) { return default(int); }

        /// <summary>
        /// Returns the indexes of objects in the array that pass a test in a given Block.
        /// </summary>
        /// <param name="predicate">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.
        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("indexesOfObjectsPassingTest")]
        public NSIndexSet IndexesOfObjectsPassingTest(Func<AnyObject, int, UnsafePointer<ObjCBool>, bool> predicate) { return default(NSIndexSet); }

        /// <summary>
        /// Returns the indexes of objects in the array that pass a test in a given Block for a given set of enumeration options.
        /// </summary>
        /// <param name="opts">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.
        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("indexesOfObjectsWithOptions")]
        public NSIndexSet IndexesOfObjectsWithOptions(NSEnumerationOptions opts, Func<AnyObject, int, UnsafePointer<ObjCBool>, bool> passingTest) { return default(NSIndexSet); }

        /// <summary>
        /// Returns the indexes, from a given set of indexes, of objects in the array that pass a test in a given Block for a given set of enumeration options.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.
        ///   The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("indexesOfObjectsAtIndexes")]
        public NSIndexSet IndexesOfObjectsAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Func<AnyObject, int, UnsafePointer<ObjCBool>, bool> passingTest) { return default(NSIndexSet); }

        /// <summary>
        /// Returns the index, within a specified range, of an object compared with elements in the array using a given NSComparator block.
        /// </summary>
        /// <param name="obj">An object for which to search in the array.
        ///   If this value is nil, throws an NSInvalidArgumentException.</param>
        /// <param name="inSortedRange">The range within the array to search for obj.
        ///   If r exceeds the bounds of the array (if the location plus length of the range is greater than the count of the array), throws an NSRangeException.</param>
        /// <param name="options">Options for the search. For possible values, see NSBinarySearchingOptions.
        ///   If you specify both NSBinarySearchingFirstEqual and NSBinarySearchingLastEqual, throws an NSInvalidArgumentException.</param>
        /// <param name="usingComparator">A comparator block used to compare the object obj with elements in the array.
        ///   If this value is NULL, throws an NSInvalidArgumentException.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("indexOfObject")]
        public int IndexOfObject(AnyObject obj, NSRange inSortedRange, NSBinarySearchingOptions options, NSComparator usingComparator) { return default(int); }

        /// <summary>
        /// Sends to each object in the array the message identified by a given selector, starting with the first object and continuing through the array to the last object.
        /// </summary>
        /// <param name="aSelector">A selector that identifies the message to send to the objects in the array. The method must not take any arguments, and must not have the side effect of modifying the receiving array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("makeObjectsPerformSelector")]
        public void MakeObjectsPerformSelector(Selector aSelector) { }

        /// <summary>
        /// Sends the aSelector message to each object in the array, starting with the first object and continuing through the array to the last object.
        /// </summary>
        /// <param name="aSelector">A selector that identifies the message to send to the objects in the array. The method must take a single argument of type id, and must not have the side effect of modifying the receiving array.</param>
        /// <param name="withObject">The object to send as the argument to each invocation of the aSelector method.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("makeObjectsPerformSelector")]
        public void MakeObjectsPerformSelector(Selector aSelector, AnyObject withObject) { }

        /// <summary>
        /// Executes a given block using each object in the array, starting with the first object and continuing through the array to the last object.
        /// </summary>
        /// <param name="block">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("enumerateObjectsUsingBlock")]
        public void EnumerateObjectsUsingBlock(Action<AnyObject, int, UnsafePointer<ObjCBool>> block) { }

        /// <summary>
        /// Executes a given block using each object in the array.
        /// </summary>
        /// <param name="opts">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="usingBlock">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("enumerateObjectsWithOptions")]
        public void EnumerateObjectsWithOptions(NSEnumerationOptions opts, Action<AnyObject, int, UnsafePointer<ObjCBool>> usingBlock) { }

        /// <summary>
        /// Executes a given block using the objects in the array at the specified indexes.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="usingBlock">The block to apply to elements in the array.
        ///   The block takes three arguments:
        ///       obj
        ///   The element in the array.
        ///       idx
        ///   The index of the element in the array.
        ///       stop
        ///   A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("enumerateObjectsAtIndexes")]
        public void EnumerateObjectsAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Action<AnyObject, int, UnsafePointer<ObjCBool>> usingBlock) { }

        /// <summary>
        /// Returns the first object contained in the receiving array that’s equal to an object in another given array.
        /// </summary>
        /// <param name="otherArray">An array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("firstObjectCommonWithArray")]
        public AnyObject FirstObjectCommonWithArray(AnyObject[] otherArray) { return default(AnyObject); }

        /// <summary>
        /// Compares the receiving array to another array.
        /// </summary>
        /// <param name="otherArray">An array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("isEqualToArray")]
        public bool IsEqualToArray(AnyObject[] otherArray) { return default(bool); }

        /// <summary>
        /// Returns a new array that is a copy of the receiving array with a given object added to the end.
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("arrayByAddingObject")]
        public AnyObject[] ArrayByAddingObject(AnyObject anObject) { return default(AnyObject[]); }

        /// <summary>
        /// Returns a new array that is a copy of the receiving array with the objects contained in another array added to the end.
        /// </summary>
        /// <param name="otherArray">An array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("arrayByAddingObjectsFromArray")]
        public AnyObject[] ArrayByAddingObjectsFromArray(AnyObject[] otherArray) { return default(AnyObject[]); }

        /// <summary>
        /// Evaluates a given predicate against each object in the receiving array and returns a new array containing the objects for which the predicate returns true.
        /// </summary>
        /// <param name="predicate">The predicate against which to evaluate the receiving array’s elements.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(3)]
        [Export("filteredArrayUsingPredicate")]
        public AnyObject[] FilteredArrayUsingPredicate(NSPredicate predicate) { return default(AnyObject[]); }

        /// <summary>
        /// Returns a new array containing the receiving array’s elements that fall within the limits specified by a given range.
        /// </summary>
        /// <param name="range">A range within the receiving array’s range of elements.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("subarrayWithRange")]
        public AnyObject[] SubarrayWithRange(NSRange range) { return default(AnyObject[]); }

        /// <summary>
        /// Returns a new array that lists the receiving array’s elements in ascending order as defined by the comparison function comparator.
        /// </summary>
        /// <param name="comparator"></param>
        /// <param name="context"></param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("sortedArrayUsingFunction")]
        public AnyObject[] SortedArrayUsingFunction(CFunctionPointer<Func<AnyObject, AnyObject, UnsafePointer<Action>, int>> comparator, UnsafePointer<Action> context) { return default(AnyObject[]); }

        /// <summary>
        /// Returns a new array that lists the receiving array’s elements in ascending order as defined by the comparison function comparator.
        /// </summary>
        /// <param name="comparator"></param>
        /// <param name="context"></param>
        /// <param name="hint"></param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("sortedArrayUsingFunction")]
        public AnyObject[] SortedArrayUsingFunction(CFunctionPointer<Func<AnyObject, AnyObject, UnsafePointer<Action>, int>> comparator, UnsafePointer<Action> context, NSData hint) { return default(AnyObject[]); }

        /// <summary>
        /// Returns a copy of the receiving array sorted as specified by a given array of sort descriptors.
        /// </summary>
        /// <param name="sortDescriptors">An array of NSSortDescriptor objects.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("sortedArrayUsingDescriptors")]
        public AnyObject[] SortedArrayUsingDescriptors(AnyObject[] sortDescriptors) { return default(AnyObject[]); }

        /// <summary>
        /// Returns an array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified by a given selector.
        /// </summary>
        /// <param name="comparator">A selector that identifies the method to use to compare two elements at a time. The method should return NSOrderedAscending if the receiving array is smaller than the argument, NSOrderedDescending if the receiving array is larger than the argument, and NSOrderedSame if they are equal.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("sortedArrayUsingSelector")]
        public AnyObject[] SortedArrayUsingSelector(Selector comparator) { return default(AnyObject[]); }

        /// <summary>
        /// Returns an array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified by a given NSComparator Block.
        /// </summary>
        /// <param name="cmptr">A comparator block.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("sortedArrayUsingComparator")]
        public AnyObject[] SortedArrayUsingComparator(NSComparator cmptr) { return default(AnyObject[]); }

        /// <summary>
        /// Returns an array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified by a given NSComparator Block.
        /// </summary>
        /// <param name="opts">A bit mask that specifies the options for the sort (whether it should be performed concurrently and whether it should be performed stably).</param>
        /// <param name="usingComparator">A comparator block.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(4)]
        [Export("sortedArrayWithOptions")]
        public AnyObject[] SortedArrayWithOptions(NSSortOptions opts, NSComparator usingComparator) { return default(AnyObject[]); }

        /// <summary>
        /// Constructs and returns an NSString object that is the result of interposing a given separator between the elements of the array.
        /// </summary>
        /// <param name="separator">The string to interpose between the elements of the array.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("componentsJoinedByString")]
        public string ComponentsJoinedByString(string separator) { return default(string); }

        /// <summary>
        /// Returns a string that represents the contents of the array, formatted as a property list.
        /// </summary>
        /// <param name="locale">An NSLocale object or an NSDictionary object that specifies options used for formatting each of the array’s elements (where recognized). Specify nil if you don’t want the elements formatted.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale) { return default(string); }

        /// <summary>
        /// Returns a string that represents the contents of the array, formatted as a property list.
        /// </summary>
        /// <param name="locale">An NSLocale object or an NSDictionary object that specifies options used for formatting each of the array’s elements (where recognized). Specify nil if you don’t want the elements formatted.</param>
        /// <param name="indent">A level of indent, to make the output more readable: set level to 0 to use four spaces to indent, or 1 to indent the output with a tab character.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale, int indent) { return default(string); }

        /// <summary>
        /// Writes the contents of the array to a file at a given path.
        /// </summary>
        /// <param name="path">The path at which to write the contents of the array.
        ///   If path contains a tilde (~) character, you must expand it with stringByExpandingTildeInPath before invoking this method.</param>
        /// <param name="atomically">If true, the array is written to an auxiliary file, and then the auxiliary file is renamed to path. If false, the array is written directly to path. The true option guarantees that path, if it exists at all, won’t be corrupted even if the system should crash during writing.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("writeToFile")]
        public bool WriteToFile(string path, bool atomically) { return default(bool); }

        /// <summary>
        /// Writes the contents of the array to the location specified by a given URL.
        /// </summary>
        /// <param name="aURL">The location at which to write the array.</param>
        /// <param name="atomically">If true, the array is written to an auxiliary location, and then the auxiliary location is renamed to aURL. If false, the array is written directly to aURL. The true option guarantees that aURL, if it exists at all, won’t be corrupted even if the system should crash during writing.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("writeToURL")]
        public bool WriteToURL(NSURL aURL, bool atomically) { return default(bool); }

        /// <summary>
        /// Returns an array containing all the pathname elements in the receiving array that have filename extensions from a given array.
        /// </summary>
        /// <param name="filterTypes">An array of NSString objects containing filename extensions. The extensions should not include the dot (“.”) character.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("pathsMatchingExtensions")]
        public AnyObject[] PathsMatchingExtensions(AnyObject[] filterTypes) { return default(AnyObject[]); }

        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to register for KVO notifications. The observer must implement the key-value observing method observeValueForKeyPath:ofObject:change:context:.</param>
        /// <param name="forKeyPath">The key path, relative to the array, of the property to observe. This value must not be nil.</param>
        /// <param name="options">A combination of NSKeyValueObservingOptions values that specifies what is included in observation notifications.</param>
        /// <param name="context">Arbitrary data that is passed to observer in observeValueForKeyPath:ofObject:change:context:.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("addObserver")]
        public void AddObserver(NSObject observer, string forKeyPath, NSKeyValueObservingOptions options, UnsafePointer<Action> context) { }

        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to remove as an observer.</param>
        /// <param name="forKeyPath">A key-path, relative to the array, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject observer, string forKeyPath) { }

        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to remove as an observer.</param>
        /// <param name="forKeyPath">A key-path, relative to the set, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>
        /// <param name="context">The context passed to the notifications.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(5)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject observer, string forKeyPath, UnsafePointer<Action> context) { }

        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to remove as an observer.</param>
        /// <param name="fromObjectsAtIndexes"></param>
        /// <param name="forKeyPath">A key-path, relative to the array, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>
        /// <param name="context">The context passed to the notifications.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(5)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject observer, NSIndexSet fromObjectsAtIndexes, string forKeyPath, UnsafePointer<Action> context) { }

        /// <summary>
        /// Registers an observer to receive key value observer notifications for the specified key-path relative to the objects at the indexes.
        /// </summary>
        /// <param name="anObserver">The observer.</param>
        /// <param name="toObjectsAtIndexes">The index set.</param>
        /// <param name="forKeyPath">The key path, relative to the array, to be observed.</param>
        /// <param name="options">The options to be included in the notification.</param>
        /// <param name="context">The context passed to the notifications.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("addObserver")]
        public void AddObserver(NSObject anObserver, NSIndexSet toObjectsAtIndexes, string forKeyPath, NSKeyValueObservingOptions options, UnsafePointer<Action> context) { }

        /// <summary>
        /// Removes anObserver from all key value observer notifications associated with the specified keyPath relative to the array’s objects at indexes.
        /// </summary>
        /// <param name="anObserver">The observer.</param>
        /// <param name="fromObjectsAtIndexes">The index set.</param>
        /// <param name="forKeyPath">The key path, relative to the array, to be observed.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject anObserver, NSIndexSet fromObjectsAtIndexes, string forKeyPath) { }

        /// <summary>
        /// Invokes setValue:forKey: on each of the array's items using the specified value and key.
        /// </summary>
        /// <param name="value">The object value.</param>
        /// <param name="forKey">The key to store the value.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("setValue")]
        public void SetValue(AnyObject value, string forKey) { }

        /// <summary>
        /// Returns an array containing the results of invoking valueForKey: using key on each of the array's objects.
        /// </summary>
        /// <param name="key">The key to retrieve.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [Export("valueForKey")]
        public AnyObject ValueForKey(string key) { return default(AnyObject); }

        /// <summary>
        /// Options for searches and insertions using indexOfObject:inSortedRange:options:usingComparator:.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        public NSArray(uint value) { }
    }
}