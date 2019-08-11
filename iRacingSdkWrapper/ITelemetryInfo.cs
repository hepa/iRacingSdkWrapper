using System.Collections.Generic;
using iRacingSdkWrapper.Bitfields;

namespace iRacingSdkWrapper
{
    public interface ITelemetryInfo
    {
        //IEnumerable<ITelemetryValue> GetValues();
        ITelemetryValue<float> MGUKDeployAdapt { get; }
        ITelemetryValue<float> MGUKDeployFixed { get; }
        ITelemetryValue<float> MGUKRegenGain { get; }
        ITelemetryValue<float> EnergyBatteryToMGU { get; }
        ITelemetryValue<float> EnergyBudgetBattToMGU { get; }
        ITelemetryValue<float> EnergyERSBattery { get; }
        ITelemetryValue<float> PowerMGUH { get; }
        ITelemetryValue<float> PowerMGUK { get; }
        ITelemetryValue<float> TorqueMGUK { get; }

        /// <summary>
        /// Current DRS status. 0 = inactive, 1 = can be activated in next DRS zone, 2 = can be activated now, 3 = active.
        /// </summary>
        ITelemetryValue<int> DrsStatus { get; }

        /// <summary>
        /// The number of laps you have completed. Note: on Nordschleife Tourist layout, you can complete a lap without starting a new one!
        /// </summary>
        ITelemetryValue<int> LapCompleted { get; }

        /// <summary>
        /// Seconds since session start. Unit: s
        /// </summary>
        ITelemetryValue<double> SessionTime { get; }

        /// <summary>
        /// Session number. 
        /// </summary>
        ITelemetryValue<int> SessionNum { get; }

        /// <summary>
        /// Session state. Unit: irsdk_SessionState
        /// </summary>
        ITelemetryValue<SessionStates> SessionState { get; }

        /// <summary>
        /// Session ID. 
        /// </summary>
        ITelemetryValue<int> SessionUniqueID { get; }

        /// <summary>
        /// Session flags. Unit: irsdk_Flags
        /// </summary>
        ITelemetryValue<SessionFlag> SessionFlags { get; }

        /// <summary>
        /// Driver activated flag. 
        /// </summary>
        ITelemetryValue<bool> DriverMarker { get; }

        /// <summary>
        /// 0=replay not playing  1=replay playing. 
        /// </summary>
        ITelemetryValue<bool> IsReplayPlaying { get; }

        /// <summary>
        /// Integer replay frame number (60 per second). 
        /// </summary>
        ITelemetryValue<int> ReplayFrameNum { get; }

        /// <summary>
        /// Current lap number by car index
        /// </summary>
        ITelemetryValue<int[]> CarIdxLap { get; }

        /// <summary>
        /// Current number of completed laps by car index. Note: On Nordschleife Tourist layout, cars can complete a lap without starting a new lap!
        /// </summary>
        ITelemetryValue<int[]> CarIdxLapCompleted { get; }

        /// <summary>
        /// Percentage distance around lap by car index. Unit: %
        /// </summary>
        ITelemetryValue<float[]> CarIdxLapDistPct { get; }

        /// <summary>
        /// Track surface type by car index. Unit: irsdk_TrkLoc
        /// </summary>
        ITelemetryValue<TrackSurfaces[]> CarIdxTrackSurface { get; }

        /// <summary>
        /// Steering wheel angle by car index. Unit: rad
        /// </summary>
        ITelemetryValue<float[]> CarIdxSteer { get; }

        /// <summary>
        /// Engine rpm by car index. Unit: revs/min
        /// </summary>
        ITelemetryValue<float[]> CarIdxRPM { get; }

        /// <summary>
        /// -1=reverse  0=neutral  1..n=current gear by car index. 
        /// </summary>
        ITelemetryValue<int[]> CarIdxGear { get; }

        ITelemetryValue<float[]> CarIdxF2Time { get; }
        ITelemetryValue<float[]> CarIdxEstTime { get; }
        ITelemetryValue<bool[]> CarIdxOnPitRoad { get; }
        ITelemetryValue<int[]> CarIdxPosition { get; }
        ITelemetryValue<int[]> CarIdxClassPosition { get; }

