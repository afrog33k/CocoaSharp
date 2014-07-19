using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSMapTable_class/index.html#//apple_ref/occ/cl/NSMapTable
    /// <summary>
    /// NSMapTable is a mutable collection modeled after NSDictionary but provides different options.
    /// </summary>
    [iOSVersion(6)]
    public class NSMapTable : NSObject
    {
        /// <summary>
        /// Returns a map table, initialized with the given options.
        /// </summary>
        /// <param name="keyOptions">A bit field that specifies the options for the keys in the map table. For possible values, see “NSMapTableOptions”.</param>
        /// <param name="valueOptions">A bit field that specifies the options for the values in the map table. For possible values, see “NSMapTableOptions”.</param>
        /// <param name="capacity">The initial capacity of the map table. This is just a hint; the map table may subsequently grow and shrink as required.</param>
        /// <returns>A map table initialized using the given options.</returns>
        [iOSVersion(6)]
        public NSMapTable(NSPointerFunctionsOptions keyOptions, NSPointerFunctionsOptions valueOptions, int capacity) { }
        
        /// <summary>
        /// Returns a new map table, initialized with the given options
        /// </summary>
        /// <param name="keyOptions">A bit field that specifies the options for the keys in the map table. For possible values, see “NSMapTableOptions”.</param>
        /// <param name="valueOptions">A bit field that specifies the options for the values in the map table. For possible values, see “NSMapTableOptions”.</param>
        /// <returns>A new map table, initialized with the given options.</returns>
        [iOSVersion(6)]
        public NSMapTable(NSPointerFunctionsOptions keyOptions, NSPointerFunctionsOptions valueOptions) { }
        
        /// <summary>
        /// Returns a map table, initialized with the given functions.
        /// </summary>
        /// <param name="keyPointerFunctions">The functions the map table uses to manage keys.</param>
        /// <param name="valuePointerFunctions">The functions the map table uses to manage values.</param>
        /// <param name="capacity">The initial capacity of the map table. This is just a hint; the map table may subsequently grow and shrink as required.</param>
        /// <returns>A map table, initialized with the given functions.</returns>
        [iOSVersion(6)]
        public NSMapTable(NSPointerFunctions keyPointerFunctions, NSPointerFunctions valuePointerFunctions, int capacity) { }
        
        /// <summary>
        /// Returns a new map table object which has strong references to the keys and values.
        /// </summary>
        /// <returns>A new map table object which has strong references to the keys and values.</returns>
        [iOSVersion(6)]
        [Export("strongToStrongObjectsMapTable")]
        public static NSMapTable StrongToStrongObjectsMapTable() { return null; }
        
        /// <summary>
        /// Returns a new map table object which has weak references to the keys and strong references to the values.
        /// </summary>
        /// <returns>A new map table object which has weak references to the keys and strong references to the values.</returns>
        [iOSVersion(6)]
        [Export("weakToStrongObjectsMapTable")]
        public static NSMapTable WeakToStrongObjectsMapTable() { return null; }
        
        /// <summary>
        /// Returns a new map table object which has strong references to the keys and weak references to the values.
        /// </summary>
        /// <returns>A new map table object which has strong references to the keys and weak references to the values.</returns>
        [iOSVersion(6)]
        [Export("strongToWeakObjectsMapTable")]
        public static NSMapTable StrongToWeakObjectsMapTable() { return null; }
        
        /// <summary>
        /// Returns a new map table object which has weak references to the keys and values.
        /// </summary>
        /// <returns>A new map table object which has weak references to the keys and values.</returns>
        [iOSVersion(6)]
        [Export("weakToWeakObjectsMapTable")]
        public static NSMapTable WeakToWeakObjectsMapTable() { return null; }
        
        /// <summary>
        /// Returns a the value associated with a given key.
        /// </summary>
        /// <param name="aKey">The key for which to return the corresponding value.</param>
        /// <returns>The value associated with aKey, or nil if no value is associated with aKey.</returns>
        [iOSVersion(6)]
        [Export("objectForKey")]
        public AnyObject ObjectForKey(AnyObject aKey) { return null; }
        
        /// <summary>
        /// Returns an enumerator object that lets you access each key in the map table.
        /// </summary>
        /// <returns>An enumerator object that lets you access each key in the map table.</returns>
        [iOSVersion(6)]
        [Export("keyEnumerator")]
        public NSEnumerator KeyEnumerator() { return null; }
        
        /// <summary>
        /// Returns an enumerator object that lets you access each value in the map table.
        /// </summary>
        /// <returns>An enumerator object that lets you access each value in the map table.</returns>
        [iOSVersion(6)]
        [Export("objectEnumerator")]
        public NSEnumerator ObjectEnumerator() { return null; }
        
        /// <summary>
        /// Returns the number of key-value pairs in the map table.
        /// </summary>
        /// <returns>The number of key-value pairs in the map table.</returns>
        [iOSVersion(6)]
        [Export("count")]
        public int Count { get; private set; }
        
        /// <summary>
        /// Adds a given key-value pair to the map table.
        /// </summary>
        /// <param name="anObject">The value for aKey. This value must not be nil.</param>
        /// <param name="forKey">The key for anObject. This value must not be nil.</param>
        [iOSVersion(6)]
        [Export("setObject")]
        public void SetObject(AnyObject anObject, AnyObject forKey) { }
        
        /// <summary>
        /// Removes a given key and its associated value from the map table.
        /// </summary>
        /// <param name="aKey">The key to remove.</param>
        [iOSVersion(6)]
        [Export("removeObjectForKey")]
        public void RemoveObjectForKey(AnyObject aKey) { }
        
        /// <summary>
        /// Empties the map table of its entries.
        /// </summary>
        [iOSVersion(6)]
        [Export("removeAllObjects")]
        public void RemoveAllObjects() { }
        
        /// <summary>
        /// Returns a dictionary representation of the map table.
        /// </summary>
        /// <returns>A dictionary representation of the map table.</returns>
        [iOSVersion(6)]
        [Export("dictionaryRepresentation")]
        public NSDictionary DictionaryRepresentation() { return null; }
        
        /// <summary>
        /// Returns the pointer functions the map table uses to manage keys.
        /// </summary>
        /// <returns>The pointer functions the map table uses to manage keys.</returns>
        [iOSVersion(6)]
        [Export("keyPointerFunctions")]
        public NSPointerFunctions KeyPointerFunctions { get; private set; }
        
        /// <summary>
        /// Returns the pointer functions the map table uses to manage values.
        /// </summary>
        /// <returns>The pointer functions the map table uses to manage values.</returns>
        [iOSVersion(6)]
        [Export("valuePointerFunctions")]
        public NSPointerFunctions ValuePointerFunctions { get; private set; }
    }
}