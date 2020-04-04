using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Models.Repository
{
    public partial class UnitOfWork : IDisposable
    {
        public ModelDb context;

        public UnitOfWork()
        {
            context = ModelDb.Create(DataSource.ConnectionString);//(/*DataSource.ConnectionString ?? context.Database.Connection.ConnectionString*/);
        }
        public UnitOfWork(UnitOfWorkSettings settings)
        {

        }


        private GenericRepository<PayrollDetails> _PayrollDetailsRepo;
        public GenericRepository<PayrollDetails> PayrollDetailsRepo
        {
            get
            {
                if (this._PayrollDetailsRepo == null)
                    this._PayrollDetailsRepo = new GenericRepository<PayrollDetails>(context);
                return _PayrollDetailsRepo;
            }
            set { _PayrollDetailsRepo = value; }
        }
        private GenericRepository<Payrolls> _PayrollsRepo;
        public GenericRepository<Payrolls> PayrollsRepo
        {
            get
            {
                if (this._PayrollsRepo == null)
                    this._PayrollsRepo = new GenericRepository<Payrolls>(context);
                return _PayrollsRepo;
            }
            set { _PayrollsRepo = value; }
        }
    private GenericRepository<Positions> _PositionsRepo;
        public GenericRepository<Positions> PositionsRepo
        {
            get
            {
                if (this._PositionsRepo == null)
                    this._PositionsRepo = new GenericRepository<Positions>(context);
                return _PositionsRepo;
            }
            set { _PositionsRepo = value; }
        }
        private GenericRepository<DefaultAccounts> _DefaultAccountsRepo;
        public GenericRepository<DefaultAccounts> DefaultAccountsRepo
        {
            get
            {
                if (this._DefaultAccountsRepo == null)
                    this._DefaultAccountsRepo = new GenericRepository<DefaultAccounts>(context);
                return _DefaultAccountsRepo;
            }
            set { _DefaultAccountsRepo = value; }
        }

        private GenericRepository<PODetails> _PODetailsRepo;
        public GenericRepository<PODetails> PODetailsRepo
        {
            get
            {
                if (this._PODetailsRepo == null)
                    this._PODetailsRepo = new GenericRepository<PODetails>(context);
                return _PODetailsRepo;
            }
            set { _PODetailsRepo = value; }
        }
        private GenericRepository<PRDetails> _PRDetailsRepo;
        public GenericRepository<PRDetails> PRDetailsRepo
        {
            get
            {
                if (this._PRDetailsRepo == null)
                    this._PRDetailsRepo = new GenericRepository<PRDetails>(context);
                return _PRDetailsRepo;
            }
            set { _PRDetailsRepo = value; }
        }
        private GenericRepository<PurchaseOrders> _PurchaseOrdersRepo;
        public GenericRepository<PurchaseOrders> PurchaseOrdersRepo
        {
            get
            {
                if (this._PurchaseOrdersRepo == null)
                    this._PurchaseOrdersRepo = new GenericRepository<PurchaseOrders>(context);
                return _PurchaseOrdersRepo;
            }
            set { _PurchaseOrdersRepo = value; }
        }

        private GenericRepository<PQDetails> _PQDetailsRepo;
        public GenericRepository<PQDetails> PQDetailsRepo
        {
            get
            {
                if (this._PQDetailsRepo == null)
                    this._PQDetailsRepo = new GenericRepository<PQDetails>(context);
                return _PQDetailsRepo;
            }
            set { _PQDetailsRepo = value; }
        }

        private GenericRepository<PriceQuotations> _PriceQuotationsRepo;
        public GenericRepository<PriceQuotations> PriceQuotationsRepo
        {
            get
            {
                if (this._PriceQuotationsRepo == null)
                    this._PriceQuotationsRepo = new GenericRepository<PriceQuotations>(context);
                return _PriceQuotationsRepo;
            }
            set { _PriceQuotationsRepo = value; }
        }
        public GenericRepository<PurchaseRequests> _PurchaseRequestsRepo;
        public GenericRepository<PurchaseRequests> PurchaseRequestsRepo
        {
            get
            {
                if (this._PurchaseRequestsRepo == null)
                    this._PurchaseRequestsRepo = new GenericRepository<PurchaseRequests>(context);
                return _PurchaseRequestsRepo;
            }
            set { _PurchaseRequestsRepo = value; }
        }
        private GenericRepository<Items> _ItemsRepo;
        public GenericRepository<Items> ItemsRepo
        {
            get
            {
                if (this._ItemsRepo == null)
                    this._ItemsRepo = new GenericRepository<Items>(context);
                return _ItemsRepo;
            }
            set { _ItemsRepo = value; }
        }
        private GenericRepository<Signatories> _ChiefOfOfficesRepo;
        public GenericRepository<Signatories> ChiefOfOfficesRepo
        {
            get
            {
                if (this._ChiefOfOfficesRepo == null)
                    this._ChiefOfOfficesRepo = new GenericRepository<Signatories>(context);
                return _ChiefOfOfficesRepo;
            }
            set { _ChiefOfOfficesRepo = value; }
        }

        private GenericRepository<DefaultSettings> _DefaultSettingsRepo;
        public GenericRepository<DefaultSettings> DefaultSettingsRepo
        {
            get
            {
                if (this._DefaultSettingsRepo == null)
                    this._DefaultSettingsRepo = new GenericRepository<DefaultSettings>(context);
                return _DefaultSettingsRepo;
            }
            set { _DefaultSettingsRepo = value; }
        }

        private GenericRepository<Years> _YearsRepo;
        public GenericRepository<Years> YearsRepo
        {
            get
            {
                if (this._YearsRepo == null)
                    this._YearsRepo = new GenericRepository<Years>(context);
                return _YearsRepo;
            }
            set { _YearsRepo = value; }
        }
        private GenericRepository<ReAlignments> _ReAlignmentsRepo;
        public GenericRepository<ReAlignments> ReAlignmentsRepo
        {
            get
            {
                if (this._ReAlignmentsRepo == null)
                    this._ReAlignmentsRepo = new GenericRepository<ReAlignments>(context);
                return _ReAlignmentsRepo;
            }
            set { _ReAlignmentsRepo = value; }
        }

        private GenericRepository<ORDetails> _ORDetailsRepo;
        public GenericRepository<ORDetails> ORDetailsRepo
        {
            get
            {
                if (this._ORDetailsRepo == null)
                    this._ORDetailsRepo = new GenericRepository<ORDetails>(context);
                return _ORDetailsRepo;
            }
            set { _ORDetailsRepo = value; }
        }

        private GenericRepository<Allotments> _AllotmentsRepo;
        public GenericRepository<Allotments> AllotmentsRepo
        {
            get
            {
                if (this._AllotmentsRepo == null)
                    this._AllotmentsRepo = new GenericRepository<Allotments>(context);
                return _AllotmentsRepo;
            }
            set { _AllotmentsRepo = value; }
        }

        private GenericRepository<FundTypes> _FundTypesRepo;
        public GenericRepository<FundTypes> FundTypesRepo
        {
            get
            {
                if (this._FundTypesRepo == null)
                    this._FundTypesRepo = new GenericRepository<FundTypes>(context);
                return _FundTypesRepo;
            }
            set { _FundTypesRepo = value; }
        }
        private GenericRepository<Appropriations> _AppropriationsRepoRepo;
        public GenericRepository<Appropriations> AppropriationsRepoRepo
        {
            get
            {
                if (this._AppropriationsRepoRepo == null)
                    this._AppropriationsRepoRepo = new GenericRepository<Appropriations>(context);
                return _AppropriationsRepoRepo;
            }
            set { _AppropriationsRepoRepo = value; }
        }
        private GenericRepository<Payees> _PayeesRepo;
        public GenericRepository<Payees> PayeesRepo
        {
            get
            {
                if (this._PayeesRepo == null)
                    this._PayeesRepo = new GenericRepository<Payees>(context);
                return _PayeesRepo;
            }
            set { _PayeesRepo = value; }
        }

        private GenericRepository<Obligations> _ObligationsRepo;
        public GenericRepository<Obligations> ObligationsRepo
        {
            get
            {
                if (this._ObligationsRepo == null)
                    this._ObligationsRepo = new GenericRepository<Obligations>(context);
                return _ObligationsRepo;
            }
            set { _ObligationsRepo = value; }
        }
    
     

        private GenericRepository<Offices> _OfficesRepo;
        public GenericRepository<Offices> OfficesRepo
        {
            get
            {
                if (this._OfficesRepo == null)
                    this._OfficesRepo = new GenericRepository<Offices>(context);
                return _OfficesRepo;
            }
            set { _OfficesRepo = value; }
        }
  

        private GenericRepository<Suppliers> _SuppliersRepo;
        public GenericRepository<Suppliers> SuppliersRepo
        {
            get
            {
                if (this._SuppliersRepo == null)
                    this._SuppliersRepo = new GenericRepository<Suppliers>(context);
                return _SuppliersRepo;
            }
            set { _SuppliersRepo = value; }
        }
        public bool StartConnection()
        {
            try
            {
                this.context.Database.Connection.Open();
                var res = this.UsersRepo.Fetch().Select(x => x.Id).Count();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }




        private GenericRepository<Employees> _EmployeesRepo;
        public GenericRepository<Employees> EmployeesRepo
        {
            get
            {
                if (this._EmployeesRepo == null)
                    this._EmployeesRepo = new GenericRepository<Employees>(context);
                return _EmployeesRepo;
            }
            set { _EmployeesRepo = value; }
        }

    

        private GenericRepository<Logs> _LogsRepo;
        public GenericRepository<Logs> LogsRepo
        {
            get
            {
                if (this._LogsRepo == null)
                    this._LogsRepo = new GenericRepository<Logs>(context);
                return _LogsRepo;
            }
            set { _LogsRepo = value; }
        }

        private GenericRepository<Provinces> _ProvincesRepo;
        public GenericRepository<Provinces> ProvincesRepo
        {
            get
            {
                if (this._ProvincesRepo == null)
                    this._ProvincesRepo = new GenericRepository<Provinces>(context);
                return _ProvincesRepo;
            }
            set { _ProvincesRepo = value; }
        }

        private GenericRepository<Towns> _TownsRepo;
        public GenericRepository<Towns> TownsRepo
        {
            get
            {
                if (this._TownsRepo == null)
                    this._TownsRepo = new GenericRepository<Towns>(context);
                return _TownsRepo;
            }
            set { _TownsRepo = value; }
        }


        private GenericRepository<Functions> _FunctionsRepo;
        public GenericRepository<Functions> FunctionsRepo
        {
            get
            {
                if (this._FunctionsRepo == null)
                    this._FunctionsRepo = new GenericRepository<Functions>(context);
                return _FunctionsRepo;
            }
            set { _FunctionsRepo = value; }
        }



        private GenericRepository<ControllersActions> _ControllersActionsRepo;
        public GenericRepository<ControllersActions> ControllersActionsRepo
        {
            get
            {
                if (this._ControllersActionsRepo == null)
                    this._ControllersActionsRepo = new GenericRepository<ControllersActions>(context);
                return _ControllersActionsRepo;
            }
            set { _ControllersActionsRepo = value; }
        }




        private GenericRepository<Users> usersRepo;
        public GenericRepository<Users> UsersRepo
        {
            get
            {
                if (this.usersRepo == null)
                    this.usersRepo = new GenericRepository<Users>(context);
                return usersRepo;
            }
            set { usersRepo = value; }
        }

        private GenericRepository<UserRoles> userRolesRepo;
        public GenericRepository<UserRoles> UserRolesRepo
        {
            get
            {
                if (this.userRolesRepo == null)
                    this.userRolesRepo = new GenericRepository<UserRoles>(context);
                return userRolesRepo;
            }
            set { userRolesRepo = value; }
        }




        public void Save()
        {
            context.SaveChanges();

        }


        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

    public class UnitOfWorkSettings
    {
        private bool _proxyCreationEnabled;
        private bool _lazyLoading;

        public bool LazyLoading
        {
            get
            {
                if (_lazyLoading == null)
                    _lazyLoading = true;
                return _lazyLoading;
            }
            set => _lazyLoading = value;
        }

        public bool AsNoTracking { get; set; }

        public bool ProxyCreationEnabled
        {
            get
            {
                if (_proxyCreationEnabled == null)
                    _proxyCreationEnabled = true;
                return _proxyCreationEnabled;
            }
            set => _proxyCreationEnabled = value;
        }
    }
}