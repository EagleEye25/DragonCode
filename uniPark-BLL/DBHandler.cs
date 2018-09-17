﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLib.Models;
using TypeLib.ViewModels;
using TypeLib.Interfaces;
using uniPark_DAL;
using System.Data;


namespace uniPark_BLL
{
    public class DBHandler : IDBHandler
    {
        private IDBAccess db;

        public DBHandler()
        {
            db = new DBAccess();

        }
        public DataTable BLL_GetLevels()
        {
            return db.GetLevels();
        }
        public DataTable BLL_GetTypes()
        {
            return db.GetTypes();
        }

        public DataTable BLL_GetPersonel()
        {
            return db.GetPersonel();
        }

        public bool BLL_AddPersonel(string PersonelID, string PersonelTagNumber, string PersonelPassword, string PersonelSurname, string PersonelName, string PersonelPhoneNumber, string PersonelEmail, int PersonelLevelID, int PersonelTypeID)
        {
            return db.AddPersonel(PersonelID, PersonelTagNumber, PersonelPassword, PersonelSurname, PersonelName, PersonelPhoneNumber, PersonelEmail, PersonelLevelID, PersonelTypeID);
        }

        public DataTable BLL_GetParkingAreas()
        {
          return  db.GetParkingAreas();
        }
        public DataTable BLL_GetParkingSpaces(string parkinngAreaID)
        {
            return db.GetParkingSpaces(parkinngAreaID);
        }
        public DataTable BLL_SearchParkingSpaceDetails(string parkingAreaID, string parkingSpaceID)
        {
            return db.SearchParkingSpaceDetails(parkingAreaID,parkingSpaceID);
        }
       public uspLogin BLL_Login(string userid)
        {
            return db.Login(userid);
        }

        public uspGetAllInfo BLL_getallinfo(string userid)
        {
            return db.getallinfo(userid);
        }

        public bool BLL_EditPersonel(string name, string id, string surname, string email, int level, int type)
        {
            return db.EditPersonel(name, id, surname, email, level, type);
        }
        public List<uspCheckGuest> BLL_checkguest(string guest)
        {
            return db.checkguest(guest);
        }
        public bool BLL_addguest(string PersonelID, string PersonelPassword, string PersonelSurname, string PersonelName, string PersonelPhoneNumber, string PersonelEmail, int PersonelLevelID)
        {
            return db.addguest(PersonelID, PersonelPassword, PersonelSurname, PersonelName, PersonelPhoneNumber, PersonelEmail, PersonelLevelID);
        }
	   	public DataTable BLL_GetAllInfo(string id)
        {
            return db.GetAllInfo(id);
        }

        public bool BLL_deleteuser(string id)
        {
            return db.deleteuser(id);
        }


        public bool BLL_AddParkingArea(ParkingArea PA)
        {
            return db.AddParkingArea(PA);
        }

        public bool BLL_AddPakingSpace(string ParkingType, string ParkingAreaID)
        {
           return db.AddPakingSpace(ParkingType, ParkingAreaID);
        }
        public bool BLL_UpdateParkingArea(ParkingArea PA)
        {
            return db.UpdateParkingArea(PA);
        }

        public bool BLL_UpdateParkingSpace(string parkingAreaID, string parkingSpaceType, int spaceID, bool available, bool status)
        {
           return db.UpdateParkingSpace(parkingAreaID,parkingSpaceType,spaceID,available,status);
        }

        public List<ParkingArea> BLL_GetAllParkingAreaDetails()
        {
            return db.GetAllParkingAreaDetails();
        }
        public DataTable BLL_SearchPersonnel(string name)
        {
            return db.SearchPersonnel(name);
        }

        public DataTable BLL_getInfringements(string PersonnelID)
        {
            return db.getInfringements(PersonnelID);
        }

        public DataTable BLL_GetParkingRequests()
        {
            return db.GetParkingRequests();
        }
        public uspGetReportDetailsBE BLL_getreportdetails(int reportid)
        {
            return db.getreportdetails(reportid);
        }
        public DataTable BLL_GetInfringementsI(string id, DateTime start, DateTime end)
        {
            return db.GetInfringementsI(id,start,end);
        }
        public DataTable BLL_GetInfringementsS(DateTime start, DateTime end)
        {
            return db.GetInfringementsS(start, end);
        }
        public DataTable BLL_GetEntranceLogS(DateTime start, DateTime end)
        {
            return db.GetEntranceLogS(start,end);
        }
        public DataTable BLL_GetEntranceLogI(string id, DateTime start, DateTime end)
        {
            return db.GetEntranceLogI(id, start, end);
        }
        public DataTable BLL_GetParkingReportS(DateTime start, DateTime end)
        {

            return db.GetParkingReportS(start,end);
        }
        public DataTable BLL_GetParkingRequestReport(string id, DateTime start, DateTime end)
        {

            return db.GetParkingRequestReport(id,start,end);
        }
        public DataTable BLL_GetParkingReportI(string id, DateTime start, DateTime end)
        {

            return db.GetParkingReportI(id, start, end);
        }

    }
}
