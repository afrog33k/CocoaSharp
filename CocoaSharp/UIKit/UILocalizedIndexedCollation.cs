using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace UIKit{    /// <summary>    /// The UILocalizedIndexedCollation class is a convenience for organizing, sorting, and localizing the data for a table view that has a section index. The table view’s data source then uses the collation object to provide the table view with input for section titles and section index titles.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/iPhone/Reference/UILocalizedIndexedCollation_Class/index.html#//apple_ref/occ/cl/UILocalizedIndexedCollation"/>    [iOSVersion(3)]    public class UILocalizedIndexedCollation : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Returns a indexed-collation instance for the current table view.        /// </summary>        [iOSVersion(3)]        [Export("currentCollation")]        public static AnyObject CurrentCollation() { return default(AnyObject); }                /// <summary>        /// Returns an integer identifying the section in which a model object belongs.        /// </summary>        /// <param name="@object">A model object of the application that is part of the data model for the table view.</param>        /// <param name="collationStringSelector">A selector that identifies a method returning an identifying string for object that is used in collation. The method should take no arguments and return an NSString object. For example, this could be a name property on the object.</param>        [iOSVersion(3)]        [Export("sectionForObject")]        public int SectionForObject(AnyObject @object, Selector collationStringSelector) { return default(int); }                /// <summary>        /// Sorts the objects within a section by their localized titles.        /// </summary>        /// <param name="array">An array containing the model objects for a section.</param>        /// <param name="collationStringSelector">A selector that identifies a method returning an identifying string for each object in array. The index-collation object uses this string for sorting the objects in the array. The method should take no arguments and return an NSString object. For example, this could be a name property on the object.</param>        [iOSVersion(3)]        [Export("sortedArrayFromArray")]        public AnyObject[] SortedArrayFromArray(AnyObject[] array, Selector collationStringSelector) { return default(AnyObject[]); }                /// <summary>        /// Returns the section that the table view should scroll to for the given index title.        /// </summary>        /// <param name="indexTitleIndex">An integer identifying a section-index title by its position in the array of such titles.</param>        [iOSVersion(3)]        [Export("sectionForSectionIndexTitleAtIndex")]        public int SectionForSectionIndexTitleAtIndex(int indexTitleIndex) { return default(int); }                /// <summary>        /// Returns the list of section titles for the table view. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("sectionTitles")]        public AnyObject[] SectionTitles { get; private set; }                /// <summary>        /// Returns the list of section-index titles for the table view (read-only)        /// </summary>        [iOSVersion(3)]        [Export("sectionIndexTitles")]        public AnyObject[] SectionIndexTitles { get; private set; }    }}