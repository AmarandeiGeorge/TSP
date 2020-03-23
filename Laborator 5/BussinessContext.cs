namespace Lab_4
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class BussinessContext : DbContext
    {
        // Your context has been configured to use a 'BussinessContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Lab_4.BussinessContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BussinessContext' 
        // connection string in the application configuration file.
        public BussinessContext()
            : base("name=BussinessContext")
        {
        }

       

         public virtual DbSet<Business> Businesses { get; set; }

       
    }

    [Table("Business", Schema = "BazaDeDate")]
    public class Business
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessId { get; protected set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
    }
    [Table("eCommerce", Schema = "BazaDeDate")]
    public class eCommerce : Business
    {
        public string URL { get; set; }
    }
    [Table("Retail", Schema = "BazaDeDate")]
    public class Retail : Business
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIPCode { get; set; }
    }

}