        /// <summary>
        /// Steering wheel angle. Unit: rad
        /// </summary>
        ITelemetryValue<float> SteeringWheelAngle { get; }

        /// <summary>
        /// 0=off throttle to 1=full throttle. Unit: %
        /// </summary>
        ITelemetryValue<float> Throttle { get; }

        /// <summary>
        /// 0=brake released to 1=max pedal force. Unit: %
        /// </summary>
        ITelemetryValue<float> Brake { get; }

        /// <summary>
        /// 0=disengaged to 1=fully engaged. Unit: %
        /// </summary>
        ITelemetryValue<float> Clutch { get; }

        /// <summary>
        /// -1=reverse  0=neutral  1..n=current gear. 
        /// </summary>
        ITelemetryValue<int> Gear { get; }

        /// <summary>
        /// Engine rpm. Unit: revs/min
        /// </summary>
        ITelemetryValue<float> RPM { get; }

        /// <summary>
        /// Lap count. 
        /// </summary>
        ITelemetryValue<int> Lap { get; }

        /// <summary>
        /// Meters traveled from S/F this lap. Unit: m
        /// </summary>
        ITelemetryValue<float> LapDist { get; }

        /// <summary>
        /// Percentage distance around lap. Unit: %
        /// </summary>
        ITelemetryValue<float> LapDistPct { get; }

        /// <summary>
        /// Laps completed in race. 
        /// </summary>
        ITelemetryValue<int> RaceLaps { get; }

        /// <summary>
        /// Longitudinal acceleration (including gravity). Unit: m/s^2
        /// </summary>
        ITelemetryValue<float> LongAccel { get; }

        /// <summary>
        /// Lateral acceleration (including gravity). Unit: m/s^2
        /// </summary>
        ITelemetryValue<float> LatAccel { get; }

        /// <summary>
        /// Vertical acceleration (including gravity). Unit: m/s^2
        /// </summary>
        ITelemetryValue<float> VertAccel { get; }

        /// <summary>
        /// Roll rate. Unit: rad/s
        /// </summary>
        ITelemetryValue<float> RollRate { get; }

        /// <summary>
        /// Pitch rate. Unit: rad/s
        /// </summary>
        ITelemetryValue<float> PitchRate { get; }

        /// <summary>
        /// Yaw rate. Unit: rad/s
        /// </summary>
        ITelemetryValue<float> YawRate { get; }

        /// <summary>
        /// GPS vehicle speed. Unit: m/s
        /// </summary>
        ITelemetryValue<float> Speed { get; }

        /// <summary>
        /// X velocity. Unit: m/s
        /// </summary>
        ITelemetryValue<float> VelocityX { get; }

        /// <summary>
        /// Y velocity. Unit: m/s
        /// </summary>
        ITelemetryValue<float> VelocityY { get; }

        /// <summary>
        /// Z velocity. Unit: m/s
        /// </summary>
        ITelemetryValue<float> VelocityZ { get; }

        /// <summary>
        /// Yaw orientation. Unit: rad
        /// </summary>
        ITelemetryValue<float> Yaw { get; }

        /// <summary>
        /// Pitch orientation. Unit: rad
        /// </summary>
        ITelemetryValue<float> Pitch { get; }

        /// <summary>
        /// Roll orientation. Unit: rad
        /// </summary>
        ITelemetryValue<float> Roll { get; }

        /// <summary>
        /// Active camera's focus car index. 
        /// </summary>
        ITelemetryValue<int> CamCarIdx { get; }

        /// <summary>
        /// Active camera number. 
        /// </summary>
        ITelemetryValue<int> CamCameraNumber { get; }

        /// <summary>
        /// Active camera group number. 
        /// </summary>
        ITelemetryValue<int> CamGroupNumber { get; }

        /// <summary>
        /// State of camera system. Unit: irsdk_CameraState
        /// </summary>
        ITelemetryValue<CameraState> CamCameraState { get; }

