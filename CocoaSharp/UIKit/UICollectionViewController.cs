using ObjectiveC;
	{
	    /// <summary>
	    /// Initializes a collection view controller and configures the collection view with the provided layout.
	    /// </summary>
	    /// <param name="collectionViewLayout">The layout object to associate with the collection view. The layout controls how the collection view presents its cells and supplementary views.</param>
	    /// <returns>An initialized UICollectionViewController object or nil if the object could not be created.</returns>
	    [iOSVersion(6)]
	    public UICollectionViewController(UICollectionViewLayout collectionViewLayout) : base("", null) { }