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

        private GenericRepository<UserRolesInActions> _UserRolesInActionsRepo;
        public GenericRepository<UserRolesInActions> UserRolesInActionsRepo
        {
            get
            {
                if (this._UserRolesInActionsRepo == null)
                    this._UserRolesInActionsRepo = new GenericRepository<UserRolesInActions>(context);
                return _UserRolesInActionsRepo;
            }
            set { _UserRolesInActionsRepo = value; }
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