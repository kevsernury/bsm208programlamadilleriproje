﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class AgencyManager : IAgencyService
    {
        IAgencyDal _agencyDal;

        public AgencyManager(IAgencyDal agencyDal)
        {
            _agencyDal = agencyDal;
        }

        public Agency GetByID(int id)
        {
            return _agencyDal.Get(a => a.ID == id);
        }

        public Agency LoginCheck(string username, string password)
        {
            return _agencyDal.Get(a => a.UserName == username && a.Pass == password);
        }

        public void Update(Agency agency)
        {
            _agencyDal.Update(agency);
        }
    }
}
