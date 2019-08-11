using System;
using iRacingSdkWrapper.Broadcast;
using iRSDKSharp;

namespace iRacingSdkWrapper
{
    public interface ISdkWrapper
    {
        /// <summary>
        /// Gets the underlying iRacingSDK object.
        /// </summary>
        iRacingSDK Sdk { get; }

        /// <summary>
        /// Gets or sets how events are raised. Choose 'CurrentThread' to raise the events on the thread you created this object on (typically the UI thread), 
        /// or choose 'BackgroundThread' to raise the events on a background thread, in which case you have to delegate any UI code to your UI thread to avoid cross-thread exceptions.
        /// </summary>
        SdkWrapper.EventRaiseTypes EventRaiseType { get; set; }

        /// <summary>
        /// Is the main loop running?
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// Is the SDK connected to iRacing?
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Gets or sets the number of times the telemetry info is updated per second. The default and maximum is 60 times per second.
        /// </summary>
        double TelemetryUpdateFrequency { get; set; }

        /// <summary>
        /// The time in milliseconds between each check if iRacing is running. Use a low value (hundreds of milliseconds) to respond quickly to iRacing startup.
        /// Use a high value (several seconds) to conserve resources if an immediate response to startup is not required.
        /// </summary>
        int ConnectSleepTime { get; set; }

        /// <summary>
        /// Gets the Id (CarIdx) of yourself (the driver running this application).
        /// </summary>
        int DriverId { get; }

        /// <summary>
        /// Controls the replay playback system.
        /// </summary>
        ReplayControl Replay { get; }

        /// <summary>
        /// Provides control over the replay camera and where it is focused.
        /// </summary>
        CameraControl Camera { get; }

        /// <summary>
        /// Provides control over the pit commands.
        /// </summary>
        PitCommandControl PitCommands { get; }

        /// <summary>
        /// Provides control over the chat window.
        /// </summary>
        ChatControl Chat { get; }

        /// <summary>
        /// Provides control over reloading of car textures.
        /// </summary>
        TextureControl Textures { get; }

        /// <summary>
        /// Provides control over the telemetry recording system.
        /// </summary>
        TelemetryRecordingControl TelemetryRecording { get; }

        /// <summary>
        /// Connects to iRacing and starts the main loop in a background thread.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops the main loop
        /// </summary>
        void Stop();

        /// <summary>
        /// Return raw data object from the live telemetry.
        /// </summary>
        /// <param name="headerName">The name of the telemetry property to obtain.</param>
        object GetData(string headerName);

        /// <summary>
        /// Return live telemetry data wrapped in a TelemetryValue object of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the desired object.</typeparam>
        /// <param name="name">The name of the desired object.</param>
        TelemetryValue<T> GetTelemetryValue<T>(string name);

        /// <summary>
        /// Reads new session info and raises the SessionInfoUpdated event, regardless of if the session info has changed.
        /// </summary>
        void RequestSessionInfoUpdate();

        /// <summary>
        /// Event raised when the sim outputs telemetry information (60 times per second).
        /// </summary>
        event EventHandler<SdkWrapper.TelemetryUpdatedEventArgs> TelemetryUpdated;

        /// <summary>
        /// Event raised when the sim refreshes the session info (few times per minute).
        /// </summary>
        event EventHandler<SdkWrapper.SessionInfoUpdatedEventArgs> SessionInfoUpdated;

        /// <summary>
        /// Event raised when the SDK detects the sim for the first time.
        /// </summary>
        event EventHandler Connected;

        /// <summary>
        /// Event raised when the SDK no longer detects the sim (sim closed).
        /// </summary>
        event EventHandler Disconnected;
    }
}