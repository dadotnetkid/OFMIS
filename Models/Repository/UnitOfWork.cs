using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CMS.Models;
using Newtonsoft.Json;


namespace Models.Repository
{
    public partial class UnitOfWork : IDisposable
    {
        public DbContext context;

        public UnitOfWork()
        {
            context = ModelDb.Create(DataSource.ConnectionString);//(/*DataSource.ConnectionString ?? context.Database.Connection.ConnectionString*/);
        }
        public UnitOfWork(DbContext dbContext)
        {
            this.context = dbContext;
        }
        public UnitOfWork(UnitOfWorkSettings settings)
        {

        }

        private GenericRepository<ActionTakens> _ActionTakensRepo;
        public GenericRepository<ActionTakens> ActionTakensRepo
        {
            get
            {
                if (this._ActionTakensRepo == null)
                    this._ActionTakensRepo = new GenericRepository<ActionTakens>(context);
                return _ActionTakensRepo;
            }
            set { _ActionTakensRepo = value; }
        }
        private GenericRepository<TrashBin> _TrashBinRepo;
        public GenericRepository<TrashBin> TrashBinRepo
        {
            get
            {
                if (this._TrashBinRepo == null)
                    this._TrashBinRepo = new GenericRepository<TrashBin>(context);
                return _TrashBinRepo;
            }
            set { _TrashBinRepo = value; }
        }
        private GenericRepository<ICSDetails> _ICSDetailsRepo;
        public GenericRepository<ICSDetails> ICSDetailsRepo
        {
            get
            {
                if (this._ICSDetailsRepo == null)
                    this._ICSDetailsRepo = new GenericRepository<ICSDetails>(context);
                return _ICSDetailsRepo;
            }
            set { _ICSDetailsRepo = value; }
        }
        private GenericRepository<ICS> _ICSRepo;
        public GenericRepository<ICS> ICSRepo
        {
            get
            {
                if (this._ICSRepo == null)
                    this._ICSRepo = new GenericRepository<ICS>(context);
                return _ICSRepo;
            }
            set { _ICSRepo = value; }
        }

        private GenericRepository<PARDetails> _PARDetailsRepo;
        public GenericRepository<PARDetails> PARDetailsRepo
        {
            get
            {
                if (this._PARDetailsRepo == null)
                    this._PARDetailsRepo = new GenericRepository<PARDetails>(context);
                return _PARDetailsRepo;
            }
            set { _PARDetailsRepo = value; }
        }
        private GenericRepository<PAR> _PARRepo;
        public GenericRepository<PAR> PARRepo
        {
            get
            {
                if (this._PARRepo == null)
                    this._PARRepo = new GenericRepository<PAR>(context);
                return _PARRepo;
            }
            set { _PARRepo = value; }
        }

        public UnitOfWork(bool lazyLoadingEnabled, bool proxyCreationEnabled)
        {
            context = ModelDb.Create(DataSource.ConnectionString);//(/*DataSource.ConnectionString ?? context.Database.Connection.ConnectionString*/);
            this.context.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
            this.context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }

        private GenericRepository<Liquidations> _LiquidationsRepo;
        public GenericRepository<Liquidations> LiquidationsRepo
        {
            get
            {
                if (this._LiquidationsRepo == null)
                    this._LiquidationsRepo = new GenericRepository<Liquidations>(context);
                return _LiquidationsRepo;
            }
            set { _LiquidationsRepo = value; }
        }

        private GenericRepository<PISDetails> _PISDetailsRepo;
        public GenericRepository<PISDetails> PISDetailsRepo
        {
            get
            {
                if (this._PISDetailsRepo == null)
                    this._PISDetailsRepo = new GenericRepository<PISDetails>(context);
                return _PISDetailsRepo;
            }
            set { _PISDetailsRepo = value; }
        }
        private GenericRepository<PIS> _PISRepo;
        public GenericRepository<PIS> PISRepo
        {
            get
            {
                if (this._PISRepo == null)
                    this._PISRepo = new GenericRepository<PIS>(context);
                return _PISRepo;
            }
            set { _PISRepo = value; }
        }

