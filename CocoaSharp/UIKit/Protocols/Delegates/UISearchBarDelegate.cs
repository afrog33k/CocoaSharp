using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UISearchBarDelegate protocol defines the optional methods you implement to make a UISearchBar control functional. A UISearchBar object provides the user interface for a search field on a bar, but it’s the application’s responsibility to implement the actions when buttons are tapped. At a minimum, the delegate needs to perform the actual search when text is entered in the text field.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UISearchBarDelegate_Protocol/index.html#//apple_ref/occ/intf/UISearchBarDelegate"/>    [iOSVersion(2)]    [Export("")]    public interface UISearchBarDelegate//: NSObjectProtocol, UIBarPositioningDelegate    {        /// <summary>        /// Tells the delegate that the user changed the search text.        /// </summary>        /// <param name="searchBar">The search bar that is being edited.</param>        /// <param name="textDidChange">The current text in the search text field.</param>        //[iOSVersion(2)]        //[Export("searchBar")]        //[InheritOptional]        //void SearchBar(UISearchBar searchBar, string textDidChange);                /// <summary>        /// Ask the delegate if text in a specified range should be replaced with given text.        /// </summary>        /// <param name="searchBar">The search bar that is being edited.</param>        /// <param name="shouldChangeTextInRange">The range of the text to be changed.</param>        /// <param name="replacementText">The text to replace existing text in range.</param>        //[iOSVersion(3)]        //[Export("searchBar")]        //[InheritOptional]        //bool SearchBar(UISearchBar searchBar, NSRange shouldChangeTextInRange, string replacementText);                /// <summary>        /// Asks the delegate if editing should begin in the specified search bar.        /// </summary>        /// <param name="searchBar">The search bar that is being edited.</param>        //[iOSVersion(2)]        //[Export("searchBarShouldBeginEditing")]        //[InheritOptional]        //bool SearchBarShouldBeginEditing(UISearchBar searchBar);                /// <summary>        /// Tells the delegate when the user begins editing the search text.        /// </summary>        /// <param name="searchBar">The search bar that is being edited.</param>        //[iOSVersion(2)]        //[Export("searchBarTextDidBeginEditing")]        //[InheritOptional]        //void SearchBarTextDidBeginEditing(UISearchBar searchBar);                /// <summary>        /// Asks the delegate if editing should stop in the specified search bar.        /// </summary>        /// <param name="searchBar">The search bar that is being edited.</param>        //[iOSVersion(2)]        //[Export("searchBarShouldEndEditing")]        //[InheritOptional]        //bool SearchBarShouldEndEditing(UISearchBar searchBar);                /// <summary>        /// Tells the delegate that the user finished editing the search text.        /// </summary>        /// <param name="searchBar">The search bar that is being edited.</param>        //[iOSVersion(2)]        //[Export("searchBarTextDidEndEditing")]        //[InheritOptional]        //void SearchBarTextDidEndEditing(UISearchBar searchBar);                /// <summary>        /// Tells the delegate that the bookmark button was tapped.        /// </summary>        /// <param name="searchBar">The search bar that was tapped.</param>        //[iOSVersion(2)]        //[Export("searchBarBookmarkButtonClicked")]        //[InheritOptional]        //void SearchBarBookmarkButtonClicked(UISearchBar searchBar);                /// <summary>        /// Tells the delegate that the cancel button was tapped.        /// </summary>        /// <param name="searchBar">The search bar that was tapped.</param>        //[iOSVersion(2)]        //[Export("searchBarCancelButtonClicked")]        //[InheritOptional]        //void SearchBarCancelButtonClicked(UISearchBar searchBar);                /// <summary>        /// Tells the delegate that the search button was tapped.        /// </summary>        /// <param name="searchBar">The search bar that was tapped.</param>        //[iOSVersion(2)]        //[Export("searchBarSearchButtonClicked")]        //[InheritOptional]        //void SearchBarSearchButtonClicked(UISearchBar searchBar);                /// <summary>        /// Tells the delegate that the search results list button was tapped.        /// </summary>        /// <param name="searchBar">The search bar that was tapped.</param>        //[iOSVersion(3.2)]        //[Export("searchBarResultsListButtonClicked")]        //[InheritOptional]        //void SearchBarResultsListButtonClicked(UISearchBar searchBar);                /// <summary>        /// Tells the delegate that the scope button selection changed.        /// </summary>        /// <param name="searchBar">The search bar that was tapped.</param>        /// <param name="selectedScopeButtonIndexDidChange">The index of the selected scope button (see selectedScopeButtonIndex).</param>        //[iOSVersion(3)]        //[Export("searchBar")]        //[InheritOptional]        //void SearchBar(UISearchBar searchBar, int selectedScopeButtonIndexDidChange);    }}