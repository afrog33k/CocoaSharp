using ObjectiveC;
    }

    /// <summary>
    /// The duplex mode of a selected printer.
    /// </summary>
    public enum UIPrintInfoDuplex
    {
        /// <summary>
        /// No double-sided (duplex) printing; single-sided printing only.
        /// </summary>
        [iOSVersion(4.2)]
        None,

        /// <summary>
        /// Duplex printing that flips the back page along the long edge of the paper.
        /// </summary>
        [iOSVersion(4.2)]
        LongEdge,

        /// <summary>
        /// Duplex print that flips the back page along the short edge of the paper.
        /// </summary>
        [iOSVersion(4.2)]
        ShortEdge,
    }
    /// <summary>
    /// The orientation of printing on a page.
    /// </summary>
    public enum UIPrintInfoOrientation
    {
        /// <summary>
        /// Pages are printed in portrait orientation.
        /// </summary>
        [iOSVersion(4.2)]
        Portrait,

        /// <summary>
        /// Pages are printed in landscape orientation.
        /// </summary>
        [iOSVersion(4.2)]
        Landscape,
    }
    /// <summary>
    /// The output type, which is an indication of the type of content the application is drawing or providing.
    /// </summary>
    public enum UIPrintInfoOutputType
    {
        /// <summary>
        /// Specifies that the printed content consists of mixed text, graphics, and images. The default paper is Letter, A4, or similar locale-specific designation. Output is normal quality, duplex.
        /// </summary>
        [iOSVersion(4.2)]
        General,

        /// <summary>
        /// Specifies that the printed content consists of black-and-white or color images. The default paper is 4x6, A6, or similar locale-specific designation. Output is high quality, simplex.
        /// </summary>
        [iOSVersion(4.2)]
        Photo,

        /// <summary>
        /// Specifies that the printed content is grayscale. Set the output type to this value when your printable content contains no color—for example, it’s black text only. The default paper is Letter/A4. Output is grayscale quality, duplex. This content type can produce a performance improvement in some cases.
        /// </summary>
        [iOSVersion(4.2)]
        Grayscale,

        /// <summary>
        /// Specifies that the printed content is a grayscale image. Set the output type to this value when your printable content contains no color—for example, it’s black text only. The default paper is Letter/A4. Output is high quality grayscale, duplex.
        /// </summary>
        [iOSVersion(7)]
        PhotoGrayscale,
    }