        /// <summary>
        /// 1=Car on track physics running. 
        /// </summary>
        ITelemetryValue<bool> IsOnTrack { get; }

        /// <summary>
        /// 1=Car in garage physics running. 
        /// </summary>
        ITelemetryValue<bool> IsInGarage { get; }

        /// <summary>
        /// Output torque on steering shaft. Unit: N*m
        /// </summary>
        ITelemetryValue<float> SteeringWheelTorque { get; }

        /// <summary>
        /// Force feedback % max torque on steering shaft. Unit: %
        /// </summary>
        ITelemetryValue<float> SteeringWheelPctTorque { get; }

        /// <summary>
        /// Percent of shift indicator to light up. Unit: %
        /// </summary>
        ITelemetryValue<float> ShiftIndicatorPct { get; }

        /// <summary>
        /// Bitfield for warning lights. Unit: irsdk_EngineWarnings
        /// </summary>
        ITelemetryValue<EngineWarning> EngineWarnings { get; }

        /// <summary>
        /// Liters of fuel remaining. Unit: l
        /// </summary>
        ITelemetryValue<float> FuelLevel { get; }

        /// <summary>
        /// Percent fuel remaining. Unit: %
        /// </summary>
        ITelemetryValue<float> FuelLevelPct { get; }

        /// <summary>
        /// Replay playback speed. 
        /// </summary>
        ITelemetryValue<int> ReplayPlaySpeed { get; }

        /// <summary>
        /// 0=not slow motion  1=replay is in slow motion. 
        /// </summary>
        ITelemetryValue<bool> ReplayPlaySlowMotion { get; }

        /// <summary>
        /// Seconds since replay session start. Unit: s
        /// </summary>
        ITelemetryValue<double> ReplaySessionTime { get; }

        /// <summary>
        /// Replay session number. 
        /// </summary>
        ITelemetryValue<int> ReplaySessionNum { get; }

        /// <summary>
        /// Engine coolant temp. Unit: C
        /// </summary>
        ITelemetryValue<float> WaterTemp { get; }

        /// <summary>
        /// Engine coolant level. Unit: l
        /// </summary>
        ITelemetryValue<float> WaterLevel { get; }

        /// <summary>
        /// Engine fuel pressure. Unit: bar
        /// </summary>
        ITelemetryValue<float> FuelPress { get; }

        /// <summary>
        /// Engine oil temperature. Unit: C
        /// </summary>
        ITelemetryValue<float> OilTemp { get; }

        /// <summary>
        /// Engine oil pressure. Unit: bar
        /// </summary>
        ITelemetryValue<float> OilPress { get; }

        /// <summary>
        /// Engine oil level. Unit: l
        /// </summary>
        ITelemetryValue<float> OilLevel { get; }

        /// <summary>
        /// Engine voltage. Unit: V
        /// </summary>
        ITelemetryValue<float> Voltage { get; }

        ITelemetryValue<double> SessionTimeRemain { get; }
        ITelemetryValue<int> ReplayFrameNumEnd { get; }
        ITelemetryValue<float> AirDensity { get; }
        ITelemetryValue<float> AirPressure { get; }
        ITelemetryValue<float> AirTemp { get; }
        ITelemetryValue<float> FogLevel { get; }
        ITelemetryValue<int> Skies { get; }
        ITelemetryValue<float> TrackTemp { get; }
        ITelemetryValue<float> TrackTempCrew { get; }
        ITelemetryValue<float> RelativeHumidity { get; }
        ITelemetryValue<int> WeatherType { get; }
        ITelemetryValue<float> WindDir { get; }
        ITelemetryValue<float> WindVel { get; }
        ITelemetryValue<int> PlayerCarTeamIncidentCount { get; }
        ITelemetryValue<int> PlayerCarMyIncidentCount { get; }
        ITelemetryValue<int> PlayerCarDriverIncidentCount { get; }
        ITelemetryValue<TrackSurfaces> PlayerTrackSurface { get; }
        ITelemetryValue<int> PlayerCarIdx { get; }
    }
}