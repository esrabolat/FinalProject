﻿using Coree.Entities.Concrete;
using Coree.Utilities.Results;
using Coree.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Text;

namespace Business.Abstract
{

    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
