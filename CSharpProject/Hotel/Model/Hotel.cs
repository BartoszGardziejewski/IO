﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Hotel
    {
        Employees employees;
        Clients clients;
        Documentation documentation;
        Reservations reservations;
        Rooms rooms;

        public Hotel()
        {
            employees = new Employees();
            clients = new Clients();
            documentation = new Documentation();
            reservations = new Reservations();
            rooms = new Rooms();
        }

        public void MakeReservation(String clientID, DateTime startDate, DateTime endDate, int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void RegisterClient(String firstName, String lastName, String clientID, String email = "")
        {
            throw new NotImplementedException();
        }

        public void FindFreeRoom(DateTime startDate, DateTime endDate, int capacity)
        {
            throw new NotImplementedException();
        }

        public void CheckInClient(String reservationID)
        {
            throw new NotImplementedException();
        }

        public void CancelReservation(String clientID)
        {
            throw new NotImplementedException();
        }

        public void CheckOutClient(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void FindClient(String clientID)
        {
            throw new NotImplementedException();
        }

        public void CallManager(String place)
        {
            throw new NotImplementedException();
        }

        public void ReportNeedForCleaning(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void ReportNeedForRepair(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void ReportNeedForSecurityIntervention(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void TakePayment(String clientID, double paymentValue, bool card)
        {
            throw new NotImplementedException();
        }

        public void ReportExecutionOfRepair(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void ReportExecutionOfCleaning(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void ViewReports()
        {
            throw new NotImplementedException();
        }

        public void PrintAndArchive(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void AddDailyReport()
        {
            throw new NotImplementedException();
        }

        public void PayOutSalary(String employeeID)
        {
            throw new NotImplementedException();
        }

        public void GiveBonus(String employeeID)
        {
            throw new NotImplementedException();
        }

        public void CalculateSalary(String employeeID)
        {
            throw new NotImplementedException();
        }

        public void FireEmployee(String employeeID)
        {
            throw new NotImplementedException();
        }

        public void CallEmployee(String employeeID)
        {
            throw new NotImplementedException();
        }

        public void WarnEmployee(String employeeID)
        {
            throw new NotImplementedException();
        }
    }
}
