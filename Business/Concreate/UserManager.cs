﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetByemail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.ID == id);
        }

        public User LoginCheck(string email, string password)
        {
            return _userDal.Get(u => u.Email == email && u.Pass == password);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
