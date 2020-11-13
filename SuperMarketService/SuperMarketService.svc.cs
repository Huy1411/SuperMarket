using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SuperMarketService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SuperMarketService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SuperMarketService.svc or SuperMarketService.svc.cs at the Solution Explorer and start debugging.
    public class SuperMarketService : ISuperMarketService
    {
        SuperMarketDBDataContext data = new SuperMarketDBDataContext();

        public bool AddEmployee(Employee employee)
        {
            try
            {
                data.Employees.InsertOnSubmit(employee);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddPayment(Payment payment)
        {
            try
            {
                data.Payments.InsertOnSubmit(payment);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddProvider(Provider provider)
        {
            try
            {
                data.Providers.InsertOnSubmit(provider);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddRole(Role role)
        {
            try
            {
                data.Roles.InsertOnSubmit(role);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteEmployee(string id)
        {
            try
            {
                var employee = data.Employees.Where(b => b.ID == int.Parse(id)).FirstOrDefault();
                data.Employees.DeleteOnSubmit(employee);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePayment(string id)
        {
            try
            {
                var payment = data.Payments.Where(b => b.ID == int.Parse(id)).FirstOrDefault();
                data.Payments.DeleteOnSubmit(payment);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public bool DeleteProvider(string id)
        {
            try
            {
                var provider = data.Providers.Where(b => b.ID == int.Parse(id)).FirstOrDefault();
                data.Providers.DeleteOnSubmit(provider);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteRole(string id)
        {
            try
            {
                var role = data.Roles.Where(b => b.ID == int.Parse(id)).FirstOrDefault();
                data.Roles.DeleteOnSubmit(role);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditEmployee(string id, Employee newEmployee)
        {
            try
            {
                var employee = data.Employees.Where(b => b.ID == int.Parse(id)).FirstOrDefault();
                data.Employees.DeleteOnSubmit(employee);
                data.Employees.InsertOnSubmit(newEmployee);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditPayment(string id, Payment newPayment)
        {
            try
            {
                var payment = data.Payments.Where(b => b.ID== int.Parse(id)).FirstOrDefault();
                data.Payments.DeleteOnSubmit(payment);
                data.Payments.InsertOnSubmit(newPayment);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditProvider(string id, Provider newProvider)
        {
            try
            {
                var provider = data.Providers.Where(b => b.ID == int.Parse(id)).FirstOrDefault();
                data.Providers.DeleteOnSubmit(provider);
                data.Providers.InsertOnSubmit(newProvider);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditRole(string id, Role newRole)
        {
            try
            {
                var role = data.Roles.Where(b => b.ID == int.Parse(id)).FirstOrDefault();
                data.Roles.DeleteOnSubmit(role);
                data.Roles.InsertOnSubmit(newRole);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                var employees = (from employee in data.Employees select employee).ToList();
                return employees;
            }
            catch { return null; }
        }

        public List<Payment> GetPayments()
        {
            try
            {
                var payments = (from payment in data.Payments select payment).ToList();
                return payments;
            }
            catch { return null; }
        }

        public List<Provider> GetProviders()
        {
            try
            {
                var providers = (from provider in data.Providers select provider).ToList();
                return providers;
            }
            catch { return null; }
        }

        public List<Role> GetRoles()
        {
            try
            {
                var roles = (from role in data.Roles select role).ToList();
                return roles;
            }
            catch { return null; }
        }
    }
}
