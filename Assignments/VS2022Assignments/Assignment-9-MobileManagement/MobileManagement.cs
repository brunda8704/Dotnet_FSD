using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_MobileManagement
{
    internal class MobileManagement
    {
        public static List<Mobile> mobileList = new List<Mobile>();
        public bool AddMobile(string name, string description, string manufacturedBy, double price)
        {
            var checkExists = mobileList.Find(mobileList => mobileList.Name.ToLower() == name.ToLower());
            if (checkExists == null)
            {
                int id = mobileList.Count == 0 ? 3000 : mobileList.Max(mobileList => mobileList.Id) + 1;
                mobileList.Add(new Mobile
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    ManufacturedBy = manufacturedBy,
                    Price = price

                });
                return true;
            }

            return false;


        }

        public List<Mobile> ViewAllMobiles()
        {
            return mobileList;
        }

        public List<Mobile> SearchByMaxPrice()
        {
            var maxPrice= mobileList.Max(maxValue=>maxValue.Price);
            var selectedMobiles = mobileList.FindAll(selectedPrice => selectedPrice.Price < maxPrice);
            return selectedMobiles;
        }

        public List<Mobile> SearchByManufacturer(string manufacturer)
        {
            var manufacturerCheck = mobileList.FindAll(mobileList => mobileList.ManufacturedBy.ToLower() == manufacturer.ToLower());
            return manufacturerCheck;
        }

        public List<Mobile> ViewByPriceRange()
        {
            var minValue = mobileList.Min(min => min.Price);
            var maxValue = mobileList.Max(max => max.Price);
            var filterList = mobileList.FindAll(selectedMobiles => selectedMobiles.Price > minValue && selectedMobiles.Price < maxValue);
            return filterList;

        }

        public void RemoveByPriceRange()
        {
            var minValue = mobileList.Min(min => min.Price);
            var maxValue = mobileList.Max(max => max.Price);
            var removeFilter = mobileList.RemoveAll(selectedMobiles=> selectedMobiles.Price > minValue && selectedMobiles.Price < maxValue);
            
        }



    }
}
