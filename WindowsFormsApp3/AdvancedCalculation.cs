using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    static class AdvancedCalculation
    {
        // Fields
        // From Step Ones
        private static string _state;
        private static string _city;
        private static double _coolingPercent;
        private static double _relativeRH;
        private static double _houseArea;
        private static double _ceilingHeight;
        private static int _numPeople;
        private static int _numAppliances;
        // From Step Two
        private static double _NSwinArea;
        private static string _NSwinConstType;
        private static double _NSwindowTotal;
        private static double _NSdoorArea;
        private static string _NSdoorConstType;
        private static double _NSdoorTotal;
        private static double _NSwallArea;
        private static string _NSwallFrameType;
        private static string _NSwallInsulType;
        private static string _NSwallSidingType;
        private static double _NSwallTotal;
        private static double _NorthSouthTotal;
        private static double _NorthSouthTotalArea;
        // From Step Three
        private static double _WwinArea;
        private static string _WwinConstType;
        private static double _WwindowTotal;
        private static double _WdoorArea;
        private static string _WdoorConstType;
        private static double _WdoorTotal;
        private static double _WwallArea;
        private static string _WwallFrameType;
        private static string _WwallInsulType;
        private static string _WwallSidingType;
        private static double _WwallTotal;
        private static double _WestTotal;
        private static double _WestTotalArea;
        // From Step Four
        private static double _EwinArea;
        private static string _EwinConstType;
        private static double _EwindowTotal;
        private static double _EdoorArea;
        private static string _EdoorConstType;
        private static double _EdoorTotal;
        private static double _EwallArea;
        private static string _EwallFrameType;
        private static string _EwallInsulType;
        private static string _EwallSidingType;
        private static double _EwallTotal;
        private static double _EastTotal;
        private static double _EastTotalArea;
        // From Step Five
        private static string _roofColoring;
        private static string _roofConst;
        private static double _roofTotal;
        private static string _floorType;
        private static string _floorConst;
        private static double _floorTotal;
        private static double _floorRoofTotal;
        private static string _user;
        // Calculation Variables
        // Procedure A
        private static double _airChangePerHour;
        private static double _totalSpaceVolume;
        private static double _totalInfil;
        // Procedure B
        private static double _designDiff;
        private static double _sensibleGain;
        private static double _totalWinDoorArea;
        private static double _transferMultiplier;
        // Procedure C
        private static double _latentLoad;
        // Procedure D
        private static double _mechVent;
        private static double _sensibleVentLoad;
        private static double _totalStructLoad;
        private static double _totalSensibleLoad;
        private static double _extraLatentLoad;
        private static double _latentVentLoad;
        private static double _totalLatentLoad;
        // Final procedure
        private static double _totalGain;
        private static double _sizeNeeded;
        // 
        private static bool dbWriteComplete;

        // Properties
        // From Step One
        public static string State { get { return _state; } set { _state = value; } }
        public static string City { get { return _city; } set { _city = value; } }
        public static double CoolingPercent { get { return _coolingPercent; } set { _coolingPercent = value; } }
        public static double RelativeRH { get { return _relativeRH; } set { _relativeRH = value; } }
        public static double HouseArea { get { return _houseArea; } set { _houseArea = value; } }
        public static double CeilingHeight { get { return _ceilingHeight; } set { _ceilingHeight = value; } }
        public static int NumPeople { get { return _numPeople; } set { _numPeople = value; } }
        public static int NumAppliances { get { return _numAppliances; } set { _numAppliances = value; } }
        // From Step Two
        public static double NSWinArea { get { return _NSwinArea; } set { _NSwinArea = value; } }
        public static string NSwinConstType { get { return _NSwinConstType; } set { _NSwinConstType = value; } }
        public static double NSWindowTotal { get { return _NSwindowTotal; } set { _NSwindowTotal = value; } }
        public static double NSDoorArea { get { return _NSdoorArea; } set { _NSdoorArea = value; } }
        public static string NSDoorConstType { get { return _NSdoorConstType; } set { _NSdoorConstType = value; } }
        public static double NSDoorTotal { get { return _NSdoorTotal; } set { _NSdoorTotal = value; } }
        public static double NSWallArea { get { return _NSwallArea; } set { _NSwallArea = value; } }
        public static string NSWallFrameType { get { return _NSwallFrameType; } set { _NSwallFrameType = value; } }
        public static string NSWallInsulType { get { return _NSwallInsulType; } set { _NSwallInsulType = value; } }
        public static string NSWallSidingType { get { return _NSwallSidingType; } set { _NSwallSidingType = value; } }
        public static double NSWallTotal { get { return _NSwallTotal; } set { _NSwallTotal = value; } }
        public static double NorthSouthTotal { get { return _NorthSouthTotal; } set { _NorthSouthTotal = value; } }
        public static double NorthSouthTotalArea { get { return _NorthSouthTotalArea; } set { _NorthSouthTotalArea = value; } }
        // From Step Three
        public static double WWinArea { get { return _WwinArea; } set { _WwinArea = value; } }
        public static string WWinConstType { get { return _WwinConstType; } set { _WwinConstType = value; } }
        public static double WWindowTotal { get { return _WwindowTotal; } set { _WwindowTotal = value; } }
        public static double WDoorArea { get { return _WdoorArea; } set { _WdoorArea = value; } }
        public static string WDoorConstType { get { return _WdoorConstType; } set { _WdoorConstType = value; } }
        public static double WDoorTotal { get { return _WdoorTotal; } set { _WdoorTotal = value; } }
        public static double WWallArea { get { return _WwallArea; } set { _WwallArea = value; } }
        public static string WWallFrameType { get { return _WwallFrameType; } set { _WwallFrameType = value; } }
        public static string WWallInsulType { get { return _WwallInsulType; } set { _WwallInsulType = value; } }
        public static string WWallSidingType { get { return _WwallSidingType; } set { _WwallSidingType = value; } }
        public static double WWallTotal { get { return _WwallTotal; } set { _WwallTotal = value; } }
        public static double WestTotal { get { return _WestTotal; } set { _WestTotal = value; } }
        public static double WestTotalArea { get { return _WestTotalArea; } set { _WestTotalArea = value; } }
        // From Step Four
        public static double EWinArea { get { return _EwinArea; } set { _EwinArea = value; } }
        public static string EWinConstType { get { return _EwinConstType; } set { _EwinConstType = value; } }
        public static double EWindowTotal { get { return _EwindowTotal; } set { _EwindowTotal = value; } }
        public static double EDoorArea { get { return _EdoorArea; } set { _EdoorArea = value; } }
        public static string EDoorConstType { get { return _EdoorConstType; } set { _EdoorConstType = value; } }
        public static double EDoorTotal { get { return _EdoorTotal; } set { _EdoorTotal = value; } }
        public static double EWallArea { get { return _EwallArea; } set { _EwallArea = value; } }
        public static string EWallFrameType { get { return _EwallFrameType; } set { _EwallFrameType = value; } }
        public static string EWallInsulType { get { return _EwallInsulType; } set { _EwallInsulType = value; } }
        public static string EWallSidingType { get { return _EwallSidingType; } set { _EwallSidingType = value; } }
        public static double EWallTotal { get { return _EwallTotal; } set { _EwallTotal = value; } }
        public static double EastTotal { get { return _EastTotal; } set { _EastTotal = value; } }
        public static double EastTotalArea { get { return _EastTotalArea; } set { _EastTotalArea = value; } }
        // From Step Five
        public static string RoofColoring { get { return _roofColoring; } set { _roofColoring = value; } }
        public static string RoofConst { get { return _roofConst; } set { _roofConst = value; } }
        public static double RoofTotal { get { return _roofTotal; } set { _roofTotal = value; } }
        public static string FloorType { get { return _floorType; } set { _floorType = value; } }
        public static string FloorConst { get { return _floorConst; } set { _floorConst = value; } }
        public static double FloorTotal { get { return _floorTotal; } set { _floorTotal = value; } }
        public static double FloorRoofTotal { get { return _floorRoofTotal; } set { _floorRoofTotal = value; } }
        public static string User { get { return _user; } set { _user = value; } }
        public static double TotalGain { get { return _totalGain; } set { _totalGain = value; } }
        public static double SizeNeeded { get { return _sizeNeeded; } set { _sizeNeeded = value; } }

        // Method To Perform Calculations
        public static double PerformCalculation()
        {
            ProcedureA();
            ProcedureB();
            ProcedureC();
            ProcedureD();
            ProcedureFinal();
            return _sizeNeeded;
        }

        // Procedure A From ACCA Manual J
        public static void ProcedureA()
        {
            _airChangePerHour = 0.3;
            _totalSpaceVolume = _houseArea * _ceilingHeight;
            _totalInfil = _airChangePerHour * _totalSpaceVolume * 0.0167;
        }

        // Procedure B From ACCA Manual J
        public static void ProcedureB()
        {
            _designDiff = _coolingPercent - 75;
            _sensibleGain = 1.1 * _designDiff * _totalInfil;
            _totalWinDoorArea = _NorthSouthTotalArea + _WestTotalArea + _EastTotalArea;
            _transferMultiplier = _sensibleGain / _totalWinDoorArea;
        }

        // Procedure C From ACCA Manual J
        public static void ProcedureC()
        {
            _latentLoad = 0.68 * _relativeRH * _totalInfil;
        }

        // Procedure D From ACCA Manual J
        public static void ProcedureD()
        {
            _mechVent = 150;
            _sensibleVentLoad = 1.1 * _mechVent * _designDiff;
            _totalStructLoad = _NorthSouthTotal + _WestTotal + _EastTotal;
            _totalStructLoad += (_transferMultiplier * _WwinArea) + (_transferMultiplier * _NSwinArea) + (_transferMultiplier * _EwinArea);
            _totalSensibleLoad = _sensibleVentLoad + _totalStructLoad;
            _extraLatentLoad = ((_numPeople * 300) + (_numAppliances * 300));
            _latentVentLoad = 0.68 * _mechVent * _relativeRH;
            _totalLatentLoad = _latentLoad + _extraLatentLoad + _latentVentLoad;
        }

        // Final Procedure From ACCA Manual J
        public static void ProcedureFinal()
        {
            _totalGain = Math.Round(_totalLatentLoad + _totalSensibleLoad, 0);
            _sizeNeeded = Math.Round((_totalGain / 12000), 0) + .5;
        }

        // Method To Save Data to Database
        public static bool SaveToDatabase()
        {
            // Initially set completion tracker to true
            dbWriteComplete = true;

            // Use SQL connection to connect to database
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                // Try to complete save, else catch error and change completion tracker to false
                try
                {
                    // Open connection
                    connection.Open();

                    // Get DateTime object
                    DateTime date = DateTime.Now;

                    // Create SQL command
                    SqlCommand command = new SqlCommand("dbo.InsertAdvCalc", connection);

                    // Declare command as SQL Stored Procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameters to SQL command
                    command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
                    command.Parameters.Add("@state", SqlDbType.NVarChar).Value = _state;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = _city;
                    command.Parameters.Add("@squareFeet", SqlDbType.Int).Value = _houseArea;
                    command.Parameters.Add("@ceilingHeight", SqlDbType.Int).Value = _ceilingHeight;
                    command.Parameters.Add("@numOccupants", SqlDbType.Int).Value = _numPeople;
                    command.Parameters.Add("@numAppliances", SqlDbType.Int).Value = _numAppliances;
                    command.Parameters.Add("@ceilingColor", SqlDbType.NVarChar).Value = _roofColoring;
                    command.Parameters.Add("@ceilingConstType", SqlDbType.NVarChar).Value = _roofConst;
                    command.Parameters.Add("@floorType", SqlDbType.NVarChar).Value = _floorType;
                    command.Parameters.Add("@floorConstType", SqlDbType.NVarChar).Value = _floorConst;
                    command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = _user;
                    command.Parameters.Add("@EwinSQFT", SqlDbType.Int).Value = _EwinArea;
                    command.Parameters.Add("@NSwinSQFT", SqlDbType.Int).Value = _NSwinArea;
                    command.Parameters.Add("@WwinSQFT", SqlDbType.Int).Value = _WwinArea;
                    command.Parameters.Add("@EwinConst", SqlDbType.NVarChar).Value = _EwinConstType;
                    command.Parameters.Add("@NSwinConst", SqlDbType.NVarChar).Value = _NSwinConstType;
                    command.Parameters.Add("@WwinConst", SqlDbType.NVarChar).Value = _WwinConstType;
                    command.Parameters.Add("@EdoorSQFT", SqlDbType.Int).Value = _EdoorArea;
                    command.Parameters.Add("@NSdoorSQFT", SqlDbType.Int).Value = _NSdoorArea;
                    command.Parameters.Add("@WdoorSQFT", SqlDbType.Int).Value = _WdoorArea;
                    command.Parameters.Add("@EdoorConst", SqlDbType.NVarChar).Value = _EdoorConstType;
                    command.Parameters.Add("@NSdoorConst", SqlDbType.NVarChar).Value = _NSdoorConstType;
                    command.Parameters.Add("@WdoorConst", SqlDbType.NVarChar).Value = _WdoorConstType;
                    command.Parameters.Add("@EwallSQFT", SqlDbType.Int).Value = _EwallArea;
                    command.Parameters.Add("@NSwallSQFT", SqlDbType.Int).Value = _NSwallArea;
                    command.Parameters.Add("@WwallSQFT", SqlDbType.Int).Value = _WwallArea;
                    command.Parameters.Add("@EwallFrameType", SqlDbType.NVarChar).Value = _EwallFrameType;
                    command.Parameters.Add("@NSwallFrameType", SqlDbType.NVarChar).Value = _NSwallFrameType;
                    command.Parameters.Add("@WwallFrameType", SqlDbType.NVarChar).Value = _WwallFrameType;
                    command.Parameters.Add("@EwallInsType", SqlDbType.NVarChar).Value = _EwallInsulType;
                    command.Parameters.Add("@NSwallInsType", SqlDbType.NVarChar).Value = _NSwallInsulType;
                    command.Parameters.Add("@WwallInsType", SqlDbType.NVarChar).Value = _WwallInsulType;
                    command.Parameters.Add("@EwallSidingType", SqlDbType.NVarChar).Value = _EwallSidingType;
                    command.Parameters.Add("@NSwallSidingType", SqlDbType.NVarChar).Value = _NSwallSidingType;
                    command.Parameters.Add("@WwallSidingType", SqlDbType.NVarChar).Value = _WwallSidingType;
                    command.Parameters.Add("@btuNeeded", SqlDbType.Int).Value = _totalGain;
                    command.Parameters.Add("@btuRecommended", SqlDbType.Int).Value = _sizeNeeded;

                    // Execute command
                    command.ExecuteNonQuery();

                    //Close connection
                    connection.Close();
                }
                catch (Exception)
                {
                    dbWriteComplete = false;
                }
            }

            // Return whether database write was completed or not
            if (dbWriteComplete)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
