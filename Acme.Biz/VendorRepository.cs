using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        /// <summary>
        /// Retrieves from Vendor Array
        /// </summary>
        /// <returns></returns>
        public Vendor[] RetrieveArray()
        {
            var vendors = new Vendor[2];

            //if (vendors == null)
            //    {
            //var vendors = new List<Vendor>;

            vendors[0] = new Vendor()
            { VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" };
            vendors[1] = new Vendor()
            { VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" };

            //for (int i = 0; i < vendors.Count; i++)
            //{
            //    Console.WriteLine(vendors[i]);
            //}
            return vendors;
        }

        /// <summary>
        /// Retrieves from Vendor Generic List
        /// </summary>
        /// <returns></returns>
        public List<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor()
                { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                vendors.Add(new Vendor()
                { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });

            }
            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);
            }
            foreach (var vendor in vendors)
            {
                //Console.WriteLine(vendor);
            }
            //Console.WriteLine(vendors[1]);
            return vendors;
        }
        
        /// <summary>
        /// Retrieves vendor from Dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            
                var vendors = new Dictionary<string, Vendor>()
                {
                    { "ABC Corp", new Vendor()
                    { VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" }},
                    { "XYZ Inc", new Vendor()
                    { VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" }}
                };

            //Vendor vendor;
            //if (vendors.TryGetValue("XYZ Inc", out vendor))
            //    {
            //    Console.WriteLine(vendor);
            //    };

            //Console.WriteLine(vendors);
            foreach (var element in vendors)
            {
                var vendor = element.Value;
                var key = element.Key;
                Console.WriteLine($"Key: {key} Value: {vendor}");
            }
            return vendors;
        }

        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            //Call to the database to retieve the value
            //if no value returned, return the default value
            T value = defaultValue;
            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