        private GenericRepository<AIRDetails> _AIRDetailsRepo;
        public GenericRepository<AIRDetails> AIRDetailsRepo
        {
            get
            {
                if (this._AIRDetailsRepo == null)
                    this._AIRDetailsRepo = new GenericRepository<AIRDetails>(context);
                return _AIRDetailsRepo;
            }
            set { _AIRDetailsRepo = value; }
        }
        private GenericRepository<AIReports> _AIReportsRepo;
        public GenericRepository<AIReports> AIReportsRepo
        {
            get
            {
                if (this._AIReportsRepo == null)
                    this._AIReportsRepo = new GenericRepository<AIReports>(context);
                return _AIReportsRepo;
            }
            set { _AIReportsRepo = value; }
        }
        private GenericRepository<DocumentActions> _DocumentActionsRepo;
        public GenericRepository<DocumentActions> DocumentActionsRepo
        {
            get
            {
                if (this._DocumentActionsRepo == null)
                    this._DocumentActionsRepo = new GenericRepository<DocumentActions>(context);
                return _DocumentActionsRepo;
            }
            set { _DocumentActionsRepo = value; }
        }
        private GenericRepository<Actions> _ActionsRepo;
        public GenericRepository<Actions> ActionsRepo
        {
            get
            {
                if (this._ActionsRepo == null)
                    this._ActionsRepo = new GenericRepository<Actions>(context);
                return _ActionsRepo;
            }
            set { _ActionsRepo = value; }
        }
        private GenericRepository<APRDetails> _APRDetailsRepo;
        public GenericRepository<APRDetails> APRDetailsRepo
        {
            get
            {
                if (this._APRDetailsRepo == null)
                    this._APRDetailsRepo = new GenericRepository<APRDetails>(context);
                return _APRDetailsRepo;
            }
            set { _APRDetailsRepo = value; }
        }
        private GenericRepository<APRs> _APRsRepo;
        public GenericRepository<APRs> APRsRepo
        {
            get
            {
                if (this._APRsRepo == null)
                    this._APRsRepo = new GenericRepository<APRs>(context);
                return _APRsRepo;
            }
            set { _APRsRepo = value; }
        }

        private GenericRepository<Letters> _LettersRepo;
        public GenericRepository<Letters> LettersRepo
        {
            get
            {
                if (this._LettersRepo == null)
                    this._LettersRepo = new GenericRepository<Letters>(context);
                return _LettersRepo;
            }
            set { _LettersRepo = value; }
        }
        private GenericRepository<AOQDetails> _AOQDetailsRepo;
        public GenericRepository<AOQDetails> AOQDetailsRepo
        {
            get
            {
                if (this._AOQDetailsRepo == null)
                    this._AOQDetailsRepo = new GenericRepository<AOQDetails>(context);
                return _AOQDetailsRepo;
            }
            set { _AOQDetailsRepo = value; }
        }
        private GenericRepository<AOQ> _AOQRepo;
        public GenericRepository<AOQ> AOQRepo
        {
            get
            {
                if (this._AOQRepo == null)
                    this._AOQRepo = new GenericRepository<AOQ>(context);
                return _AOQRepo;
            }
            set { _AOQRepo = value; }
        }

        private GenericRepository<PayrollDifferentialDetails> _PayrollDifferentialDetailsRepo;
        public GenericRepository<PayrollDifferentialDetails> PayrollDifferentialDetailsRepo
        {
            get
            {
                if (this._PayrollDifferentialDetailsRepo == null)
                    this._PayrollDifferentialDetailsRepo = new GenericRepository<PayrollDifferentialDetails>(context);
                return _PayrollDifferentialDetailsRepo;
            }
            set { _PayrollDifferentialDetailsRepo = value; }
        }

