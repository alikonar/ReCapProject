﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserId(int userId);
        IDataResult<User> GetEmail(string userMail);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
