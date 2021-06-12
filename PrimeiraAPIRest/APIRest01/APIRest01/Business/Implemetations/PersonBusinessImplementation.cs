using APIRest01.Model;
using APIRest01.Model.Context;
using APIRest01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace APIRest01.Business.Implemetations {
    public class PersonBusinessImplementation : IPersonBusiness {

        private readonly IRepository<Person> _repository;

        public PersonBusinessImplementation(IRepository<Person> repository) {
            _repository = repository;
        }

        public Person Create(Person person) {
        
            return _repository.Create(person);
        }

        public void Delete(long id) {
            _repository.Delete(id);
        }

        public List<Person> FindAll() { 
            
            return _repository.FindAll();

        }

        public Person FindById(long id) {
            return _repository.FindById(id);
        }

        public Person Update(Person person) {
            return _repository.Update(person);
        }

    }

    }
