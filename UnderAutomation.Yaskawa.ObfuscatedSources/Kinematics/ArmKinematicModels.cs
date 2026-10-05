//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Yaskawa.Kinematics.Internal;

namespace UnderAutomation.Yaskawa.Kinematics {
	/// <summary>
	/// Yaskawa Robot Known Arm Models
	/// </summary>
	public enum ArmKinematicModels {

		/// <summary>
		/// AR1440
		/// </summary>
		[ArmModel("AR1440", 155, 614, 200, 640, 0, 100, -90, 0, 0)]
AR1440 = 0,

		/// <summary>
		/// AR1730
		/// </summary>
		[ArmModel("AR1730", 150, 760, 200, 795, 0, 100, -90, 0, 0)]
AR1730 = 1,

		/// <summary>
		/// AR2010
		/// </summary>
		[ArmModel("AR2010", 150, 760, 200, 1082, 0, 100, -90, 0, 0)]
AR2010 = 2,

		/// <summary>
		/// AR3120
		/// </summary>
		[ArmModel("AR3120", 145, 1150, 250, 1812, 0, 100, -90, 0, 0)]
AR3120 = 3,

		/// <summary>
		/// AR700
		/// </summary>
		[ArmModel("AR700", 40, 345, 40, 340, 0, 80, -90, 0, 0)]
AR700 = 4,

		/// <summary>
		/// AR900
		/// </summary>
		[ArmModel("AR900", 40, 445, 40, 440, 0, 80, -90, 0, 0)]
AR900 = 5,

		/// <summary>
		/// DX1350D
		/// </summary>
		[ArmModel("DX1350D", 200, 600, 75, 550, 0, 120, -90, 0, 0)]
DX1350D = 6,

		/// <summary>
		/// EP4000D
		/// </summary>
		[ArmModel("EP4000D", 550, 1100, 250, 2135, 0, 255, 0, 0, 0)]
EP4000D = 7,

		/// <summary>
		/// EPH130D
		/// </summary>
		[ArmModel("EPH130D", 285, 1150, 250, 1225, 0, 225, -90, 0, 0)]
EPH130D = 8,

		/// <summary>
		/// EPH400D
		/// </summary>
		[ArmModel("EPH400D", 550, 1100, 250, 2135, 0, 255, 0, 0, 0)]
EPH400D = 9,

		/// <summary>
		/// EPX1250
		/// </summary>
		[ArmModel("EPX1250", 200, 520, 130, 520, 0, 86.5, -90, 0, 0)]
EPX1250 = 10,

		/// <summary>
		/// ES0165D-A00
		/// </summary>
		[ArmModel("ES0165D-A00", 285, 1150, 250, 1225, 0, 225, -90, 0, 0)]
ES0165D_A00 = 11,

		/// <summary>
		/// ES0165D-A10
		/// </summary>
		[ArmModel("ES0165D-A10", 285, 1150, 250, 1590, 0, 225, -90, 0, 0)]
ES0165D_A10 = 12,

		/// <summary>
		/// ES0165D-B00
		/// </summary>
		[ArmModel("ES0165D-B00", 285, 1150, 250, 1225, 0, 225, -90, 0, 0)]
ES0165D_B00 = 13,

		/// <summary>
		/// ES0165D-B10
		/// </summary>
		[ArmModel("ES0165D-B10", 285, 1150, 250, 1590, 0, 225, -90, 0, 0)]
ES0165D_B10 = 14,

		/// <summary>
		/// ES0165D-Z10
		/// </summary>
		[ArmModel("ES0165D-Z10", 285, 1150, 250, 1225, 0, 225, -90, 0, 0)]
ES0165D_Z10 = 15,

		/// <summary>
		/// ES0200D
		/// </summary>
		[ArmModel("ES0200D", 285, 1150, 250, 1225, 0, 250, -90, 0, 0)]
ES0200D = 16,

		/// <summary>
		/// ES0280D
		/// </summary>
		[ArmModel("ES0280D", 285, 1150, 250, 1225, 0, 250, -90, 0, 0)]
ES0280D = 17,

		/// <summary>
		/// ES165RD
		/// </summary>
		[ArmModel("ES165RD", 740, 1150, 250, 1225, 0, 225, 0, 0, 0)]
ES165RD = 18,

