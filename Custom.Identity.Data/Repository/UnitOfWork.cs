


using Custom.Identity.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Custom.Identity.Data.Repository
{
    public class UnitOfWork : IDisposable
    {
        private ContextDb context = new ContextDb();


        #region Login Management
        private GenericRepository<User> userRepository;
        public GenericRepository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }
        private GenericRepository<UserRole> roleRepository;
        public GenericRepository<UserRole> RoleRepository
        {
            get
            {

                if (this.roleRepository == null)
                {
                    this.roleRepository = new GenericRepository<UserRole>(context);
                }
                return roleRepository;
            }
        }
        #endregion

        #region Subscripttions
     

        #endregion

       
        #region Services
       
        #endregion
        #region Locations
        private GenericRepository<AddressTownCity> addressTownCityRepository;
        public GenericRepository<AddressTownCity> AddressTownCityRepository
        {
            get
            {

                if (this.addressTownCityRepository == null)
                {
                    this.addressTownCityRepository = new GenericRepository<AddressTownCity>(context);
                }
                return addressTownCityRepository;
            }
        }
        private GenericRepository<AddressStateProvince> addressStateProvinceRepository;
        public GenericRepository<AddressStateProvince> AddressStateProvinceRepository
        {
            get
            {

                if (this.addressStateProvinceRepository == null)
                {
                    this.addressStateProvinceRepository = new GenericRepository<AddressStateProvince>(context);
                }
                return addressStateProvinceRepository;
            }
        }
        #endregion


        #region Demo
        //private GenericRepository<PatientAllergy> patientAllergy;
        //public GenericRepository<PatientAllergy> PatientAllergy {
        //    get {
        //        if (this.patientAllergy == null) {
        //            this.patientAllergy = new GenericRepository<PatientAllergy>(context);
        //        }
        //        return patientAllergy;
        //    }
        //}
        //private GenericRepository<Table_Child> tableChildRepository;
        //public GenericRepository<Table_Child> TableChildRepository {
        //    get {
        //        if (this.tableChildRepository == null) {
        //            this.tableChildRepository = new GenericRepository<Table_Child>(context);
        //        }
        //        return tableChildRepository;
        //    }
        //}
        //private GenericRepository<Table_Detail> tableDetailepository;
        //public GenericRepository<Table_Detail> TableDetailepository {
        //    get {
        //        if (this.tableDetailepository == null) {
        //            this.tableDetailepository = new GenericRepository<Table_Detail>(context);
        //        }
        //        return tableDetailepository;
        //    }
        //}
        //private GenericRepository<Table_Guid> table_GuidRepository;
        //public GenericRepository<Table_Guid> Table_GuidRepository {
        //    get {
        //        if (this.table_GuidRepository == null) {
        //            this.table_GuidRepository = new GenericRepository<Table_Guid>(context);
        //        }
        //        return table_GuidRepository;
        //    }
        //}
        #endregion




        //public GenericRepository<ClientContact> ClientContactRepository {
        //    get {

        //        if (this.clientContactRepository == null) {
        //            this.clientContactRepository = new GenericRepository<ClientContact>(context);
        //        }
        //        return clientContactRepository;
        //    }
        //}


        //public GenericRepository<Coverage> CoverageRepository {
        //    get {

        //        if (this.coverageRepository == null) {
        //            this.coverageRepository = new GenericRepository<Coverage>(context);
        //        }
        //        return coverageRepository;
        //    }
        //}
        //public GenericRepository<CoverageStatus> CoverageStatusRepository {
        //    get {

        //        if (this.coverageStatusRepository == null) {
        //            this.coverageStatusRepository = new GenericRepository<CoverageStatus>(context);
        //        }
        //        return coverageStatusRepository;
        //    }
        //}
        //public GenericRepository<Appointment> AppointmentRepository {
        //    get {

        //        if (this.appointmentRepository == null) {
        //            this.appointmentRepository = new GenericRepository<Appointment>(context);
        //        }
        //        return appointmentRepository;
        //    }
        //}

        //private GenericRepository<ClientClassification> clientClassificationRepository;
        //private GenericRepository<ClientCategory> clientCategoryRepository;
        //private GenericRepository<ClientTerritory> clientTerritoryRepository;

        //private GenericRepository<Client> clientRepository;
        //private GenericRepository<ClientContact> clientContactRepository;

        //private GenericRepository<Coverage> coverageRepository;
        //private GenericRepository<CoverageStatus> coverageStatusRepository;
        //private GenericRepository<Appointment> appointmentRepository;

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

}