using iRSDKSharp;

namespace iRacingSdkWrapper
{
    public interface ITelemetryValue<T>
    {
        /// <summary>
        /// The value of this parameter.
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Whether or not a telemetry value with this name exists on the current car.
        /// </summary>
        bool Exists { get; }

        /// <summary>
        /// The name of this telemetry value parameter.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The description of this parameter.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The real world unit for this parameter.
        /// </summary>
        string Unit { get; }

        /// <summary>
        /// The data-type for this parameter.
        /// </summary>
        CVarHeader.VarType Type { get; }

        object GetValue();
        string ToString();
    }
}