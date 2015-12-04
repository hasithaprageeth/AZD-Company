using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AZD_Company.Models
{
    #region HR Module
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Telephone { get; set; }
    }
    /*
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DepartmentID { get; set; }
        public string Role { get; set; }
        public Decimal Salary { get; set; }
    }*/

    public class SalarySheet
    {
        public int ID { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }
        public int EmployeeID { get; set; }
        public Decimal BasicSalary { get; set; }
        public Decimal Allowance { get; set; }
        public Decimal Bonous { get; set; }
        public Decimal TotalSalary { get; set; }
        public string ApprovedBy { get; set; }
    }

    public class SalaryCash
    {
        public int TransactionID { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ApprovedBy { get; set; }
        public Decimal Amount { get; set; }
    }
    #endregion


    #region Items
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemUnitPrice { get; set; }
        public int SupplierID { get; set; }
    }
    #endregion

    #region Products
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string FuelType { get; set; }
        public int CubicCapacity { get; set; }
        public string MountingType { get; set; }
        public int NoOfCylinders { get; set; }
        public string Description { get; set; }
    }
    #endregion

    #region Product Item Relationship
    public class Product_Item
    {
        public int ProductID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
    }
    #endregion

    #region Purchase Module
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }

        [DisplayName("Ordered Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string OrderedData { get; set; }

        public string OrderedBy { get; set; }
        public string Status { get; set; }

        [DisplayName("Recieved Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RecievedDate { get; set; }

        public string RecievedBy { get; set; }
        public int SupplierID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public Decimal PurchaseUnitPrice { get; set; }
        public Decimal AmountPaid { get; set; }
        public Decimal TotalAmount { get; set; }
    }

    public class PurchaseCash
    {
        public int TransactionID { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int PurchaseOrderID { get; set; }
        public string ApprovedBy { get; set; }
        public Decimal Amount { get; set; }
    }
    #endregion

    #region Item Inventory
    public class ItemStock
    {
        public int StockID { get; set; }

        [DisplayName("SubmittedDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime SubmittedDate { get; set; }

        public string SubmittedBy { get; set; }

        public int PurchaseOrderID { get; set; }
        public int ItemID { get; set; }
        public Decimal ItemUnitCost { get; set; }
        public int Quantity { get; set; }
        public int QuantityLeft { get; set; }

        [DisplayName("FinishedDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FinishedDate { get; set; }
    }
    #endregion

    #region Production Module
    public class ProductionOrder
    {
        [Required]
        [Display(Name = "Production Order ID")]
        public int ProductionOrderID { get; set; }

        [Display(Name = "Submited Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SubmitedDate { get; set; }

        [Display(Name = "Submitted By")]
        public string SubmittedBy { get; set; }

        public string Status { get; set; }

        [Display(Name = "Finished Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FinishedDate { get; set; }

        [Display(Name = "Finished Approved By")]
        public int FinishedApprovedBy { get; set; }

        public int ProductID { get; set; }
        public int Quantity { get; set; }

        [Display(Name = "Material Cost")]
        public Decimal MaterialCost { get; set; }

        [Display(Name = "Production Cost")]
        public Decimal ProductionCost { get; set; }
    }

    public class ProductionCash
    {
        public int TransactionID { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ApprovedBy { get; set; }
        public int ProductionOrderID { get; set; }
        public Decimal Amount { get; set; }
    }
    #endregion

    #region Product Inventory
    public class ProductStock
    {
        public int StockID { get; set; }

        [DisplayName("SubmittedDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime SubmittedDate { get; set; }

        public string SubmittedBy { get; set; }

        public int ProductionOrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int QuantityLeft { get; set; }
        public Decimal TotalCost { get; set; }

        [DisplayName("FinishedDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FinishedDate { get; set; }

        public string FinishedApprovedBy { get; set; }
    }
    #endregion

    #region Sales Module
    /*
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredDate { get; set; }
    }*/

    public class SalesOrder
    {
        [Required]
        [Display(Name = "Sales Order ID")]
        public int SalesOrderID { get; set; }

        [Display(Name = "Ordered Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderedDate { get; set; }

        [Display(Name = "Order Approved By")]
        public string OrderApprovedBy { get; set; }

        public string Status { get; set; }

        [Display(Name = "Delivered Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DeliveredDate { get; set; }

        [Display(Name = "Delivery Approved By")]
        public int DeliveryApprovedBy { get; set; }

        [ForeignKey("Customer")]
        [Display(Name = "Customers ID")]
        public int CustomerID { get; set; }

        [Display(Name = "Paid Amount")]
        public Decimal PaidAmount { get; set; }

        [Display(Name = "Total Amount")]
        public Decimal TotalAmount { get; set; }
    }

    public class SalesOrderItem
    {
        [ForeignKey("SalesOrder")]
        [Display(Name = "Sales Order ID")]
        public int SalesOrderID { get; set; }

        [ForeignKey("Product")]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        [Display(Name = "Sale Unit Price")]
        public Decimal SaleUnitPrice { get; set; }

        [ForeignKey("ProductStock")]
        [Display(Name = "Stock ID")]
        public int StockID { get; set; }
    }

    public class SalesCash
    {
        [Required]
        [Display(Name = "Transaction ID")]
        public int TransactionID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public String Description { get; set; }

        [Display(Name = "Sales Order ID")]
        public int SalesOrderID { get; set; }

        [Display(Name = "Approved By")]
        public int ApprovedBy { get; set; }

        public Decimal Amount { get; set; }
    }
    #endregion

    #region Finance Module
    public class CashOutFlaws
    {
        [Required]
        [Display(Name = "Transaction ID")]
        public int TransactionID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public String Description { get; set; }
        public int ReferenceID { get; set; }
        public String DepartmentName { get; set; }

        [Display(Name = "Amount")]
        public Decimal Amount { get; set; }
    }

    public class CashInFlaws
    {
        [Required]
        [Display(Name = "Transaction ID")]
        public int TransactionID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public String Description { get; set; }
        public int ReferenceID { get; set; }
        public String DepartmentName { get; set; }

        [Display(Name = "Amount")]
        public Decimal Amount { get; set; }
    }

    public class MonthlySummeryReport
    {
        [Required]
        public int ID { get; set; }

        public Decimal Income { get; set; }
        public Decimal Outcome { get; set; }
        public Decimal Profit { get; set; }
    }
    #endregion

    #region DBContext
    public class AZDDBContext : DbContext
    {
        public DbSet<MonthlySummeryReport> MonthlySummeryReport { get; set; }
        public DbSet<CashInFlaws> CashInFlaws { get; set; }
        public DbSet<CashOutFlaws> CashOutFlaws { get; set; }

        public DbSet<SalesCash> SalesCash { get; set; }
    }
    #endregion
}