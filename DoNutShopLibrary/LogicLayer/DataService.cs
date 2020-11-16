﻿
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;



namespace LogicLayer
{

    public class DataService
    {

        private IDataRepository repository;

        public DataService(IDataRepository repository)
        {
            this.repository = repository;
        }



        public Donut GetDonutByType(DonutTypeEnum type)
        {
            return repository.GetDonutByType(type);
        }
        public Donut GetDonutById(int id)
        {
            return repository.GetDonut(id);
        }

        public void AddDonut(Donut donut)
        {
         repository.AddDonut(donut);
        }

        public void DeleteDonut(int id)
        {
            repository.DeleteDonut(id);
        }

        public void AddCustomer(Customer customer)
        {
            repository.AddCustomer(customer);
        }

        public void UpdateCustomerInfo(Customer C)
        {
            repository.UpdateCustomerInfo(C);
        }


        public void DeleteCustomer(String id)
        {
            repository.DeleteCustomer(id);
        }
        public IEnumerable<Event> GetEventsBetweenTwoDates(DateTime startDate, DateTime endDate)
        {
            List<Event> allEvents = new List<Event>();

            foreach (Event myEvent in repository.GetAllEvents())
            {
                if (myEvent.dateTime >= startDate && myEvent.dateTime <= endDate)
                {
                    allEvents.Add(myEvent);
                }
            }
            return allEvents;
        }

        public IEnumerable<Event> GetEventsForTheClient(string id)
        {
            Customer client = repository.GetCustomer(id);
            List<Event> allEvents = new List<Event>();

            foreach (Event myEvent in repository.GetAllEvents())
            {
                if (myEvent..Equals(reader))
                {
                    events.Add(ev);
                }
            }
            return events;
        }

        /*
         * Tu powinny byc funkcje istotne dla biznesu  GetDonutByType, GetDonutByID
         * Funkcje takie jak update i delete powinny zwracac booleany ze operacja sie powiodla
         *  GetEventsForTheClient, > GetEventsBetween(DateTime start, DateTime end)
         *  GetEventsForTheDonut
         *  BuyingDonut   --> W srodu musi byc tworzenie eventu BuyingEvent, dodawanie go do listy eventow w datacontext, zmienianie stanu sklepu
         *  To samo dla restocking
         *  GetBoughtDonutsAndAmount()
         * 
         */

    }
}
