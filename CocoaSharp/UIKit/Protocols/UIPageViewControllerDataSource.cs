using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPageViewControllerDataSourceProtocolRef/index.html#//apple_ref/occ/intf/UIPageViewControllerDataSource	/// <summary>	/// The UIPageViewControllerDataSource protocol is adopted by an object that provides view controllers to the page view controller on an as-needed basis, in response to navigation gestures.	/// </summary>	[iOSVersion(5)]	public interface UIPageViewControllerDataSource	{		/// <summary>		/// Returns the view controller before the given view controller. (required)		/// </summary>		/// <param name="pageViewController">The page view controller</param>		/// <param name="viewControllerBeforeViewController">The view controller that the user navigated away from.</param>		/// <returns>The view controller before the given view controller, or nil to indicate that there is no previous view controller.</returns>		[iOSVersion(5)]		[Export("pageViewController")]		UIViewController PageViewControllerPreViewController(UIPageViewController pageViewController, UIViewController viewControllerBeforeViewController);				/// <summary>		/// Returns the view controller after the given view controller. (required)		/// </summary>		/// <param name="pageViewController">The page view controller</param>		/// <param name="viewControllerAfterViewController">The view controller that the user navigated away from.</param>		/// <returns>The view controller after the given view controller, or nil to indicate that there is no next view controller.</returns>		[iOSVersion(5)]		[Export("pageViewController")]		UIViewController PageViewControllerPostViewController(UIPageViewController pageViewController, UIViewController viewControllerAfterViewController);				/// <summary>		/// Returns the number of items to be reflected in the page indicator.		/// </summary>		/// <param name="pageViewController">The page view controller.</param>		/// <returns>The number of items to be reflected in the page indicator.</returns>		[iOSVersion(6)]		[Export("presentationCountForPageViewController")]		[Optional]		int PresentationCountForPageViewController(UIPageViewController pageViewController);				/// <summary>		/// Returns the index of the selected item to be reflected in the page indicator.		/// </summary>		/// <param name="pageViewController">The page view controller.</param>		/// <returns>The index of the selected item to be reflected in the page indicator.</returns>		[iOSVersion(6)]		[Export("presentationIndexForPageViewController")]		[Optional]		int PresentationIndexForPageViewController(UIPageViewController pageViewController);	}}