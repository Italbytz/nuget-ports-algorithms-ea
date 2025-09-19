namespace Italbytz.EA.Individuals;

/// <summary>
/// Represents a genotype that can make predictions based on features.
/// </summary>
/// <typeparam name="TCategory">The type of category features used for classification.</typeparam>
public interface IPredictingGenotype<TCategory> : IGenotype
{
    /// <summary>
    /// Predicts a continuous value based on given features.
    /// </summary>
    /// <param name="features">The input feature vector.</param>
    /// <returns>The predicted value.</returns>
    float PredictValue(float[] features);

    /// <summary>
    /// Predicts continuous values for multiple feature sets.
    /// </summary>
    /// <param name="features">The input feature vectors.</param>
    /// <param name="labels">The actual labels for evaluation purposes.</param>
    /// <returns>An array of predicted values.</returns>
    float[] PredictValues(float[][] features, float[] labels);
    
    /// <summary>
    /// Predicts a class index based on category features.
    /// </summary>
    /// <param name="features">The input category features.</param>
    /// <returns>The predicted class index.</returns>
    int PredictClass(TCategory[] features);

    /// <summary>
    /// Predicts class indices for multiple category feature sets.
    /// </summary>
    /// <param name="features">The input category feature sets.</param>
    /// <param name="labels">The actual class indices for evaluation purposes.</param>
    /// <returns>An array of predicted class indices.</returns>
    int[] PredictClasses(TCategory[][] features, int[] labels);
}