		/// <summary>
		/// ES200D
		/// </summary>
		[ArmModel("ES200D", 285, 1150, 250, 1225, 0, 250, -90, 0, 0)]
ES200D = 19,

		/// <summary>
		/// ES200RD-A00-Proto
		/// </summary>
		[ArmModel("ES200RD-A00-Proto", 740, 1150, 250, 1225, 0, 250, 0, 0, 0)]
ES200RD_A00_Proto = 20,

		/// <summary>
		/// ES200RD-A10
		/// </summary>
		[ArmModel("ES200RD-A10", 740, 1150, 250, 2100, 0, 225, 0, 0, 0)]
ES200RD_A10 = 21,

		/// <summary>
		/// ES200RD-J00
		/// </summary>
		[ArmModel("ES200RD-J00", 740, 1150, 250, 1225, 0, 250, 0, 0, 0)]
ES200RD_J00 = 22,

		/// <summary>
		/// ES200RD-Pack-Proto
		/// </summary>
		[ArmModel("ES200RD-Pack-Proto", 740, 1150, 250, 1225, 0, 250, 0, 0, 0)]
ES200RD_Pack_Proto = 23,

		/// <summary>
		/// ES280D
		/// </summary>
		[ArmModel("ES280D", 285, 1150, 250, 1225, 0, 250, -90, 0, 0)]
ES280D = 24,

		/// <summary>
		/// GA50
		/// </summary>
		[ArmModel("GA50", 330, 870, 250, 800, 0, 175, -90, 0, 0)]
GA50 = 25,

		/// <summary>
		/// GG250
		/// </summary>
		[ArmModel("GG250", 285, 1150, 300, 1275, 0, 250, -90, 0, 0)]
GG250 = 26,

		/// <summary>
		/// GP110
		/// </summary>
		[ArmModel("GP110", 320, 870, 235, 1020, 0, 200, -90, 0, 0)]
GP110 = 27,

		/// <summary>
		/// GP110H
		/// </summary>
		[ArmModel("GP110H", 320, 870, 300, 800, 0, 250, -90, 0, 0)]
GP110H = 28,

		/// <summary>
		/// GP12
		/// </summary>
		[ArmModel("GP12", 155, 614, 200, 640, 0, 100, -90, 0, 0)]
GP12 = 29,

		/// <summary>
		/// GP165R
		/// </summary>
		[ArmModel("GP165R", 740, 1150, 250, 1225, 0, 225, 0, 0, 0)]
GP165R = 30,

		/// <summary>
		/// GP180
		/// </summary>
		[ArmModel("GP180", 325, 1150, 300, 1225, 0, 225, -90, 0, 0)]
GP180 = 31,

