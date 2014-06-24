﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSFilePresenter_protocol/index.html#//apple_ref/occ/intf/NSFilePresenter
    /// <summary>
    /// The NSCoding protocol declares the two methods that a class must implement so that instances of that class can be encoded and decoded. This capability provides the basis for archiving (where objects and other structures are stored on disk) and distribution (where objects are copied to different address spaces).
    /// </summary>
    [iOSVersion(2)]
    public interface NSFilePresenter
    {
        //TODO: do this
    }
}
