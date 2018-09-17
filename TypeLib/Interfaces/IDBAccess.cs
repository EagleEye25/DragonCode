﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLib.Models;
using TypeLib.ViewModels;
using System.Data;

namespace TypeLib.Interfaces
{
    public interface IDBAccess
    {
        DataTable GetParkingAreas();
        DataTable GetParkingSpaces(string parkinngAreaID);
        DataTable SearchParkingSpaceDetails(string parkingAreaID, string parkingSpaceID);
        uspLogin Login(string userID);
        DataTable GetPersonel();
        bool AddPersonel(string PersonelID, string PersonelTagNumber, string PersonelPassword, string PersonelSurname, string PersonelName, string PersonelPhoneNumber, string PersonelEmail, int PersonelLevelID, int PersonelTypeID);
        DataTable GetLevels();
        DataTable GetTypes();
        uspGetAllInfo getallinfo(string userid);
        bool EditPersonel(string name,string id,string surname,string email,int level,int type);
        List<uspCheckGuest> checkguest(string guest);
        bool addguest(string PersonelID, string PersonelPassword, string PersonelSurname, string PersonelName, string PersonelPhoneNumber, string PersonelEmail, int PersonelLevelID);
		DataTable GetAllInfo(string id);
        bool deleteuser(string userid);

        bool AddParkingArea(ParkingArea PA);
        bool AddPakingSpace(string ParkingType, string ParkingAreaID);

        bool UpdateParkingArea(ParkingArea PA);
        bool UpdateParkingSpace(string parkingAreaID, string parkingSpaceType, int spaceID, bool available, bool status);

        List<ParkingArea> GetAllParkingAreaDetails();
        DataTable SearchPersonnel(string name);
        DataTable getInfringements(string PersonnelID);
        DataTable GetParkingRequests();
        uspGetReportDetailsBE getreportdetails(int reportid);
        DataTable GetInfringementsI(string id, DateTime start, DateTime end);
        DataTable GetInfringementsS(DateTime start, DateTime end);

        DataTable GetEntranceLogS(DateTime start, DateTime end);
        DataTable GetEntranceLogI(string id, DateTime start, DateTime end);

        DataTable GetParkingReportS(DateTime start, DateTime end);
        DataTable GetParkingRequestReport(string id, DateTime start, DateTime end);
        DataTable GetParkingReportI(string id, DateTime start, DateTime end);



    }
}