		/// <summary>
		/// GP180H
		/// </summary>
		[ArmModel("GP180H", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
GP180H = 32,

		/// <summary>
		/// GP180-120
		/// </summary>
		[ArmModel("GP180-120", 325, 1150, 300, 1590, 0, 225, -90, 0, 0)]
GP180_120 = 33,

		/// <summary>
		/// GP200R
		/// </summary>
		[ArmModel("GP200R", 740, 1150, 250, 1225, 0, 250, 0, 0, 0)]
GP200R = 34,

		/// <summary>
		/// GP200S
		/// </summary>
		[ArmModel("GP200S", 325, 700, 300, 830, 0, 250, -90, 0, 0)]
GP200S = 35,

		/// <summary>
		/// GP20HL
		/// </summary>
		[ArmModel("GP20HL", 145, 1150, 250, 1812, 0, 100, -90, 0, 0)]
GP20HL = 36,

		/// <summary>
		/// GP215
		/// </summary>
		[ArmModel("GP215", 285, 1150, 250, 1490, 0, 250, -90, 0, 0)]
GP215 = 37,

		/// <summary>
		/// GP225
		/// </summary>
		[ArmModel("GP225", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
GP225 = 38,

		/// <summary>
		/// GP225H
		/// </summary>
		[ArmModel("GP225H", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
GP225H = 39,

		/// <summary>
		/// GP25
		/// </summary>
		[ArmModel("GP25", 150, 760, 200, 795, 0, 100, -90, 0, 0)]
GP25 = 40,

		/// <summary>
		/// GP250
		/// </summary>
		[ArmModel("GP250", 285, 1150, 250, 1285, 0, 250, -90, 0, 0)]
GP250 = 41,

		/// <summary>
		/// GP25SV
		/// </summary>
		[ArmModel("GP25SV", -150, 614, 200, 795, 0, 100, -90, 0, 0)]
GP25SV = 42,

		/// <summary>
		/// GP25-12
		/// </summary>
		[ArmModel("GP25-12", 150, 760, 200, 1082, 0, 100, -90, 0, 0)]
GP25_12 = 43,

		/// <summary>
		/// GP280
		/// </summary>
		[ArmModel("GP280", 285, 1150, 250, 1015, 0, 250, -90, 0, 0)]
GP280 = 44,

		/// <summary>
		/// GP280L
		/// </summary>
		[ArmModel("GP280L", 270, 1250, 300, 1566, 0, 270, -90, 0, 0)]
GP280L = 45,

		/// <summary>
		/// GP300R
		/// </summary>
		[ArmModel("GP300R", 750, 1050, 280, 1400, 0, 250, 0, 0, 0)]
GP300R = 46,

		/// <summary>
		/// GP35H
		/// </summary>
		[ArmModel("GP35H", 145, 870, 250, 1025, 0, 175, -90, 0, 0)]
GP35H = 47,

		/// <summary>
		/// GP35L
		/// </summary>
		[ArmModel("GP35L", 145, 1150, 210, 1225, 0, 175, -90, 0, 0)]
GP35L = 48,

		/// <summary>
		/// GP360
		/// </summary>
		[ArmModel("GP360", 270, 1250, 300, 1277, 0, 270, -90, 0, 0)]
GP360 = 49,

		/// <summary>
		/// GP4
		/// </summary>
		[ArmModel("GP4", 0, 260, 15, 290, 0, 72, -90, 0, 0)]
GP4 = 50,

		/// <summary>
		/// GP400
		/// </summary>
		[ArmModel("GP400", 400, 1050, 250, 1605, 0, 300, -90, 0, 0)]
GP400 = 51,

		/// <summary>
		/// GP400R
		/// </summary>
		[ArmModel("GP400R", 280, 1100, 250, 2135, 0, 255, 0, 0, 0)]
GP400R = 52,

		/// <summary>
		/// GP50
		/// </summary>
		[ArmModel("GP50", 145, 870, 210, 1025, 0, 175, -90, 0, 0)]
GP50 = 53,

		/// <summary>
		/// GP600
		/// </summary>
		[ArmModel("GP600", 400, 1050, 250, 1605, 0, 300, -90, 0, 0)]
GP600 = 54,

		/// <summary>
		/// GP7
		/// </summary>
		[ArmModel("GP7", 40, 445, 40, 440, 0, 80, -90, 0, 0)]
GP7 = 55,

		/// <summary>
		/// GP70L
		/// </summary>
		[ArmModel("GP70L", 320, 1165, 235, 1225, 0, 175, -90, 0, 0)]
GP70L = 56,

		/// <summary>
		/// GP8
		/// </summary>
		[ArmModel("GP8", 40, 345, 40, 340, 0, 80, -90, 0, 0)]
GP8 = 57,

		/// <summary>
		/// GP88
		/// </summary>
		[ArmModel("GP88", 320, 870, 210, 1025, 0, 175, -90, 0, 0)]
GP88 = 58,

		/// <summary>
		/// GP8L
		/// </summary>
		[ArmModel("GP8L", 155, 714, 200, 740, 0, 80, -90, 0, 0)]
GP8L = 59,

		/// <summary>
		/// HC10
		/// </summary>
		[ArmModel("HC10", 0, 700, 0, 500, 162, 130, -90, 90, 0)]
HC10 = 60,

		/// <summary>
		/// HC10DTF
		/// </summary>
		[ArmModel("HC10DTF", 0, 700, 0, 500, 162, 170, -90, 0, 0)]
HC10DTF = 61,

		/// <summary>
		/// HC10DTFP
		/// </summary>
		[ArmModel("HC10DTFP", 0, 700, 0, 500, 162, 170, -90, 0, 0)]
HC10DTFP = 62,

		/// <summary>
		/// HC10DTP
		/// </summary>
		[ArmModel("HC10DTP", 0, 700, 0, 500, 162, 170, -90, 0, 0)]
HC10DTP = 63,

		/// <summary>
		/// HC10DT_1-06VXHC10-A10
		/// </summary>
		[ArmModel("HC10DT_1-06VXHC10-A10", 0, 700, 0, 500, 162, 170, -90, 90, 0)]
HC10DT_1_06VXHC10_A10 = 64,

		/// <summary>
		/// HC10DT_1-06VXHC10-B10
		/// </summary>
		[ArmModel("HC10DT_1-06VXHC10-B10", 0, 700, 0, 500, 162, 170, -90, 0, 0)]
HC10DT_1_06VXHC10_B10 = 65,

		/// <summary>
		/// HC10DT_1-06VXHC10-B11
		/// </summary>
		[ArmModel("HC10DT_1-06VXHC10-B11", 0, 700, 0, 500, 162, 170, -90, 0, 0)]
HC10DT_1_06VXHC10_B11 = 66,

		/// <summary>
		/// HC10DT_1-06VXHC10-B12
		/// </summary>
		[ArmModel("HC10DT_1-06VXHC10-B12", 0, 700, 0, 500, 162, 170, -90, 0, 0)]
HC10DT_1_06VXHC10_B12 = 67,

		/// <summary>
		/// HC10DT_1-06VXHC10-C11
		/// </summary>
		[ArmModel("HC10DT_1-06VXHC10-C11", 0, 700, 0, 500, 162, 170, -90, 90, 0)]
HC10DT_1_06VXHC10_C11 = 68,

		/// <summary>
		/// HC10SDTP
		/// </summary>
		[ArmModel("HC10SDTP", 0, 550, 0, 350, 162, 170, -90, 0, 0)]
HC10SDTP = 69,

		/// <summary>
		/// HC20DT
		/// </summary>
		[ArmModel("HC20DT", 0, 820, 0, 880, 0, 200, -90, 0, 0)]
HC20DT = 70,

		/// <summary>
		/// HC20DTP
		/// </summary>
		[ArmModel("HC20DTP", 0, 820, 0, 880, 0, 200, -90, 0, 0)]
HC20DTP = 71,

		/// <summary>
		/// HC20SDT
		/// </summary>
		[ArmModel("HC20SDT", 0, 725, 0, 475, 185, 200, -90, 0, 0)]
HC20SDT = 72,

		/// <summary>
		/// HC20SDTP
		/// </summary>
		[ArmModel("HC20SDTP", 0, 725, 0, 475, 185, 200, -90, 0, 0)]
HC20SDTP = 73,

		/// <summary>
		/// HC30PL
		/// </summary>
		[ArmModel("HC30PL", 0, 820, 0, 880, 0, 200, -90, 0, 90)]
HC30PL = 74,

		/// <summary>
		/// HP0020D-A00
		/// </summary>
		[ArmModel("HP0020D-A00", 150, 760, 140, 795, 0, 105, -90, 0, 90)]
HP0020D_A00 = 75,

		/// <summary>
		/// HP0020D-A10
		/// </summary>
		[ArmModel("HP0020D-A10", 150, 760, 140, 995, 0, 105, -90, 0, 90)]
HP0020D_A10 = 76,

		/// <summary>
		/// HP0020D-B00
		/// </summary>
		[ArmModel("HP0020D-B00", 150, 760, 140, 795, 0, 105, -90, 0, 90)]
HP0020D_B00 = 77,

		/// <summary>
		/// HP0020D-B10
		/// </summary>
		[ArmModel("HP0020D-B10", 150, 760, 140, 995, 0, 105, -90, 0, 90)]
HP0020D_B10 = 78,

		/// <summary>
		/// HP0020F
		/// </summary>
		[ArmModel("HP0020F", 150, 760, 140, 795, 0, 105, -90, 0, 90)]
HP0020F = 79,

		/// <summary>
		/// HP0165D
		/// </summary>
		[ArmModel("HP0165D", 285, 1150, 250, 1225, 0, 225, -90, 0, 0)]
HP0165D = 80,

		/// <summary>
		/// HP020RD
		/// </summary>
		[ArmModel("HP020RD", 450, 760, 140, 795, 0, 105, 0, 0, 0)]
HP020RD = 81,

		/// <summary>
		/// MA02010
		/// </summary>
		[ArmModel("MA02010", 150, 760, 200, 1082, 0, 100, -90, 0, 0)]
MA02010 = 82,

		/// <summary>
		/// MA03120
		/// </summary>
		[ArmModel("MA03120", 145, 1150, 200, 1815, 0, 100, -90, 0, 0)]
MA03120 = 83,

		/// <summary>
		/// MA1440
		/// </summary>
		[ArmModel("MA1440", 155, 614, 200, 640, 0, 100, -90, 0, 0)]
MA1440 = 84,

		/// <summary>
		/// MC02000
		/// </summary>
		[ArmModel("MC02000", 330, 870, 250, 800, 0, 175, -90, 0, 0)]
MC02000 = 85,

		/// <summary>
		/// MCL0020
		/// </summary>
		[ArmModel("MCL0020", 150, 730, 140, 765, 0, 105, -90, 0, 90)]
MCL0020 = 86,

		/// <summary>
		/// MCL020F
		/// </summary>
		[ArmModel("MCL020F", 150, 730, 140, 765, 0, 105, -90, 0, 90)]
MCL020F = 87,

		/// <summary>
		/// MH00005
		/// </summary>
		[ArmModel("MH00005", 88, 310, 40, 305, 0, 86.5, -90, 0, 0)]
MH00005 = 88,

		/// <summary>
		/// MH00006-A00
		/// </summary>
		[ArmModel("MH00006-A00", 150, 614, 155, 640, 0, 95, -90, 0, 90)]
MH00006_A00 = 89,

		/// <summary>
		/// MH00006-A30
		/// </summary>
		[ArmModel("MH00006-A30", 150, 614, 155, 640, 0, 95, -90, 0, 90)]
MH00006_A30 = 90,

		/// <summary>
		/// MH00006-B00
		/// </summary>
		[ArmModel("MH00006-B00", 150, 614, 155, 640, 0, 95, -90, 0, 90)]
MH00006_B00 = 91,

		/// <summary>
		/// MH00006-B30
		/// </summary>
		[ArmModel("MH00006-B30", 150, 614, 155, 640, 0, 95, -90, 0, 90)]
MH00006_B30 = 92,

		/// <summary>
		/// MH00006-C00
		/// </summary>
		[ArmModel("MH00006-C00", 150, 614, 155, 640, 0, 100, -90, 0, 90)]
MH00006_C00 = 93,

		/// <summary>
		/// MH0000J
		/// </summary>
		[ArmModel("MH0000J", 0, 275, 0, 270, 0, 63, -90, 0, 0)]
MH0000J = 94,

		/// <summary>
		/// MH00024-A00
		/// </summary>
		[ArmModel("MH00024-A00", 150, 760, 200, 795, 0, 100, -90, 0, 0)]
MH00024_A00 = 95,

		/// <summary>
		/// MH00024-A10
		/// </summary>
		[ArmModel("MH00024-A10", 150, 760, 200, 1082, 0, 100, -90, 0, 0)]
MH00024_A10 = 96,

		/// <summary>
		/// MH00024-Z00-Proto
		/// </summary>
		[ArmModel("MH00024-Z00-Proto", 150, 760, 200, 795, 0, 100, -90, 0, 0)]
MH00024_Z00_Proto = 97,

		/// <summary>
		/// MH0003F
		/// </summary>
		[ArmModel("MH0003F", 0, 260, 30, 270, 0, 90, -90, 0, 0)]
MH0003F = 98,

		/// <summary>
		/// MH00050-A00
		/// </summary>
		[ArmModel("MH00050-A00", 145, 870, 210, 1025, 0, 175, -90, 0, 0)]
MH00050_A00 = 99,

		/// <summary>
		/// MH00050-A10
		/// </summary>
		[ArmModel("MH00050-A10", 145, 1150, 200, 1800, 0, 105, -90, 0, 90)]
MH00050_A10 = 100,

		/// <summary>
		/// MH00050-A20
		/// </summary>
		[ArmModel("MH00050-A20", 145, 1150, 210, 1225, 0, 175, -90, 0, 0)]
MH00050_A20 = 101,

		/// <summary>
		/// MH00050-B00
		/// </summary>
		[ArmModel("MH00050-B00", 145, 870, 210, 1025, 0, 175, -90, 0, 0)]
MH00050_B00 = 102,

		/// <summary>
		/// MH00050-B10
		/// </summary>
		[ArmModel("MH00050-B10", 145, 1150, 200, 1800, 0, 105, -90, 0, 90)]
MH00050_B10 = 103,

		/// <summary>
		/// MH00050-B20
		/// </summary>
		[ArmModel("MH00050-B20", 145, 1150, 210, 1225, 0, 175, -90, 0, 0)]
MH00050_B20 = 104,

		/// <summary>
		/// MH00050-J00
		/// </summary>
		[ArmModel("MH00050-J00", 145, 870, 210, 1025, 0, 175, -90, 0, 0)]
MH00050_J00 = 105,

		/// <summary>
		/// MH00050-J10
		/// </summary>
		[ArmModel("MH00050-J10", 145, 1150, 200, 1800, 0, 105, -90, 0, 90)]
MH00050_J10 = 106,

		/// <summary>
		/// MH00050-J20
		/// </summary>
		[ArmModel("MH00050-J20", 145, 1150, 210, 1225, 0, 175, -90, 0, 0)]
MH00050_J20 = 107,

		/// <summary>
		/// MH00050-Z00
		/// </summary>
		[ArmModel("MH00050-Z00", 145, 870, 210, 1025, 0, 175, -90, 0, 0)]
MH00050_Z00 = 108,

		/// <summary>
		/// MH0005F
		/// </summary>
		[ArmModel("MH0005F", 88, 310, 40, 305, 0, 80, -90, 0, 0)]
MH0005F = 109,

		/// <summary>
		/// MH0005L
		/// </summary>
		[ArmModel("MH0005L", 88, 400, 40, 405, 0, 86.5, -90, 0, 0)]
MH0005L = 110,

		/// <summary>
		/// MH0005S
		/// </summary>
		[ArmModel("MH0005S", 88, 310, 40, 305, 0, 80, -90, 0, 0)]
MH0005S = 111,

		/// <summary>
		/// MH0006F
		/// </summary>
		[ArmModel("MH0006F", 150, 614, 155, 640, 0, 95, -90, 0, 90)]
MH0006F = 112,

		/// <summary>
		/// MH0006S
		/// </summary>
		[ArmModel("MH0006S", 150, 305, 155, 520, 0, 95, -90, 0, 90)]
MH0006S = 113,

		/// <summary>
		/// MH00080
		/// </summary>
		[ArmModel("MH00080", 145, 870, 210, 1025, 0, 175, -90, 0, 0)]
MH00080 = 114,

		/// <summary>
		/// MH00165-A00
		/// </summary>
		[ArmModel("MH00165-A00", 285, 1150, 250, 1225, 0, 225, -90, 0, 0)]
MH00165_A00 = 115,

		/// <summary>
		/// MH00165-A10
		/// </summary>
		[ArmModel("MH00165-A10", 285, 1150, 250, 1590, 0, 225, -90, 0, 0)]
MH00165_A10 = 116,

		/// <summary>
		/// MH00165-B00
		/// </summary>
		[ArmModel("MH00165-B00", 285, 1150, 250, 1225, 0, 225, -90, 0, 0)]
MH00165_B00 = 117,

		/// <summary>
		/// MH00200
		/// </summary>
		[ArmModel("MH00200", 285, 1150, 250, 1225, 0, 250, -90, 0, 0)]
MH00200 = 118,

		/// <summary>
		/// MH00215
		/// </summary>
		[ArmModel("MH00215", 285, 1150, 250, 1490, 0, 250, -90, 0, 0)]
MH00215 = 119,

		/// <summary>
		/// MH00250
		/// </summary>
		[ArmModel("MH00250", 285, 1150, 250, 1285, 0, 250, -90, 0, 0)]
MH00250 = 120,

		/// <summary>
		/// MH00280
		/// </summary>
		[ArmModel("MH00280", 285, 1150, 250, 1015, 0, 250, -90, 0, 0)]
MH00280 = 121,

		/// <summary>
		/// MH003BM
		/// </summary>
		[ArmModel("MH003BM", 0, 260, 30, 270, 0, 90, -90, 0, 0)]
MH003BM = 122,

		/// <summary>
		/// MH00400
		/// </summary>
		[ArmModel("MH00400", 400, 1050, 250, 1605, 0, 300, -90, 0, 0)]
MH00400 = 123,

		/// <summary>
		/// MH005BM
		/// </summary>
		[ArmModel("MH005BM", 0, 350, 40, 350, 0, 115, -90, 0, 0)]
MH005BM = 124,

		/// <summary>
		/// MH005LF
		/// </summary>
		[ArmModel("MH005LF", 88, 400, 40, 405, 0, 80, -90, 0, 0)]
MH005LF = 125,

		/// <summary>
		/// MH005LS
		/// </summary>
		[ArmModel("MH005LS", 88, 400, 40, 405, 0, 80, -90, 0, 0)]
MH005LS = 126,

		/// <summary>
		/// MH00600
		/// </summary>
		[ArmModel("MH00600", 400, 1050, 250, 1605, 0, 300, -90, 0, 0)]
MH00600 = 127,

		/// <summary>
		/// MH006SF
		/// </summary>
		[ArmModel("MH006SF", 150, 305, 155, 520, 0, 95, -90, 0, 90)]
MH006SF = 128,

		/// <summary>
		/// MH00900
		/// </summary>
		[ArmModel("MH00900", 500, 1700, 350, 2480, 0, 440, -90, 0, 0)]
MH00900 = 129,

		/// <summary>
		/// MH110
		/// </summary>
		[ArmModel("MH110", 320, 870, 235, 1020, 0, 200, -90, 0, 0)]
MH110 = 130,

		/// <summary>
		/// MH12
		/// </summary>
		[ArmModel("MH12", 155, 614, 200, 640, 0, 100, -90, 0, 0)]
MH12 = 131,

		/// <summary>
		/// MH180-A00
		/// </summary>
		[ArmModel("MH180-A00", 325, 1150, 300, 1225, 0, 225, -90, 0, 0)]
MH180_A00 = 132,

		/// <summary>
		/// MH180-A10
		/// </summary>
		[ArmModel("MH180-A10", 325, 1150, 300, 1590, 0, 225, -90, 0, 0)]
MH180_A10 = 133,

		/// <summary>
		/// MH180-C00
		/// </summary>
		[ArmModel("MH180-C00", 325, 1150, 300, 1225, 0, 225, -90, 0, 0)]
MH180_C00 = 134,

		/// <summary>
		/// MH225
		/// </summary>
		[ArmModel("MH225", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
MH225 = 135,

		/// <summary>
		/// MHP045L
		/// </summary>
		[ArmModel("MHP045L", 0, 1400, 0, 1450, 0, 175, -90, 0, 0)]
MHP045L = 136,

		/// <summary>
		/// MPL0080
		/// </summary>
		[ArmModel("MPL0080", 145, 870, 210, 1025, 0, 175, -90, 0, 90)]
MPL0080 = 137,

		/// <summary>
		/// MPX1150
		/// </summary>
		[ArmModel("MPX1150", 0, 320, 75, 400, 0, 86.5, -90, 0, 0)]
MPX1150 = 138,

		/// <summary>
		/// MPX1400
		/// </summary>
		[ArmModel("MPX1400", 200, 520, 130, 520, 0, 86.5, -90, 0, 0)]
MPX1400 = 139,

		/// <summary>
		/// MPX1950
		/// </summary>
		[ArmModel("MPX1950", 0, 725, 0, 725, 0, 100, -90, 0, 0)]
MPX1950 = 140,

		/// <summary>
		/// MS00080
		/// </summary>
		[ArmModel("MS00080", 145, 870, 210, 1025, 0, 175, -90, 0, 0)]
MS00080 = 141,

		/// <summary>
		/// MS00120
		/// </summary>
		[ArmModel("MS00120", 100, 750, 300, 900, 0, 225, -90, 0, 0)]
MS00120 = 142,

		/// <summary>
		/// MS0080W
		/// </summary>
		[ArmModel("MS0080W", 320, 870, 210, 1025, 0, 175, -90, 0, 0)]
MS0080W = 143,

		/// <summary>
		/// MS100
		/// </summary>
		[ArmModel("MS100", 320, 870, 235, 1020, 0, 200, -90, 0, 0)]
MS100 = 144,

		/// <summary>
		/// MS165
		/// </summary>
		[ArmModel("MS165", 325, 1150, 300, 1225, 0, 225, -90, 0, 0)]
MS165 = 145,

		/// <summary>
		/// MS210
		/// </summary>
		[ArmModel("MS210", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
MS210 = 146,

		/// <summary>
		/// MotoMINI
		/// </summary>
		[ArmModel("MotoMINI", 20, 165, 0, 165, 0, 40, -90, 0, 90)]
MotoMINI = 147,

		/// <summary>
		/// PH130F
		/// </summary>
		[ArmModel("PH130F", 285, 1150, 250, 1225, 0, 225, -90, 0, 0)]
PH130F = 148,

		/// <summary>
		/// PH130RF
		/// </summary>
		[ArmModel("PH130RF", 720, 1050, 250, 1700, 0, 230, 0, 0, 0)]
PH130RF = 149,

		/// <summary>
		/// PH13RLD
		/// </summary>
		[ArmModel("PH13RLD", 720, 1050, 250, 1700, 0, 230, 0, 0, 0)]
PH13RLD = 150,

		/// <summary>
		/// PH200R
		/// </summary>
		[ArmModel("PH200R", 550, 1100, 250, 2135, 0, 255, 0, 0, 0)]
PH200R = 151,

		/// <summary>
		/// PH200RF
		/// </summary>
		[ArmModel("PH200RF", 550, 1100, 250, 2135, 0, 255, 0, 0, 0)]
PH200RF = 152,

		/// <summary>
		/// SP100
		/// </summary>
		[ArmModel("SP100", 320, 870, 235, 1020, 0, 200, -90, 0, 0)]
SP100 = 153,

		/// <summary>
		/// SP110H
		/// </summary>
		[ArmModel("SP110H", 320, 870, 300, 800, 0, 250, -90, 0, 0)]
SP110H = 154,

		/// <summary>
		/// SP130
		/// </summary>
		[ArmModel("SP130", 320, 870, 235, 1020, 0, 200, -90, 0, 0)]
SP130 = 155,

		/// <summary>
		/// SP150R
		/// </summary>
		[ArmModel("SP150R", 740, 1150, 250, 1225, 0, 225, 0, 0, 0)]
SP150R = 156,

		/// <summary>
		/// SP165
		/// </summary>
		[ArmModel("SP165", 325, 1150, 300, 1225, 0, 225, -90, 0, 0)]
SP165 = 157,

		/// <summary>
		/// SP165-105
		/// </summary>
		[ArmModel("SP165-105", 325, 1150, 300, 1590, 0, 225, -90, 0, 0)]
SP165_105 = 158,

		/// <summary>
		/// SP180H
		/// </summary>
		[ArmModel("SP180H", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
SP180H = 159,

		/// <summary>
		/// SP180H-110
		/// </summary>
		[ArmModel("SP180H-110", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
SP180H_110 = 160,

		/// <summary>
		/// SP185R
		/// </summary>
		[ArmModel("SP185R", 740, 1150, 250, 1225, 0, 250, 0, 0, 0)]
SP185R = 161,

		/// <summary>
		/// SP210
		/// </summary>
		[ArmModel("SP210", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
SP210 = 162,

		/// <summary>
		/// SP225H
		/// </summary>
		[ArmModel("SP225H", 325, 1150, 300, 1225, 0, 250, -90, 0, 0)]
SP225H = 163,

		/// <summary>
		/// SP225H-135
		/// </summary>
		[ArmModel("SP225H-135", 325, 1150, 300, 1480, 0, 250, -90, 0, 0)]
SP225H_135 = 164,

		/// <summary>
		/// SP235
		/// </summary>
		[ArmModel("SP235", 285, 1150, 250, 1285, 0, 250, -90, 0, 0)]
SP235 = 165,

		/// <summary>
		/// SP80
		/// </summary>
		[ArmModel("SP80", 320, 870, 210, 1025, 0, 175, -90, 0, 0)]
SP80 = 166,

		/// <summary>
		/// UP0350D
		/// </summary>
		[ArmModel("UP0350D", 280, 1050, 250, 1320, 0, 270, -120, 0, 0)]
UP0350D = 167,

		/// <summary>
		/// UP400RD
		/// </summary>
		[ArmModel("UP400RD", 280, 1100, 250, 2135, 0, 255, 0, 0, 0)]
UP400RD = 168,
	}
}
