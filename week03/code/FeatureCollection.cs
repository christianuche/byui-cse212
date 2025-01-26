public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; }
}


public class Feature
{
    public Properties Properties { get; set; }
}


public class Properties
{
    public string Place { get; set; }
    public double? Mag { get; set; } // Magnitude can be null, so use a nullable double
}