using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIContentContainer_Ref/index.html#//apple_ref/occ/intf/UIContentContainer	/// <summary>	/// The methods of the UIContentContainer protocol help you adapt the contents of your view controllers to size and trait changes. All UIViewController and UIPresentationController objects provide default implementations for the methods of this protocol. When creating your own custom view controller or presentation controller, you can override the default implementations to make adjustments to your content. For example, you might use these methods to adjust the size or position of any child view controllers.	/// </summary>	[iOSVersion(8)]	public interface UIContentContainer	{		/// <summary>		/// Notifies the container that the size of its view is about to change. (required)		/// </summary>		/// <param name="size">The new size for the container’s view.</param>		/// <param name="withTransitionCoordinator">The transition coordinator object managing the size change. You can use this object to animate your changes or get information about the transition that is in progress.</param>		[iOSVersion(8)]		[Export("viewWillTransitionToSize")]		void ViewWillTransitionToSize(CGSize size, UIViewControllerTransitionCoordinator withTransitionCoordinator);				/// <summary>		/// Notifies the container that its trait collection changed. (required)		/// </summary>		/// <param name="newCollection">The traits to be applied to the container.</param>		/// <param name="withTransitionCoordinator">The transition coordinator object managing the trait change. You can use this object to animate any changes or to get information about the transition that is in progress.</param>		[iOSVersion(8)]		[Export("willTransitionToTraitCollection")]		void WillTransitionToTraitCollection(UITraitCollection newCollection, UIViewControllerTransitionCoordinator withTransitionCoordinator);				/// <summary>		/// Returns the size of the specified child view controller’s content. (required)		/// </summary>		/// <param name="container">The child view controller.</param>		/// <param name="withParentContainerSize">The size of the parent view controller.</param>		/// <returns>The size to apply to the child view controller.</returns>		[iOSVersion(8)]		[Export("sizeForChildContentContainer")]		CGSize SizeForChildContentContainer(UIContentContainer container, CGSize withParentContainerSize);				/// <summary>		/// Notifies an interested controller that the preferred content size of one of its children changed.		/// </summary>		/// <param name="container">The child view controller who’s preferred content size has changed.</param>		[iOSVersion(8)]		[Export("preferredContentSizeDidChangeForChildContentContainer")]		void PreferredContentSizeDidChangeForChildContentContainer(UIContentContainer container);				/// <summary>		/// Notifies the container that a child view controller was resized using auto layout.		/// </summary>		/// <param name="container">The child view controller that received the resizing message.</param>		[iOSVersion(8)]		[Export("systemLayoutFittingSizeDidChangeForChildContentContainer")]		void SystemLayoutFittingSizeDidChangeForChildContentContainer(UIContentContainer container);				/// <summary>		/// The preferred size for the container’s content. (required) (read-only)		/// </summary>		[iOSVersion(8)]		[Export("preferredContentSize")]		CGSize PreferredContentSize { get; }	}}