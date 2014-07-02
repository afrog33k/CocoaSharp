using ObjectiveC;

    /// <summary>
    /// Bit mask flags indicating the types of jobs that the printer supports.
    /// </summary>
    public enum UIPrinterJobTypes
    {
        /// <summary>
        /// The printer support is unknown.
        /// </summary>
        [iOSVersion(8)]
        Unknown,

        /// <summary>
        /// The printer supports standard document printing.
        /// </summary>
        [iOSVersion(8)]
        Document,

        /// <summary>
        /// The printer supports printing on envelopes.
        /// </summary>
        [iOSVersion(8)]
        Envelope,

        /// <summary>
        /// The printer supports printing on cut labels.
        /// </summary>
        [iOSVersion(8)]
        Label,

        /// <summary>
        /// The printer supports printing with photographic print quality.
        /// </summary>
        [iOSVersion(8)]
        Photo,

        /// <summary>
        /// The printer supports printing receipts on a continuous roll of paper.
        /// </summary>
        [iOSVersion(8)]
        Receipt,

        /// <summary>
        /// The printer supports printing documents or photos on a continuous roll of paper.
        /// </summary>
        [iOSVersion(8)]
        Roll,

        /// <summary>
        /// The printer supports printing larger than the ISO A3 size.
        /// </summary>
        [iOSVersion(8)]
        LargeFormat,

        /// <summary>
        /// The printer supports printing on postcards.
        /// </summary>
        [iOSVersion(8)]
        Postcard,
    }