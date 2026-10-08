//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Common;

namespace UnderAutomation.Yaskawa.HostControl {
	/// <summary>
	/// Contains Cartesian position data (TCP position and orientation).
	/// </summary>
	public class HostControlCartesianPositionData : HostControlResponse, ICartesianPosition {

		/// <summary>
		/// Gets or sets the X position in millimeters.
		/// </summary>
		public double X { get; }

		/// <summary>
		/// Gets or sets the Y position in millimeters.
		/// </summary>
		public double Y { get; }

		/// <summary>
		/// Gets or sets the Z position in millimeters.
		/// </summary>
		public double Z { get; }

		/// <summary>
		/// Gets or sets the Rx (rotation around X axis) in degrees.
		/// </summary>
		public double Rx { get; }

		/// <summary>
		/// Gets or sets the Ry (rotation around Y axis) in degrees.
		/// </summary>
		public double Ry { get; }

		/// <summary>
		/// Gets or sets the Rz (rotation around Z axis) in degrees.
		/// </summary>
		public double Rz { get; }

		/// <summary>
		/// Gets the elbow angle Re of a 7-axis robot, in degrees.
		/// On a 6-axis robot, value of the 7th axis (degrees or millimeters) when the external axes are read, 0 otherwise.
		/// </summary>
		public double Re { get; }

		/// <summary>
		/// Gets the tool number (0 to 63) of the position.
		/// </summary>
		public int ToolNumber { get; }

		/// <summary>
		/// Gets or sets the 8th external axis value.
		/// </summary>
		public double Axis8 { get; }

		/// <summary>
		/// Gets or sets the 9th external axis value.
		/// </summary>
		public double Axis9 { get; }

		/// <summary>
		/// Gets or sets the 10th external axis value.
		/// </summary>
		public double Axis10 { get; }

		/// <summary>
		/// Gets or sets the 11th external axis value.
		/// </summary>
		public double Axis11 { get; }

		/// <summary>
		/// Gets or sets the 12th external axis value.
		/// </summary>
		public double Axis12 { get; }

		/// <summary>
		/// Gets or sets the robot posture/configuration type.
		/// Defines arm configuration (flip, upper/lower arm, front/back, etc.).
		/// Use <see cref="UnderAutomation.Yaskawa.HostControl.HostControlCartesianPositionData.IsFlip"/>, <see cref="UnderAutomation.Yaskawa.HostControl.HostControlCartesianPositionData.IsUpperArm"/>, <see cref="UnderAutomation.Yaskawa.HostControl.HostControlCartesianPositionData.IsFront"/>... to read it.
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Gets or sets the coordinate system index.
		/// 0: Base, 1-65: User coordinates.
		/// </summary>
		public int CoordinateSystem { get; }

		/// <summary>
		/// Gets whether the robot is in flip configuration.
		/// </summary>
		public bool IsFlip { get; }

		/// <summary>
		/// Gets whether the robot is in upper arm configuration.
		/// </summary>
		public bool IsUpperArm { get; }

		/// <summary>
		/// Gets whether the robot is in front configuration.
		/// </summary>
		public bool IsFront { get; }

		/// <summary>
		/// Gets whether R axis is less than 180 degrees.
		/// </summary>
		public bool IsRLessThan180 { get; }

		/// <summary>
		/// Gets whether T axis is less than 180 degrees.
		/// </summary>
		public bool IsTLessThan180 { get; }

		/// <summary>
		/// Gets whether S axis is less than 180 degrees.
		/// </summary>
		public bool IsSLessThan180 { get; }
	}
}