        private GenericRepository<PayrollDifferentials> _PayrollDifferentialsRepo;
        public GenericRepository<PayrollDifferentials> PayrollDifferentialsRepo
        {
            get
            {
                if (this._PayrollDifferentialsRepo == null)
                    this._PayrollDifferentialsRepo = new GenericRepository<PayrollDifferentials>(context);
                return _PayrollDifferentialsRepo;
            }
            set { _PayrollDifferentialsRepo = value; }
        }


        private GenericRepository<Templates> _TemplatesRepo;
        public GenericRepository<Templates> TemplatesRepo
        {
            get
            {
                if (this._TemplatesRepo == null)
                    this._TemplatesRepo = new GenericRepository<Templates>(context);
                return _TemplatesRepo;
            }
            set { _TemplatesRepo = value; }
        }

        private GenericRepository<ControlNumbers> _ControlNumbersRepo;
        public GenericRepository<ControlNumbers> ControlNumbersRepo
        {
            get
            {
                if (this._ControlNumbersRepo == null)
                    this._ControlNumbersRepo = new GenericRepository<ControlNumbers>(context);
                return _ControlNumbersRepo;
            }
            set { _ControlNumbersRepo = value; }
        }
        private GenericRepository<AllotmentLetter> _AllotmentLetterRepo;
        public GenericRepository<AllotmentLetter> AllotmentLetterRepo
        {
            get
            {
                if (this._AllotmentLetterRepo == null)
                    this._AllotmentLetterRepo = new GenericRepository<AllotmentLetter>(context);
                return _AllotmentLetterRepo;
            }
            set { _AllotmentLetterRepo = value; }
        }

        private GenericRepository<BACMembers> _BACMembersRepo;
        public GenericRepository<BACMembers> BACMembersRepo
        {
            get
            {
                if (this._BACMembersRepo == null)
                    this._BACMembersRepo = new GenericRepository<BACMembers>(context);
                return _BACMembersRepo;
            }
            set { _BACMembersRepo = value; }
        }

        private GenericRepository<PayrollWageDetails> _PayrollWageDetailsRepo;
        public GenericRepository<PayrollWageDetails> PayrollWageDetailsRepo
        {
            get
            {
                if (this._PayrollWageDetailsRepo == null)
                    this._PayrollWageDetailsRepo = new GenericRepository<PayrollWageDetails>(context);
                return _PayrollWageDetailsRepo;
            }
            set { _PayrollWageDetailsRepo = value; }
        }

        private GenericRepository<PayrollWages> _PayrollWagesRepo;
        public GenericRepository<PayrollWages> PayrollWagesRepo
        {
            get
            {
                if (this._PayrollWagesRepo == null)
                    this._PayrollWagesRepo = new GenericRepository<PayrollWages>(context);
                return _PayrollWagesRepo;
            }
            set { _PayrollWagesRepo = value; }
        }

        private GenericRepository<Categories> _CategoriesRepo;
        public GenericRepository<Categories> CategoriesRepo
        {
            get
            {
                if (this._CategoriesRepo == null)
                    this._CategoriesRepo = new GenericRepository<Categories>(context);
                return _CategoriesRepo;
            }
            set { _CategoriesRepo = value; }
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
        private GenericRepository<Signatories> _Signatories;
        public GenericRepository<Signatories> Signatories
        {
            get
            {
                if (this._Signatories == null)
                    this._Signatories = new GenericRepository<Signatories>(context);
                return _Signatories;
            }
            set { _Signatories = value; }
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


        private GenericRepository<CMS_USER> _CMS_USERRepo;
        public GenericRepository<CMS_USER> CMS_USERRepo
        {
            get
            {
                if (this._CMS_USERRepo == null)
                    this._CMS_USERRepo = new GenericRepository<CMS_USER>(context);
                return _CMS_USERRepo;
            }
            set { _CMS_USERRepo = value; }
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