using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.models
{
    public partial class Person
    {
        public Person()
        {
            Contractors = new HashSet<Contractor>();
            Costumers = new HashSet<Costumer>();
            SupplierCpas = new HashSet<Supplier>();
            SupplierPeople = new HashSet<Supplier>();
            WorkerPeople = new HashSet<Worker>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PsWord { get; set; }

        public virtual Worker WorkerWorkerNavigation { get; set; }
        public virtual ICollection<Contractor> Contractors { get; set; }
        public virtual ICollection<Costumer> Costumers { get; set; }
        public virtual ICollection<Supplier> SupplierCpas { get; set; }
        public virtual ICollection<Supplier> SupplierPeople { get; set; }
        public virtual ICollection<Worker> WorkerPeople { get; set; }
    }
}
