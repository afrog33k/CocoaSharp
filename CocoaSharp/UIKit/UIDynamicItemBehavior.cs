using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A dynamic item behavior represents a base dynamic animation configuration for one or more dynamic items. Each of its properties overrides a corresponding default value.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDynamicItemBehavior_Class/index.html#//apple_ref/occ/cl/UIDynamicItemBehavior"/>    [iOSVersion(7)]    [Export("")]    public class UIDynamicItemBehavior : UIDynamicBehavior//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable    {        public UIDynamicItemBehavior() { }        /// <summary>        /// Adds a dynamic item to the dynamic item behavior’s item array.        /// </summary>        /// <param name="item">The dynamic item to add to the item array.</param>        [iOSVersion(7)]        [Export("addItem")]        public virtual void AddItem(UIDynamicItem item) {  }                /// <summary>        /// Initializes a dynamic item behavior with an array of dynamic items.        /// </summary>        /// <param name="items">The dynamic items that you want to be subject to the dynamic item behavior.</param>        [iOSVersion(7)]        public UIDynamicItemBehavior(AnyObject[] items) { }                /// <summary>        /// Removes a specific dynamic item from the dynamic item behavior.        /// </summary>        /// <param name="item">The dynamic item that you want to remove.</param>        [iOSVersion(7)]        [Export("removeItem")]        public virtual void RemoveItem(UIDynamicItem item) {  }                /// <summary>        /// Adds a specified angular velocity to a dynamic item.        /// </summary>        /// <param name="velocity">The angular velocity, expressed in radians per second, that you want to add to the specified dynamic item. Default value is 0. Applying a negative value reduces the angular velocity by the specified amount.</param>        /// <param name="forItem">The dynamic item whose angular velocity you want to increase (or decrease).</param>        [iOSVersion(7)]        [Export("addAngularVelocity")]        public virtual void AddAngularVelocity(CGFloat velocity, UIDynamicItem forItem) {  }                /// <summary>        /// Adds a specified linear velocity to a dynamic item.        /// </summary>        /// <param name="velocity">The linear velocity, expressed in points per second, that you want to add to the specified dynamic item. Default value is 0. Applying a negative value reduces the linear velocity by the specified amount.</param>        /// <param name="forItem">The dynamic item whose linear velocity you want to increase (or decrease).</param>        [iOSVersion(7)]        [Export("addLinearVelocity")]        public virtual void AddLinearVelocity(CGPoint velocity, UIDynamicItem forItem) {  }                /// <summary>        /// Returns the angular velocity for a specified dynamic item.        /// </summary>        /// <param name="item">The dynamic item whose angular velocity you want to get.</param>        [iOSVersion(7)]        [Export("angularVelocityForItem")]        public virtual CGFloat AngularVelocityForItem(UIDynamicItem item) { return default(CGFloat); }                /// <summary>        /// Returns the linear velocity for a specified dynamic item.        /// </summary>        /// <param name="item">The dynamic item whose linear velocity you want to get.</param>        [iOSVersion(7)]        [Export("linearVelocityForItem")]        public virtual CGPoint LinearVelocityForItem(UIDynamicItem item) { return default(CGPoint); }                /// <summary>        /// Returns the set of dynamic items you’ve added to the dynamic item behavior. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("items")]        public AnyObject[] Items { get; private set; }                /// <summary>        /// Specifies whether rotation is allowed for the behavior’s dynamic items.        /// </summary>        [iOSVersion(7)]        [Export("allowsRotation")]        public bool AllowsRotation { get; set; }                /// <summary>        /// The angular resistance for the behavior’s dynamic items.        /// </summary>        [iOSVersion(7)]        [Export("angularResistance")]        public CGFloat AngularResistance { get; set; }                /// <summary>        /// The relative mass density of the behavior’s dynamic items.        /// </summary>        [iOSVersion(7)]        [Export("density")]        public CGFloat Density { get; set; }                /// <summary>        /// The amount of elasticity applied to collisions for the behavior’s dynamic items.        /// </summary>        [iOSVersion(7)]        [Export("elasticity")]        public CGFloat Elasticity { get; set; }                /// <summary>        /// The linear resistance for the behavior’s dynamic items when two slide against each other.        /// </summary>        [iOSVersion(7)]        [Export("friction")]        public CGFloat Friction { get; set; }                /// <summary>        /// The linear resistance for the behavior’s dynamic items, which reduces their linear velocity over time.        /// </summary>        [iOSVersion(7)]        [Export("resistance")]        public CGFloat Resistance { get; set; }    }}