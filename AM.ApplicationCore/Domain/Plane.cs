using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing, Airbus
    };
    public class Plane


    {



        [Range(0,int.MaxValue)] //intervalle
        public int Capacity { get; set; }

        public DateTime ManifactureDate { get; set; }

        public int PlaneId { get; set; }

        public PlaneType PlaneType { get; set; }

         public ICollection<Flight>? Flights { get; set; }



        /* public Plane(PlaneType pt, int capacity, DateTime date)
         {
             PlaneType = pt;
             Capacity = capacity;
             ManifactureDate = date;
         }
         public Plane()
         {

         } */







        public override string ToString()


        {
            return "PlaneType :" + PlaneType+ "Capacity : "+ Capacity+ "ManifactureDate : "+ ManifactureDate;

        }
    }
}

