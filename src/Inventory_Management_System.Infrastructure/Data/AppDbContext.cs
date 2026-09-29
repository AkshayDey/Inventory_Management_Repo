using System;
using System.Collections.Generic;
using Inventory_Management_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Management_System.Infrastructure.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppsControl> AppsControls { get; set; }

    public virtual DbSet<BKash> BKashes { get; set; }

    public virtual DbSet<BKashAccountingOne> BKashAccountingOnes { get; set; }

    public virtual DbSet<BKashAccountingTwo> BKashAccountingTwos { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<BankAccountingOne> BankAccountingOnes { get; set; }

    public virtual DbSet<BankAccountingTwo> BankAccountingTwos { get; set; }

    public virtual DbSet<CardOne> CardOnes { get; set; }

    public virtual DbSet<CardTwo> CardTwos { get; set; }

    public virtual DbSet<CashAccountingOne> CashAccountingOnes { get; set; }

    public virtual DbSet<CashAccountingTwo> CashAccountingTwos { get; set; }

    public virtual DbSet<ChequeOne> ChequeOnes { get; set; }

    public virtual DbSet<ChequeTwo> ChequeTwos { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CustomerLedgerOne> CustomerLedgerOnes { get; set; }

    public virtual DbSet<CustomerLedgerTwo> CustomerLedgerTwos { get; set; }

    public virtual DbSet<CustomerOne> CustomerOnes { get; set; }

    public virtual DbSet<CustomerTwo> CustomerTwos { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeSalary> EmployeeSalaries { get; set; }

    public virtual DbSet<ExpenseOne> ExpenseOnes { get; set; }

    public virtual DbSet<ExpenseSector> ExpenseSectors { get; set; }

    public virtual DbSet<ExpenseTwo> ExpenseTwos { get; set; }

    public virtual DbSet<LoanOne> LoanOnes { get; set; }

    public virtual DbSet<LoanSector> LoanSectors { get; set; }

    public virtual DbSet<LoanTwo> LoanTwos { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<ModulePageInfo> ModulePageInfos { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderInfoOne> OrderInfoOnes { get; set; }

    public virtual DbSet<ProductAdjustmentOne> ProductAdjustmentOnes { get; set; }

    public virtual DbSet<ProductAdjustmentTwo> ProductAdjustmentTwos { get; set; }

    public virtual DbSet<ProductNameOne> ProductNameOnes { get; set; }

    public virtual DbSet<ProductNameTwo> ProductNameTwos { get; set; }

    public virtual DbSet<ProductOne> ProductOnes { get; set; }

    public virtual DbSet<ProductTwo> ProductTwos { get; set; }

    public virtual DbSet<PurchaseOne> PurchaseOnes { get; set; }

    public virtual DbSet<PurchaseProductOne> PurchaseProductOnes { get; set; }

    public virtual DbSet<PurchaseProductTwo> PurchaseProductTwos { get; set; }

    public virtual DbSet<PurchaseTwo> PurchaseTwos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleModule> RoleModules { get; set; }

    public virtual DbSet<SalesOne> SalesOnes { get; set; }

    public virtual DbSet<SalesProductOne> SalesProductOnes { get; set; }

    public virtual DbSet<SalesProductTwo> SalesProductTwos { get; set; }

    public virtual DbSet<SalesReturn> SalesReturns { get; set; }

    public virtual DbSet<SalesReturnDetail> SalesReturnDetails { get; set; }

    public virtual DbSet<SalesTwo> SalesTwos { get; set; }

    public virtual DbSet<SalesmanTarget> SalesmanTargets { get; set; }

    public virtual DbSet<SalesmanTargetInfo> SalesmanTargetInfos { get; set; }

    public virtual DbSet<StoreOne> StoreOnes { get; set; }

    public virtual DbSet<StoreTwo> StoreTwos { get; set; }

    public virtual DbSet<SupplierOne> SupplierOnes { get; set; }

    public virtual DbSet<SupplierPaymentOne> SupplierPaymentOnes { get; set; }

    public virtual DbSet<SupplierPaymentTwo> SupplierPaymentTwos { get; set; }

    public virtual DbSet<SupplierTwo> SupplierTwos { get; set; }

    public virtual DbSet<Transfer> Transfers { get; set; }

    public virtual DbSet<TransferOne> TransferOnes { get; set; }

    public virtual DbSet<TransferTwo> TransferTwos { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    public virtual DbSet<UserModule> UserModules { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PJLCICT-Akshay;Database=Shop_DB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppsControl>(entity =>
        {
            entity.HasKey(e => e.AppsControlId).HasName("PK__AppsCont__6F4DAFC2721A1D72");

            entity.ToTable("AppsControl");

            entity.Property(e => e.NotificationMessage).HasColumnType("text");
            entity.Property(e => e.PaymentNotificationMessage).HasColumnType("text");
        });

        modelBuilder.Entity<BKash>(entity =>
        {
            entity.HasKey(e => e.BKashId).HasName("PK__bKash__D30ECD061D19CB27");

            entity.ToTable("bKash");

            entity.Property(e => e.BKashId).HasColumnName("bKashId");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccountType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<BKashAccountingOne>(entity =>
        {
            entity.HasKey(e => e.BKashAccountingId).HasName("PK__bKashAcc__21303858A558C45B");

            entity.ToTable("bKashAccountingOne");

            entity.Property(e => e.BKashAccountingId).HasColumnName("bKashAccountingId");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BKashId).HasColumnName("bKashId");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BKashAccountingTwo>(entity =>
        {
            entity.HasKey(e => e.BKashAccountingId).HasName("PK__bKashAcc__21303858D7686925");

            entity.ToTable("bKashAccountingTwo");

            entity.Property(e => e.BKashAccountingId).HasColumnName("bKashAccountingId");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BKashId).HasColumnName("bKashId");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("PK__BankAcco__AA08CB13501AB28A");

            entity.Property(e => e.AccHolderName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccountNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BankAccountingOne>(entity =>
        {
            entity.HasKey(e => e.BankAccountingId).HasName("PK__BankAcco__AE3A7AD6016A1EC1");

            entity.ToTable("BankAccountingOne");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BankAccountingTwo>(entity =>
        {
            entity.HasKey(e => e.BankAccountingId).HasName("PK__BankAcco__AE3A7AD6B0C9515B");

            entity.ToTable("BankAccountingTwo");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CardOne>(entity =>
        {
            entity.HasKey(e => e.CardId).HasName("PK__CardOne__55FECDAE6B2A9049");

            entity.ToTable("CardOne");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CardHolderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CardNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CardType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CardTwo>(entity =>
        {
            entity.HasKey(e => e.CardId).HasName("PK__CardTwo__55FECDAE7BCD6E51");

            entity.ToTable("CardTwo");

            entity.Property(e => e.Amount)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BankName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CardHolderName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CardNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CardType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CashAccountingOne>(entity =>
        {
            entity.HasKey(e => e.CashAccountingId).HasName("PK__CashAcco__749745C2B66562CF");

            entity.ToTable("CashAccountingOne");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CashAccountingTwo>(entity =>
        {
            entity.HasKey(e => e.CashAccountingId).HasName("PK__CashAcco__749745C20FED51FF");

            entity.ToTable("CashAccountingTwo");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChequeOne>(entity =>
        {
            entity.HasKey(e => e.ChequeId).HasName("PK__ChequeOn__B816D9F03355DEED");

            entity.ToTable("ChequeOne");

            entity.Property(e => e.AccountHolderName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankAndBranchName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewChequeNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChequeTwo>(entity =>
        {
            entity.HasKey(e => e.ChequeId).HasName("PK__ChequeTw__B816D9F02FA67E17");

            entity.ToTable("ChequeTwo");

            entity.Property(e => e.AccountHolderName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankAndBranchName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewChequeNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Company__2D971CACF88DF856");

            entity.ToTable("Company");

            entity.Property(e => e.CompanyAddress).HasColumnType("text");
            entity.Property(e => e.CompanyLogo).IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPersonName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPersonPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Tiin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIIN");
            entity.Property(e => e.TradeLicence)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CustomerLedgerOne>(entity =>
        {
            entity.HasKey(e => e.CustomerLedgerId).HasName("PK__Customer__3F764B0CBCF4FF88");

            entity.ToTable("CustomerLedgerOne");

            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.SalesAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CustomerLedgerTwo>(entity =>
        {
            entity.HasKey(e => e.CustomerLedgerId).HasName("PK__Customer__3F764B0CE8D79A81");

            entity.ToTable("CustomerLedgerTwo");

            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.SalesAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CustomerOne>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D87DBD2083");

            entity.ToTable("CustomerOne");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.CustomerAddress).HasColumnType("text");
            entity.Property(e => e.CustomerBankAccount)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOwnerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOwnerPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<CustomerTwo>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D85A41DF00");

            entity.ToTable("CustomerTwo");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.CustomerAddress).HasColumnType("text");
            entity.Property(e => e.CustomerBankAccount)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOwnerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOwnerPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11589324A4");

            entity.ToTable("Employee");

            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmployeeSalary>(entity =>
        {
            entity.HasKey(e => e.EmployeeSalaryId).HasName("PK__Employee__09720DBF549DDE4F");

            entity.ToTable("EmployeeSalary");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<ExpenseOne>(entity =>
        {
            entity.HasKey(e => e.ExpenseId).HasName("PK__ExpenseO__1445CFD3980F05E0");

            entity.ToTable("ExpenseOne");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<ExpenseSector>(entity =>
        {
            entity.HasKey(e => e.ExpenseSectorId).HasName("PK__ExpenseS__60D037618526476E");

            entity.ToTable("ExpenseSector");

            entity.Property(e => e.ExpenseSectorName).IsUnicode(false);
        });

        modelBuilder.Entity<ExpenseTwo>(entity =>
        {
            entity.HasKey(e => e.ExpenseId).HasName("PK__ExpenseT__1445CFD34C022FDC");

            entity.ToTable("ExpenseTwo");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<LoanOne>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PK__LoanOne__4F5AD457A7070740");

            entity.ToTable("LoanOne");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoanSector>(entity =>
        {
            entity.HasKey(e => e.LoanSectorId).HasName("PK__LoanSect__D492ED50A830F739");

            entity.ToTable("LoanSector");

            entity.Property(e => e.SectorName).IsUnicode(false);
        });

        modelBuilder.Entity<LoanTwo>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PK__LoanTwo__4F5AD457623C7C56");

            entity.ToTable("LoanTwo");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__Module__2B7477A72E9BC3EC");

            entity.ToTable("Module");

            entity.Property(e => e.ModuleName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModulePageInfo>(entity =>
        {
            entity.HasKey(e => e.ModulePageId).HasName("PK__ModulePa__0F5B2C125319A565");

            entity.ToTable("ModulePageInfo");

            entity.Property(e => e.PageName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.ToTable("Note");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Note1)
                .IsUnicode(false)
                .HasColumnName("Note");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailsId);

            entity.Property(e => e.FreeItem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewTotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<OrderInfoOne>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("OrderInfoOne");

            entity.Property(e => e.BalanceForward).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DueAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewNetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NewTotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ProductAdjustmentOne>(entity =>
        {
            entity.HasKey(e => e.ProductAdjustmentId).HasName("PK__ProductA__C3F94F4352E83B1F");

            entity.ToTable("ProductAdjustmentOne");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<ProductAdjustmentTwo>(entity =>
        {
            entity.HasKey(e => e.ProductAdjustmentId).HasName("PK__ProductA__C3F94F43D9438D43");

            entity.ToTable("ProductAdjustmentTwo");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<ProductNameOne>(entity =>
        {
            entity.HasKey(e => e.ProductNameId).HasName("PK__ProductN__343A705CC1623652");

            entity.ToTable("ProductNameOne");

            entity.Property(e => e.ProductName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductNameTwo>(entity =>
        {
            entity.HasKey(e => e.ProductNameId).HasName("PK__ProductN__343A705C563605FD");

            entity.ToTable("ProductNameTwo");

            entity.Property(e => e.ProductName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductOne>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__ProductO__B40CC6CDF77D30F4");

            entity.ToTable("ProductOne");

            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Model).IsUnicode(false);
            entity.Property(e => e.ProductName).IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ProductTwo>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__ProductT__B40CC6CD4112C50A");

            entity.ToTable("ProductTwo");

            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<PurchaseOne>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PK__Purchase__6B0A6BBE6D7FA8FC");

            entity.ToTable("PurchaseOne");

            entity.Property(e => e.BalanceForward).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DueAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.SupplierInvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PurchaseProductOne>(entity =>
        {
            entity.HasKey(e => e.PurchaseProductTableId).HasName("PK__Purchase__A4E042CCF9C09672");

            entity.ToTable("PurchaseProductOne");

            entity.Property(e => e.PricePerPiece).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SecretCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SellingPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PurchaseProductTwo>(entity =>
        {
            entity.HasKey(e => e.PurchaseProductTableId).HasName("PK__Purchase__A4E042CC4C14AC25");

            entity.ToTable("PurchaseProductTwo");

            entity.Property(e => e.PricePerPiece).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PurchaseTwo>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PK__Purchase__6B0A6BBE0DAE7931");

            entity.ToTable("PurchaseTwo");

            entity.Property(e => e.BalanceForward).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DueAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.SupplierInvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE1AE616936C");

            entity.ToTable("Role");

            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoleModule>(entity =>
        {
            entity.HasKey(e => e.RoleModuleId).HasName("PK__RoleModu__87A83030613C17B3");

            entity.ToTable("RoleModule");
        });

        modelBuilder.Entity<SalesOne>(entity =>
        {
            entity.HasKey(e => e.SalesId).HasName("PK__SalesOne__C952FB32ED220A08");

            entity.ToTable("SalesOne");

            entity.Property(e => e.BalanceForward).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChangeAmount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CustomerMobileNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.DesignCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DueAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.GivenAmount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.HandInvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SalesProductOne>(entity =>
        {
            entity.HasKey(e => e.SalesProductId).HasName("PK__SalesPro__C7284E0F21854369");

            entity.ToTable("SalesProductOne");

            entity.Property(e => e.PricePerPiece).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SalesProductTwo>(entity =>
        {
            entity.HasKey(e => e.SalesProductId).HasName("PK__SalesPro__C7284E0FBDF106CC");

            entity.ToTable("SalesProductTwo");

            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PricePerPiece).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SalesReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesReturn");

            entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.SalesReturnId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalesReturnDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PricePerPiece).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.SalesReturnDetailsId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SalesTwo>(entity =>
        {
            entity.HasKey(e => e.SalesId).HasName("PK__SalesTwo__C952FB32773AA59C");

            entity.ToTable("SalesTwo");

            entity.Property(e => e.BalanceForward).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.DesignCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DueAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.HandInvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SalesmanTarget>(entity =>
        {
            entity.ToTable("SalesmanTarget");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).IsUnicode(false);
        });

        modelBuilder.Entity<SalesmanTargetInfo>(entity =>
        {
            entity.ToTable("SalesmanTargetInfo");

            entity.Property(e => e.OrderAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<StoreOne>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StoreOne");

            entity.Property(e => e.AvgUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LatestUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.StoreId).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<StoreTwo>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK__StoreTwo__3B82F10179BA3CA3");

            entity.ToTable("StoreTwo");

            entity.Property(e => e.AvgUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LatestUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SupplierOne>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE666B4646E8D0E");

            entity.ToTable("SupplierOne");

            entity.Property(e => e.BankAccount)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankAccountDetails).HasColumnType("text");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ContactPersonPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SupplierPaymentOne>(entity =>
        {
            entity.HasKey(e => e.SupplierPaymentId).HasName("PK__Supplier__DC6B0E3E8F9A4977");

            entity.ToTable("SupplierPaymentOne");

            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SupplierPaymentTwo>(entity =>
        {
            entity.HasKey(e => e.SupplierPaymentId).HasName("PK__Supplier__DC6B0E3EDB713819");

            entity.ToTable("SupplierPaymentTwo");

            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasColumnType("text");
        });

        modelBuilder.Entity<SupplierTwo>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE666B4EFC24AD5");

            entity.ToTable("SupplierTwo");

            entity.Property(e => e.BankAccount)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankAccountDetails).HasColumnType("text");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ContactPersonPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasColumnType("text");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Transfer>(entity =>
        {
            entity.HasKey(e => e.TransferId).HasName("PK_Transfer_1");

            entity.ToTable("Transfer");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TransferOne>(entity =>
        {
            entity.HasKey(e => e.TransferId).HasName("PK_Transfer");

            entity.ToTable("TransferOne");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtraAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FromTransferHead)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.ToTransferHead)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransferTwo>(entity =>
        {
            entity.HasKey(e => e.TransferId);

            entity.ToTable("TransferTwo");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtraAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FromTransferHead)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.ToTransferHead)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserInfo__1788CC4CD6B8869F");

            entity.ToTable("UserInfo");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LockedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserImage).IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserModule>(entity =>
        {
            entity.HasKey(e => e.UserModuleId).HasName("PK__UserModu__DB031F90C1323378");

            entity.ToTable("UserModule");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("PK__Warehous__2608AFF9E9DA74DE");

            entity.ToTable("Warehouse");

            entity.Property(e => e.AssetProductValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CashInHand).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseCapacity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
